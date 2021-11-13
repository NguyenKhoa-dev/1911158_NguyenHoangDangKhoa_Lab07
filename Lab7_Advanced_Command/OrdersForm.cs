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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void SetTitles()
        {
            dgvBills.Columns["ID"].HeaderText = "Mã số";
            dgvBills.Columns["Name"].HeaderText = "Tên món ăn";
            dgvBills.Columns["TableID"].HeaderText = "Mã bàn";
            dgvBills.Columns["Amount"].HeaderText = "Tổng tiền";
            dgvBills.Columns["Discount"].HeaderText = "Chiết khấu";
            dgvBills.Columns["Tax"].HeaderText = "Thuế";
            dgvBills.Columns["Status"].HeaderText = "Trạng thái";
            dgvBills.Columns["CheckoutDate"].HeaderText = "Ngày thanh toán";
            dgvBills.Columns["Account"].HeaderText = "Người lập";
        }

        private void LoadBills()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Bills WHERE CheckoutDate = @checkoutDate";

            cmd.Parameters.Add("@checkoutDate", SqlDbType.SmallDateTime);
            cmd.Parameters["@checkoutDate"].Value = DateTime.Parse(dtpDate.Value.ToString("dd/MM/yyyy"));      

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable BillsTable = new DataTable();

            conn.Open();
            adapter.Fill(BillsTable);
            conn.Close();
            conn.Dispose();

            dgvBills.DataSource = BillsTable;
            SetTitles();
        }

        private void CalAmountSummary()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSummary = SUM(Amount) FROM Bills WHERE CheckoutDate = @checkoutDate";

            cmd.Parameters.Add("@numSummary", SqlDbType.Int);
            cmd.Parameters["@numSummary"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@checkoutDate", SqlDbType.SmallDateTime);
            cmd.Parameters["@checkoutDate"].Value = DateTime.Parse(dtpDate.Value.ToString("dd/MM/yyyy"));


            conn.Open();
            cmd.ExecuteNonQuery();
            string summary = cmd.Parameters["@numSummary"].Value.ToString();
            if (string.IsNullOrWhiteSpace(summary))
                summary = "0";
            tsrSummary.Text = "Tổng doanh thu trong ngày là: " + summary + "VNĐ";
            conn.Close();
            conn.Dispose();                      
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadBills();
            CalAmountSummary();
        }

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            int count = dgvBills.SelectedRows.Count;
            if (count > 0)
            {
                DataGridViewRow row = dgvBills.SelectedRows[0];
                string BillID = row.Cells[0].Value.ToString();
                if (!string.IsNullOrWhiteSpace(BillID))
                {
                    OrderDetailsForm frm = new OrderDetailsForm();
                    frm.LoadBillDetails(BillID);
                    frm.ShowDialog();
                }                
            }
        }
    }
}
