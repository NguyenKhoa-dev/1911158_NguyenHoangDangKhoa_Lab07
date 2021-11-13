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
    public partial class AccountInfoForm : Form
    {
        private string _AccountName;
        public AccountInfoForm(string AccountName)
        {
            InitializeComponent();
            _AccountName = AccountName;
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            txtAccountName.Text = _AccountName;
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT FullName, Email, Tell FROM Account WHERE AccountName = @AccountName";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters["@AccountName"].Value = _AccountName;

            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();            
            while (sqlDataReader.Read())
            {
                txtFullName.Text = sqlDataReader["FullName"].ToString();
                txtEmail.Text = sqlDataReader["Email"].ToString();
                txtTell.Text = sqlDataReader["Tell"].ToString();
            }
            conn.Close();
            conn.Dispose();

            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
        }

        private void rdoChangeInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChangeInfo.Checked)
            {
                txtNewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
            else
            {
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }               
        }

        private bool CheckPassword()
        {
            bool kq = true;
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT AccountName FROM Account WHERE AccountName = @AccountName AND Password = @Password";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters["@AccountName"].Value = _AccountName;

            cmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            cmd.Parameters["@Password"].Value = txtPassword.Text;

            conn.Open();
            var accountName = cmd.ExecuteScalar();
            if (accountName == null)
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kq = false;
            }
            conn.Close();
            conn.Dispose();
            return kq;
        }

        private void UpdateAccount(string password)
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Account_Update @AccountName, @Password, @FullName, @Email, @Tell";
            cmd.CommandText = query;

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Tell", SqlDbType.NVarChar);

            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Password"].Value = password;
            cmd.Parameters["@FullName"].Value = txtFullName.Text;
            cmd.Parameters["@Email"].Value = txtEmail.Text;
            cmd.Parameters["@Tell"].Value = txtTell.Text;

            sqlConnection.Open();
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
                MessageBox.Show("Đã cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng cập nhật lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Họ tên hoặc mật khẩu không được để trống!", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdoChangeInfo.Checked)
            {
                if (CheckPassword())
                {
                    UpdateAccount(txtPassword.Text);
                    this.Close();
                }
            }
            else if (rdoChangePassword.Checked)
            {               
                if (CheckPassword())
                {
                    if (txtNewPassword.Text.Equals(txtConfirmPassword.Text) && (!string.IsNullOrWhiteSpace(txtNewPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirmPassword.Text)))
                    {
                        UpdateAccount(txtNewPassword.Text);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Mật khẩu mới và xác nhận không trùng nhau hoặc không được bỏ trống, yêu cầu nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
