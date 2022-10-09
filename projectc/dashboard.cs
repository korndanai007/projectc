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
    public partial class dashboard : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser; ";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM issue ", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            datais.DataSource = ds;

        }

        private void datais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datais.CurrentRow.Selected = true;
            us.Text = datais.Rows[e.RowIndex].Cells["user"].FormattedValue.ToString();
            bk.Text = datais.Rows[e.RowIndex].Cells["book"].FormattedValue.ToString();
            da.Text = datais.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
        }

        private void auserbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            aduser f = new aduser();
            f.ShowDialog();
        }

        private void abookbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f = new admin();
            f.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
        

        private void adelbtn_Click(object sender, EventArgs e)
        {
            
            
                int selectedRow = datais.CurrentCell.RowIndex;
                int deleteId = Convert.ToInt32(datais.Rows[selectedRow].Cells["id"].Value);

                MySqlConnection conn = databaseConnection();

                String sql = "DELETE FROM issue WHERE id = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                DialogResult dialogResult = MessageBox.Show("แน่ใจมั้ย", "DEL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                { 
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสำเร็จ");
                    }
                    this.Hide();
                    dashboard f = new dashboard();
                    f.ShowDialog();
                }
        }


        private void rebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            @return f = new @return();
            f.ShowDialog();
        }

        private void adashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard f = new dashboard();
            f.ShowDialog();
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
                datais.DataSource = ds;
            }
            else
            {
                MessageBox.Show("ไม่พบชื่อผู้ใช้นี้", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("enter user"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("enter user") || fname.Trim().Equals(""))
            {
                textBox1.Text = "enter user";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
