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
    public partial class SumaryBillsForm : Form
    {
        private string _tableID;
        public SumaryBillsForm(string TableID)
        {
            _tableID = TableID;
            InitializeComponent();
        }

        private void LoadComboBox()
        {
            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT AccountName FROM Account";
            sqlCommand.CommandText = query;

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbbAccount.Items.Add(sqlDataReader["AccountName"].ToString());
            }
            sqlConnection.Close();
            cbbAccount.SelectedIndex = 0;
        }

        private void LoadListView()
        {
            lvSumary.Items.Clear();

            string connectionString = "server = DESKTOP-RN0HE9G\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT COUNT(ID) as NumOfBills, SUM(Amount) as SumAmount, SUM(Discount) as SumDiscount, SUM(Tax) as SumTax "
                            + "FROM Bills "
                            + "WHERE CheckoutDate = @Date AND Account = @Account AND TableID = @TableID";
            cmd.CommandText = query;

            cmd.Parameters.Add("@Date", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@Account", SqlDbType.NVarChar);
            cmd.Parameters.Add("@TableID", SqlDbType.Int);

            cmd.Parameters["@Date"].Value = DateTime.Parse(dtpDate.Value.ToShortDateString());
            cmd.Parameters["@Account"].Value = cbbAccount.Text;
            cmd.Parameters["@TableID"].Value = Convert.ToInt32(_tableID);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlDataReader["NumOfBills"].ToString());
                item.SubItems.Add(sqlDataReader["SumAmount"].ToString());
                item.SubItems.Add(sqlDataReader["SumDiscount"].ToString());
                item.SubItems.Add(sqlDataReader["SumTax"].ToString());
                lvSumary.Items.Add(item);
            }
            sqlConnection.Close();
        }

        private void SumaryBillsForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dtpDate.Value = DateTime.Now;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void cbbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView();
        }
    }
}
