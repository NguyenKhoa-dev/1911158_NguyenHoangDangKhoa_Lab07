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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void DisplayTable(SqlDataReader reader)
        {
            lvTable.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add((reader["Status"].ToString() == "0") ? "Còn trống" : "Có khách");
                item.SubItems.Add(reader["Capacity"].ToString());
                lvTable.Items.Add(item);
            }
        }

        private void LoadListView()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT * FROM [Table] Order by Name";
            cmd.CommandText = query;

            sqlConnection.Open();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DisplayTable(sqlDataReader);
            sqlConnection.Close();
        }

        private void ShowTable(ListViewItem item)
        {
            txtTableID.Text = item.SubItems[0].Text;
            txtTableName.Text = item.SubItems[1].Text;
            txtTableStatus.Text = (item.SubItems[2].Text) == "Còn trống" ? "0" : "1";
            txtTableCapacity.Text = item.SubItems[3].Text;
        }

        private void InsertTable()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Table_Insert @ID OUTPUT, @Name, @Capacity";
            cmd.CommandText = query;

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Capacity", SqlDbType.Int);

            cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
            cmd.Parameters["@Name"].Value = txtTableName.Text;
            cmd.Parameters["@Capacity"].Value = Convert.ToInt32(txtTableCapacity.Text);

            sqlConnection.Open();
            int numOfRowEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowEffected == 1)
                MessageBox.Show("Đã thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm bàn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UpdateTable()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Table_Update @ID, @Name, @Status, @Capacity";
            cmd.CommandText = query;

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Status", SqlDbType.Int);
            cmd.Parameters.Add("@Capacity", SqlDbType.Int);

            cmd.Parameters["@ID"].Value = Convert.ToInt32(txtTableID.Text);
            cmd.Parameters["@Name"].Value = txtTableName.Text;
            cmd.Parameters["@Status"].Value = Convert.ToInt32(txtTableStatus.Text);
            cmd.Parameters["@Capacity"].Value = Convert.ToInt32(txtTableCapacity.Text);

            sqlConnection.Open();
            int numOfRowEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowEffected == 1)
                MessageBox.Show("Cập nhật bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cập nhật bàn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DeleteTable(string tableID)
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Table_Delete @ID";
            cmd.CommandText = query;

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = Convert.ToInt32(txtTableID.Text);

            sqlConnection.Open();
            int numOfRowEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowEffected == 1)
                MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa bàn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertTable();
            LoadListView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateTable();
            LoadListView();
        }

        private void DeleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvTable.SelectedItems.Count;

            if (count > 0)
            {
                DeleteTable(lvTable.SelectedItems[0].SubItems[0].Text);
                LoadListView();
            }
        }

        private void ViewSumaryBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TableName = lvTable.SelectedItems[0].SubItems[1].Text;
            SumaryBillsForm frm = new SumaryBillsForm(lvTable.SelectedItems[0].SubItems[0].Text);
            frm.Text = "Xem nhật ký hóa đơn bàn " + TableName;
            frm.ShowDialog();
        }

        private void lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvTable.SelectedItems.Count;

            if (count > 0)
            {
                ListViewItem item = lvTable.SelectedItems[0];
                ShowTable(item);
            }
        }
    }
}
