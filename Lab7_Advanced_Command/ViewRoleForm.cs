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
    public partial class ViewRoleForm : Form
    {
        private string _AccountName;
        public ViewRoleForm(string AccountName)
        {
            _AccountName = AccountName;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadListRole()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Role";

            conn.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            lvRole.Items.Clear();
            while (sqlReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlReader["ID"].ToString());
                item.SubItems.Add(sqlReader["RoleName"].ToString());
                item.SubItems.Add(sqlReader["Path"].ToString());
                item.SubItems.Add(sqlReader["Notes"].ToString());
                lvRole.Items.Add(item);
            }
            conn.Close();
            conn.Dispose();
        }

        private void LoadAccountInfo()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT AccountName, FullName FROM Account WHERE AccountName = @AccountName";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters["@AccountName"].Value = _AccountName;

            conn.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                txtAccountName.Text = sqlReader["AccountName"].ToString();
                txtFullName.Text = sqlReader["FullName"].ToString();
            }
            conn.Close();
            conn.Dispose();
        }

        private void CheckRoleAccount()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT RoleName FROM Role A, RoleAccount B WHERE A.ID = B.RoleID AND AccountName = @AccountName";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters["@AccountName"].Value = _AccountName;

            conn.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                ListViewItem item = lvRole.FindItemWithText(sqlReader["RoleName"].ToString());
                item.Checked = true;
            }
            conn.Close();
            conn.Dispose();
        }

        private void ViewRoleForm_Load(object sender, EventArgs e)
        {
            LoadListRole();
            LoadAccountInfo();
            CheckRoleAccount();
        }

        private void ShowRoleInfo(ListViewItem item)
        {
            txtRoleID.Text = item.SubItems[0].Text;
            txtRoleName.Text = item.SubItems[1].Text;
            txtRolePath.Text = item.SubItems[2].Text;
            rtxtNotes.Text = item.SubItems[3].Text;
        }

        private void DeleteRoleAccount()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM RoleAccount WHERE AccountName = @AccountName";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);

            cmd.Parameters["@AccountName"].Value = _AccountName;

            conn.Open();
            cmd.ExecuteNonQuery();            
            conn.Close();
            conn.Dispose();
        }

        private void InsertRoleAccount(int RoleID)
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

            cmd.Parameters["@RoleID"].Value = RoleID;
            cmd.Parameters["@AccountName"].Value = _AccountName;
            cmd.Parameters["@Actived"].Value = 1;
            cmd.Parameters["@Notes"].Value = "";

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void lvRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvRole.SelectedItems.Count;

            if (count > 0)
            {
                ListViewItem item = lvRole.SelectedItems[0];
                ShowRoleInfo(item);
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
                MessageBox.Show("Tên vai trò không được bỏ trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC Role_Update @RoleID, @RoleName, @Path, @Notes";

                cmd.Parameters.Add("@RoleID", SqlDbType.Int);
                cmd.Parameters.Add("@RoleName", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Path", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar);

                cmd.Parameters["@RoleID"].Value = Convert.ToInt32(txtRoleID.Text);
                cmd.Parameters["@RoleName"].Value = txtRoleName.Text;
                cmd.Parameters["@Path"].Value = txtRolePath.Text;
                cmd.Parameters["@Notes"].Value = rtxtNotes.Text;

                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected == 1)
                    MessageBox.Show("Cập nhật vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật vai trò không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
                conn.Dispose();

                LoadListRole();
                CheckRoleAccount();
            }            
        }

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
                MessageBox.Show("Tên vai trò không được bỏ trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC Role_Insert @RoleID, @RoleName, @Path, @Notes";

                cmd.Parameters.Add("@RoleID", SqlDbType.Int);
                cmd.Parameters.Add("@RoleName", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Path", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar);

                cmd.Parameters["@RoleID"].Direction = ParameterDirection.Output;
                cmd.Parameters["@RoleName"].Value = txtRoleName.Text;
                cmd.Parameters["@Path"].Value = txtRolePath.Text;
                cmd.Parameters["@Notes"].Value = rtxtNotes.Text;

                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected == 1)
                    MessageBox.Show("Thêm vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm vai trò không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
                conn.Dispose();

                LoadListRole();
                CheckRoleAccount();
            }
        }

        private void UpdateRoleAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvRole.CheckedItems.Count;
            if (count > 0)
            {
                DeleteRoleAccount();
                foreach (ListViewItem item in lvRole.CheckedItems)
                {
                    InsertRoleAccount(Convert.ToInt32(item.SubItems[0].Text));
                }
                MessageBox.Show("Đã cập nhật vai trò cho tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                  
        }

        private void ReloadViewRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListRole();
            CheckRoleAccount();
        }
    }
}
