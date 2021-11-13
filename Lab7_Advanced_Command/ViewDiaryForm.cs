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
    public partial class ViewDiaryForm : Form
    {
        string _AccountName;
        public ViewDiaryForm(string AccountName)
        {
            InitializeComponent();
            _AccountName = AccountName;
        }

        private void LoadListBox()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT CONVERT(VARCHAR(10), CheckoutDate, 111) as ConvertDate FROM Bills WHERE Account = @AccountName GROUP BY CONVERT(VARCHAR(10), CheckoutDate, 111)";
            cmd.CommandText = query;

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters["@AccountName"].Value = _AccountName;

            sqlConnection.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            lbxDate.Items.Clear();
            while (sqlDataReader.Read())
            {
                lbxDate.Items.Add(DateTime.Parse(sqlDataReader["ConvertDate"].ToString()).ToString("dd/MM/yyyy"));
            }
            sqlConnection.Close();
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

        private void LoadListView(SqlDataReader reader)
        {
            lvBillsOfTable.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Quantity"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                item.SubItems.Add(reader["Amount"].ToString());
                lvBillsOfTable.Items.Add(item);
            }
        }

        private void SummaryBills()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT @CountBills = COUNT(ID), @SumAmount = SUM(Amount) FROM Bills WHERE Account = @AccountName";
            cmd.CommandText = query;

            cmd.Parameters.Add("@CountBills", SqlDbType.Int);
            cmd.Parameters.Add("@SumAmount", SqlDbType.Int);
            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);

            cmd.Parameters["@CountBills"].Direction = ParameterDirection.Output;
            cmd.Parameters["@SumAmount"].Direction = ParameterDirection.Output;
            cmd.Parameters["@AccountName"].Value = _AccountName;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            string count = cmd.Parameters["@CountBills"].Value.ToString();
            string sum = cmd.Parameters["@SumAmount"].Value.ToString();
            tstrSummary.Text = string.Format("Số lượng hóa đơn: {0}, Tổng tiền các hóa đơn: {1}VND", count, sum);
            sqlConnection.Close();
        }

        private void ViewDiaryForm_Load(object sender, EventArgs e)
        {
            LoadAccountInfo();
            LoadListBox();
        }

        private void lbxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string date = DateTime.Parse(lbxDate.SelectedItem.ToString()).ToString("yyyy/MM/dd");

            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT A.ID, C.Name, Quantity, Price, Price * Quantity as Amount "
                            + "FROM Bills A, BillDetails B, Food C "
                            + "WHERE A.ID = B.InvoiceID AND B.FoodID = C.ID AND CONVERT(VARCHAR(10), CheckoutDate, 111) = @Date AND Account = @AccountName";
            cmd.CommandText = query;

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Date", SqlDbType.SmallDateTime);

            cmd.Parameters["@AccountName"].Value = _AccountName;
            cmd.Parameters["@Date"].Value = DateTime.Parse(date);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            LoadListView(sqlDataReader);
            sqlConnection.Close();
            SummaryBills();
        }
    }
}
