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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        private void SetTitle()
        {
            dgvBillDetails.Columns["ID"].HeaderText = "Mã số";
            dgvBillDetails.Columns["Name"].HeaderText = "Tên món ăn";
            dgvBillDetails.Columns["Quantity"].HeaderText = "Số lượng";
            dgvBillDetails.Columns["Price"].HeaderText = "Đơn giá";
            dgvBillDetails.Columns["Summary"].HeaderText = "Thành tiền";
        }

        public void LoadBillDetails(string BillID)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT A.ID, B.Name, Quantity, B.Price, B.Price * Quantity as Summary FROM BillDetails A, Food B WHERE A.FoodID = B.ID AND A.InvoiceID = @BillID";

            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters["@BillID"].Value = Convert.ToInt32(BillID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable BillDetailsTable = new DataTable();

            conn.Open();
            adapter.Fill(BillDetailsTable);
            conn.Close();
            conn.Dispose();

            dgvBillDetails.DataSource = BillDetailsTable;
            SetTitle();
        }
    }
}
