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
    public partial class issue : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public issue()
        {
            InitializeComponent();
        }
        
        private void issue_Load(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser; ";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM listbook ", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            databook.DataSource = ds;

            username.Text = Form1.Username;
        }
        
        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard2 f = new dashboard2();
            f.ShowDialog();
        }

        private void issuebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            issue f = new issue();
            f.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
                
        }

        private void databook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databook.CurrentRow.Selected = true;
            name.Text = databook.Rows[e.RowIndex].Cells["book"].FormattedValue.ToString();
            dec.Text = databook.Rows[e.RowIndex].Cells["title"].FormattedValue.ToString();
            textBox2.Text = databook.Rows[e.RowIndex].Cells["author"].FormattedValue.ToString();
            category.Text = databook.Rows[e.RowIndex].Cells["category"].FormattedValue.ToString();
            Byte[] img = (Byte[])databook.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
        }

        private void databook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void link_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO issue (user,book,date) VALUES('" + username.Text + "','" + name.Text + "','" + kryptonDateTimePicker1.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ยืมสำเร็จ");
            }
        }
        

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            String sql = "SELECT * FROM listbook WHERE book LIKE '" + textBox1.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);

            if (ds.Rows.Count > 0)
            {
                databook.DataSource = ds;
            }
            else
            {
                MessageBox.Show("ไม่พบ", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("enter book"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("enter book") || fname.Trim().Equals(""))
            {
                textBox1.Text = "enter book";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
