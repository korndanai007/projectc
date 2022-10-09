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
    public partial class dashboard2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public dashboard2()
        {
            InitializeComponent();
        }

        private void dashboard2_Load(object sender, EventArgs e)
        {
            username.Text = Form1.Username;
        }

        private void datais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datare.CurrentRow.Selected = true;
            us.Text = datare.Rows[e.RowIndex].Cells["user"].FormattedValue.ToString();
            bk.Text = datare.Rows[e.RowIndex].Cells["book"].FormattedValue.ToString();
            da.Text = datare.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
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

        private void rebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard2 f = new dashboard2();
            f.ShowDialog();
        }

        private void adashbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void abookbtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void auserbtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            String sql = "SELECT * FROM returnbook WHERE user = '" + textBox1.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);

            if (ds.Rows.Count > 0)
            {
                datare.DataSource = ds;
            }
            else
            {
                MessageBox.Show("ไม่พบรายการ", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

        private void issuebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            issue f = new issue();
            f.ShowDialog();
        }
    }
}
