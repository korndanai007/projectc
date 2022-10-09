using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace projectc
{
    public partial class admin : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='zdatauser';username=root;password=");
        MySqlCommand command;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }


        public admin()
        {
            InitializeComponent();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser; ";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM listbook ", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            databook.DataSource = ds;
        }
        
        
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {

                MessageBox.Show("Query Not Executed");
            }
            connection.Close();
        }
        private void databook_Click(object sender, EventArgs e)
        {
            
        }
        //ปุ่มเพิ่ม รายการหนังสือ
        private void addbtn_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO listbook(id, book, title, pic, author, category) VALUES (@id,@name,@desc,@img,@aut,@cate)", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userbox.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = dec.Text;
            command.Parameters.Add("@aut", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@cate", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Inserted");
            this.Hide();
            admin f = new admin();
            f.ShowDialog();
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("OK");
                }

                else
                {
                    MessageBox.Show("Bruh");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        //ปุ่มเปลี่ยนไปหน้า user
        private void auserbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            aduser f = new aduser();
            f.ShowDialog();
        }
        //ปุ่มเปลี่ยนไปหน้า form1
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //โชว์ข้อมูลดาต้าเบส
        private void databook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databook.CurrentRow.Selected = true;
            textBox2.Text = databook.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            userbox.Text = databook.Rows[e.RowIndex].Cells["book"].FormattedValue.ToString();
            dec.Text = databook.Rows[e.RowIndex].Cells["title"].FormattedValue.ToString();
            textBox1.Text = databook.Rows[e.RowIndex].Cells["author"].FormattedValue.ToString();
            comboBox1.Text = databook.Rows[e.RowIndex].Cells["category"].FormattedValue.ToString();
            Byte[] img = (Byte[])databook.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
        }
        //ปุ่มเลือกรูปภาพ
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }


        private void asavebtn_Click(object sender, EventArgs e)
        {
            
        }
        //ปุ่มลบรายการหนังสือ
        private void adelbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("แน่ใจมั้ย", "DEL", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM listbook WHERE id = " + int.Parse(textBox2.Text);
                executeMyQuery(deleteQuery);
                

                this.Hide();
                admin f = new admin();
                f.ShowDialog();
            }
        }
        //ปุ่มแก้ไขรายการหนังสือ
        private void aeditbtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE listbook SET book=@name, title=@desc, pic=@img, author=@aut, category=@cate WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userbox.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = dec.Text;
            command.Parameters.Add("@aut", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@cate", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Updated");
            this.Hide();
            admin f = new admin();
            f.ShowDialog();
        }
        //ปุ่มเปลี่ยนไปหน้า dashboard
        private void adashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard f = new dashboard();
            f.ShowDialog();
        }
        //ปุ่มเปลี่ยนไปหน้า return
        private void rebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            @return f = new @return();
            f.ShowDialog();
        }

        private void abookbtn_Click(object sender, EventArgs e)
        {

        }

        private void databook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f = new admin();
            f.ShowDialog();
        }
    }
    }
