using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Restaurant_Bonus
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtAccountName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Tên hoặc mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT AccountName FROM Account WHERE AccountName = @AccountName AND Password = @Password";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar);

            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Password"].Value = txtPassword.Text;

            conn.Open();
            var accountName = cmd.ExecuteScalar();
            if (accountName == null)
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                this.DialogResult = DialogResult.OK;
            conn.Close();
            conn.Dispose();
        }
    }
}
