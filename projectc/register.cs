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
    public partial class register : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public register()
        {
            InitializeComponent();
        }
        
        private void regBtn2_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO duser (Name, Surname, Phone, IDCard, Address, User, Password) VALUES (@name, @sur, @tel, @card, @add, @user, @pass)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = rnamebox.Text;
            command.Parameters.Add("@sur", MySqlDbType.VarChar).Value = rsurbox.Text;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = rtelbox.Text;
            command.Parameters.Add("@card", MySqlDbType.VarChar).Value = rcardbox.Text;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = raddressbox.Text;
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = ruserbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = rpasswordbox.Text;

            db.openConnection();


            if (rnamebox.Text == "" || rsurbox.Text == "" || rtelbox.Text == "" || rcardbox.Text == "" || raddressbox.Text == "" || ruserbox.Text == "" || rpasswordbox.Text == "")
            {
                MessageBox.Show("กรูณาใส่ข้อมูล ", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ruserbox.TextLength < 3)
            {
                MessageBox.Show("กรูณาตั้งชื่อผู้ใช้ 2 ตัวอักษรขึ้นไป", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (rpasswordbox.TextLength < 3)
            {
                MessageBox.Show("กรูณาตั้งรหัสผ่าน 2 ตัวอักษรขึ้นไป", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!checkTextBoxesValues())
                {
                    if (rpasswordbox.Text.Equals(rconpass.Text))
                    {
                        if (checkUsername())
                        {
                            MessageBox.Show("ชื่อผู้ใช้ซ้ำ", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("สมัครสำเร็จ", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 user = new Form1();
                                this.Hide();
                                user.Show();
                            }
                            else
                            {
                                MessageBox.Show("ERROR");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("รหัสผู้ใช้ไม่ตรงกัน", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("กรูณาใส่ข้อมูล", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                db.closeConnection();

            }
        }
        // ตรวจชื่อผู้ใช้
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = ruserbox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM duser WHERE User = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //ลายน้ำ
        public Boolean checkTextBoxesValues()
        {
            String fname = rnamebox.Text;
            String lname = rsurbox.Text;
            String card = rcardbox.Text;
            String uname = ruserbox.Text;
            String pass = rpasswordbox.Text;

            if (fname.Equals("name")||lname.Equals("surname")||uname.Equals("user")||pass.Equals("password")||card.Equals("idcard"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rnamebox_Enter(object sender, EventArgs e)
        {
            String fname = rnamebox.Text;
            if (fname.ToLower().Trim().Equals("name"))
            {
                rnamebox.Text = "";
                rnamebox.ForeColor = Color.Black;
            }
        }

        private void rnamebox_Leave(object sender, EventArgs e)
        {
            String fname = rnamebox.Text;
            if (fname.ToLower().Trim().Equals("name") || fname.Trim().Equals(""))
            {
                rnamebox.Text = "name";
                rnamebox.ForeColor = Color.Gray;
            }
        }

        private void rsurbox_Enter(object sender, EventArgs e)
        {
            String fname = rsurbox.Text;
            if (fname.ToLower().Trim().Equals("surname"))
            {
                rsurbox.Text = "";
                rsurbox.ForeColor = Color.Black;
            }
        }

        private void rsurbox_Leave(object sender, EventArgs e)
        {
            String fname = rsurbox.Text;
            if (fname.ToLower().Trim().Equals("surname") || fname.Trim().Equals(""))
            {
                rsurbox.Text = "surname";
                rsurbox.ForeColor = Color.Gray;
            }
        }

        private void rtelbox_Enter(object sender, EventArgs e)
        {
            String fname = rtelbox.Text;
            if (fname.ToLower().Trim().Equals("phone"))
            {
                rtelbox.Text = "";
                rtelbox.ForeColor = Color.Black;
            }
        }

        private void rtelbox_Leave(object sender, EventArgs e)
        {
            String fname = rtelbox.Text;
            if (fname.ToLower().Trim().Equals("phone") || fname.Trim().Equals(""))
            {
                rtelbox.Text = "phone";
                rtelbox.ForeColor = Color.Gray;
            }
        }

        private void rcardbox_Enter(object sender, EventArgs e)
        {
            String fname = rcardbox.Text;
            if (fname.ToLower().Trim().Equals("card number"))
            {
                rcardbox.Text = "";
                rcardbox.ForeColor = Color.Black;
            }
        }

        private void rcardbox_Leave(object sender, EventArgs e)
        {
            String fname = rcardbox.Text;
            if (fname.ToLower().Trim().Equals("card number") || fname.Trim().Equals(""))
            {
                rcardbox.Text = "card number";
                rcardbox.ForeColor = Color.Gray;
            }
        }

        private void raddressbox_Enter(object sender, EventArgs e)
        {
            String fname = raddressbox.Text;
            if (fname.ToLower().Trim().Equals("address"))
            {
                raddressbox.Text = "";
                raddressbox.ForeColor = Color.Black;
            }
        }

        private void raddressbox_Leave(object sender, EventArgs e)
        {
            String fname = raddressbox.Text;
            if (fname.ToLower().Trim().Equals("address") || fname.Trim().Equals(""))
            {
                raddressbox.Text = "address";
                raddressbox.ForeColor = Color.Gray;
            }
        }

        private void ruserbox_Enter(object sender, EventArgs e)
        {
            String fname = ruserbox.Text;
            if (fname.ToLower().Trim().Equals("user"))
            {
                ruserbox.Text = "";
                ruserbox.ForeColor = Color.Black;
            }
        }

        private void ruserbox_Leave(object sender, EventArgs e)
        {
            String fname = ruserbox.Text;
            if (fname.ToLower().Trim().Equals("user") || fname.Trim().Equals(""))
            {
                ruserbox.Text = "user";
                ruserbox.ForeColor = Color.Gray;
            }
        }

        private void rpasswordbox_Enter(object sender, EventArgs e)
        {
            String fname = rpasswordbox.Text;
            if (fname.ToLower().Trim().Equals("password"))
            {
                rpasswordbox.Text = "";
                rpasswordbox.ForeColor = Color.Black;
            }
        }

        private void rpasswordbox_Leave(object sender, EventArgs e)
        {
            String fname = rpasswordbox.Text;
            if (fname.ToLower().Trim().Equals("password") || fname.Trim().Equals(""))
            {
                rpasswordbox.Text = "password";
                rpasswordbox.ForeColor = Color.Gray;
            }
        }

        private void rconpass_Enter(object sender, EventArgs e)
        {
            String fname = rconpass.Text;
            if (fname.ToLower().Trim().Equals("confirm password"))
            {
                rconpass.Text = "";
                rconpass.ForeColor = Color.Black;
            }
        }

        private void rconpass_Leave(object sender, EventArgs e)
        {
            String fname = rconpass.Text;
            if (fname.ToLower().Trim().Equals("confirm password") || fname.Trim().Equals(""))
            {
                rconpass.Text = "confirm password";
                rconpass.ForeColor = Color.Gray;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void rnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
