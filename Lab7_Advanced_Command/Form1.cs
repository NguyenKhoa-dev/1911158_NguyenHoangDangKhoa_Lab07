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
    public partial class Form1 : Form
    {
        private DataTable foodTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCategory()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        private void SetDGVFoodTitle()
        {
            dgvFoodList.Columns["ID"].HeaderText = "Mã số";
            dgvFoodList.Columns["Name"].HeaderText = "Tên món ăn";
            dgvFoodList.Columns["Unit"].HeaderText = "Đơn vị tính";
            dgvFoodList.Columns["FoodCategoryID"].HeaderText = "Loại";
            dgvFoodList.Columns["Price"].HeaderText = "Đơn giá";
            dgvFoodList.Columns["Notes"].HeaderText = "Ghi chú";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;

            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

            cmd.Parameters.Add("@categoryId", SqlDbType.Int);

            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable();

            conn.Open();
            adapter.Fill(foodTable);
            conn.Close();
            conn.Dispose();

            dgvFoodList.DataSource = foodTable;
            SetDGVFoodTitle();        
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSaleFood = SUM(Quantity) FROM BillDetails WHERE FoodID = @foodId";

            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];

                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                if (string.IsNullOrWhiteSpace(result))
                    result = "0";
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodForm = new FoodInfoForm();
            foodForm.FormClosed += FoodForm_FormClosed;
            foodForm.Show(this);
        }

        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCategory();
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += FoodForm_FormClosed;

                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = "Name like '%" + txtSearch.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);
            dgvFoodList.DataSource = foodView;
        }

        private void OrdersFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm frm = new OrdersForm();
            frm.ShowDialog();
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm frm = new AccountForm();
            frm.ShowDialog();
        }

        private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm frm = new TableForm();
            frm.ShowDialog();
        }
    }
}
