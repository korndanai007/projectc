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
    public partial class loginadmin : Form
    {
        public loginadmin()
        {
            InitializeComponent();
        }

        private void userbox_Enter(object sender, EventArgs e)
        {

        }

        private void adminbox_Leave(object sender, EventArgs e)
        {

        }

        private void adminbox_Enter(object sender, EventArgs e)
        {
            
        }

        private void adminbox_Leave_1(object sender, EventArgs e)
        {
            
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            
            String password = adminbox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM dadmin WHERE Passwordadmin = @pass", db.getConnection());

            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                admin mainform = new admin();
                mainform.Show();
            }

            else
            {
                
                if (password.Trim().Equals(""))
                {
                    MessageBox.Show("กรูณาใส่รหัสผ่าน", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void adminbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
