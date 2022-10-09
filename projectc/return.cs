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

namespace projectc
{
    public partial class @return : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='issue';username=root;password=");
        public @return()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }

        
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }



       


        private void return_Load(object sender, EventArgs e)
        {
            
        }

        private void databook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databook.CurrentRow.Selected = true;
            name.Text = databook.Rows[e.RowIndex].Cells["book"].FormattedValue.ToString();
            username.Text = databook.Rows[e.RowIndex].Cells["user"].FormattedValue.ToString();
            
        }
        
        // return
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            
             
            int selectedRow = databook.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(databook.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();



            String sql = "INSERT INTO returnbook (user,book,date,pay) VALUES('" + username.Text + "','" + name.Text + "','" + kryptonDateTimePicker1.Text + "','" + textBox2.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            String sql2 = "DELETE FROM issue WHERE id = '" + deleteId + "'";

            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

           

            
            DialogResult dialogResult = MessageBox.Show("please confirm", "confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
                conn.Open();

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                conn.Close();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                conn.Open();

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                conn.Close();
            }

            showtable();

        }
        private void showtable()
        {
            MySqlConnection conn = databaseConnection();

            String sql = "SELECT * FROM issue WHERE user = '" + textBox1.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);

            databook.DataSource = ds;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            String sql = "SELECT * FROM issue WHERE user = '" + textBox1.Text + "'";

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
                MessageBox.Show("ไม่พบชื่อผู้ใช้นี้", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("enter your user"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("enter your user") || fname.Trim().Equals(""))
            {
                textBox1.Text = "enter your user";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void abookbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f = new admin();
            f.ShowDialog();
        }

        private void auserbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            aduser f = new aduser();
            f.ShowDialog();
        }

        private void adashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard f = new dashboard();
            f.ShowDialog();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            @return f = new @return();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            String fname = textBox2.Text;
            if (fname.ToLower().Trim().Equals("pay off debt"))
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            String fname = textBox2.Text;
            if (fname.ToLower().Trim().Equals("pay off debt") || fname.Trim().Equals(""))
            {
                textBox2.Text = "pay off debt";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "50";
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "120";
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "250";
        }
    }
}
