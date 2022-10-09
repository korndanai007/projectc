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
    public partial class aduser : Form
    {
        
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public aduser()
        {
            InitializeComponent();
        }
        private void aduser_Load(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=zdatauser; ";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM duser ", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            datauser.DataSource = ds;
        }
        //ปุ่มเปลี่ยนไปหน้า admin
        private void abookbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f = new admin();
            f.ShowDialog();
        }

        private void datauser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datauser.CurrentRow.Selected = true;
            rnamebox.Text = datauser.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            rsurbox.Text = datauser.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
            rtelbox.Text = datauser.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
            rcardbox.Text = datauser.Rows[e.RowIndex].Cells["IDCard"].FormattedValue.ToString();
            raddressbox.Text = datauser.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
            ruserbox.Text = datauser.Rows[e.RowIndex].Cells["User"].FormattedValue.ToString();
            rpasswordbox.Text = datauser.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
        }

        private void adelbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("แน่ใจมั้ย", "DEL", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                int selectedRow = datauser.CurrentCell.RowIndex;
                int deleteId = Convert.ToInt32(datauser.Rows[selectedRow].Cells["id"].Value);

                MySqlConnection conn = databaseConnection();

                String sql = "DELETE FROM duser WHERE id = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                }
                this.Hide();
                aduser f = new aduser();
                f.ShowDialog();
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void datauser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard f = new dashboard();
            f.ShowDialog();
        }
        //ปุ่ม การแก้ไขข้อมูล
        private void aeditbtn_Click(object sender, EventArgs e)
        {
            int selectedRow = datauser.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(datauser.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();

            String sql = "UPDATE duser SET Name = '" + rnamebox.Text + "',Surname = '" + rsurbox.Text + "',Phone = '" + rtelbox.Text + "',IDCard = '" + rcardbox.Text + "',Address = '" + raddressbox.Text + "',User = '" + ruserbox.Text + "',Password = '" + rpasswordbox.Text + "'WHERE id = '" + editId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
            }
            this.Hide();
            aduser f = new aduser();
            f.ShowDialog();
        }

        private void rebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            @return f = new @return();
            f.ShowDialog();
        }
    }
}
