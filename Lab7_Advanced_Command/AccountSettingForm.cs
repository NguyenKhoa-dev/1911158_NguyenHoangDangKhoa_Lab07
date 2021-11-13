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

namespace Lab7_Advanced_Command
{
    public partial class AccountSettingForm : Form
    {
        private string _AccountName;
        public AccountSettingForm(string AccountName)
        {
            _AccountName = AccountName;
            InitializeComponent();
        }

        private void LoadCombobox()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT RoleName FROM Role";
            cmd.CommandText = query;

            sqlConnection.Open();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            cbbRole.Items.Clear();
            while (sqlDataReader.Read())
            {
                cbbRole.Items.Add(sqlDataReader["RoleName"].ToString());
            }

            sqlConnection.Close();
        }

        private void InsertAccount()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Account_Insert @AccountName, @Password, @FullName, @Email, @Tell, @Date";
            cmd.CommandText = query;

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Tell", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Date", SqlDbType.DateTime);

            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Password"].Value = txtPassword.Text;
            cmd.Parameters["@FullName"].Value = txtHoTen.Text;
            cmd.Parameters["@Email"].Value = txtEmail.Text;
            cmd.Parameters["@Tell"].Value = txtSDT.Text;
            cmd.Parameters["@Date"].Value = DateTime.Now.ToShortDateString();

            sqlConnection.Open();
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected > 0)
                MessageBox.Show("Đã tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng tạo lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InsertRoleAccount();
        }

        private void UpdateAccount()
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
            cmd.Parameters["@Password"].Value = txtPassword.Text;
            cmd.Parameters["@FullName"].Value = txtHoTen.Text;
            cmd.Parameters["@Email"].Value = txtEmail.Text;
            cmd.Parameters["@Tell"].Value = txtSDT.Text;

            sqlConnection.Open();
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
                MessageBox.Show("Đã cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vui lòng cập nhật lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InsertRoleAccount()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC RoleAccount_Insert @RoleID, @AccountName, @Actived, @Notes";
            cmd.CommandText = query;

            cmd.Parameters.Add("@RoleID", SqlDbType.Int);
            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Actived", SqlDbType.Int);
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar);

            cmd.Parameters["@RoleID"].Value = (cbbRole.SelectedIndex + 1);
            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Actived"].Value = 1;
            cmd.Parameters["@Notes"].Value = "";

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void ShowAccount(SqlDataReader reader)
        {
            while (reader.Read())
            {
                txtAccountName.Text = reader["AccountName"].ToString();
                txtPassword.Text = reader["Password"].ToString();
                txtConfirmPassword.Text = reader["Password"].ToString();
                txtHoTen.Text = reader["FullName"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtSDT.Text = reader["Tell"].ToString();
                cbbRole.Text = reader["RoleName"].ToString();
            }
        }

        private void AccountSettingForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            if (_AccountName != null)
            {
                txtAccountName.Enabled = false;
                cbbRole.Enabled = false;
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;

                string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand cmd = sqlConnection.CreateCommand();
                string query = "SELECT A.AccountName, Password, FullName, Email, Tell, RoleName "
                         + "FROM Account A, [Role] B, RoleAccount C "
                         + "WHERE A.AccountName = C.AccountName AND B.ID = C.RoleID AND A.AccountName = @AccountName";
                cmd.CommandText = query;

                cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
                cmd.Parameters["@AccountName"].Value = _AccountName;

                sqlConnection.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                ShowAccount(sqlDataReader);
                sqlConnection.Close();
            }
            else
            {
                txtPassword.Text = "1";
                txtConfirmPassword.Text = "1";
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                cbbRole.Enabled = true;
                txtAccountName.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_AccountName == null)
            {
                if (string.IsNullOrWhiteSpace(txtAccountName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)
                    || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(cbbRole.Text))
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin của tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (txtPassword.Text.CompareTo(txtConfirmPassword.Text) == 0)
                    {
                        InsertAccount();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Mật khẩu không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin của tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (txtPassword.Text.CompareTo(txtConfirmPassword.Text) == 0)
                    {
                        UpdateAccount();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Mật khẩu không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
