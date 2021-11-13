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
    public partial class MainForm : Form
    {
        private string _AccountName;
        private string _TableID = null;
        private Button btnTemp;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ResetButtonColor(Button btn)
        {
            btnTemp.BackColor = SystemColors.ButtonFace;
            btnTemp.UseVisualStyleBackColor = true;
        }

        private void CheckRoleAdmin()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT RoleID FROM Account A, RoleAccount B WHERE A.AccountName = B.AccountName AND A.AccountName = @AccountName AND RoleID = 1";

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);

            cmd.Parameters["@AccountName"].Value = _AccountName;

            conn.Open();
            var roleID = cmd.ExecuteScalar();
            if (roleID == null)
                AdminToolStripMenuItem.Enabled = false;
            else
                AdminToolStripMenuItem.Enabled = true;
            conn.Close();
            conn.Dispose();
        }

        private void LoadTable(SqlDataReader reader)
        {
            fpnlTable.Controls.Clear();
            string status, capacity;
            while (reader.Read())
            {
                Button btn = new Button();
                btn.Width = 90;
                btn.Height = 60;
                btn.Tag = reader["ID"].ToString();
                status = (reader["Status"].ToString() == "0") ? "Còn trống" : "Có khách";
                capacity = reader["Capacity"].ToString() + "Chỗ";
                if (status == "Có khách") { btn.BackColor = Color.Aquamarine; }
                btn.Text = "Bàn " + reader["Name"].ToString() + "\n" + status;
                TableCapacityToolTip.SetToolTip(btn, capacity);
                btn.Click += Btn_Click;
                fpnlTable.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;   
            if (btn.BackColor != Color.Aquamarine)         
                btn.BackColor = Color.Orange;
            if (btnTemp != null)
            {
                if (btnTemp.BackColor != Color.Aquamarine)
                    ResetButtonColor(btnTemp);
            }     
            _TableID = btn.Tag.ToString();
            btnTemp = btn;
            string BillID = CheckExistBill();
            if (BillID != null)
            {                
                LoadListView(BillID);                                  
            }
            else
            {
                lvFoodTable.Items.Clear();
                txtAmount.Text = "0";
            }                
        }

        private void LoadTable()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [Table]";

            conn.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            LoadTable(sqlReader);
            conn.Close();
            conn.Dispose();

            _TableID = null;
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

        private void InsertBillDetail(string BillID)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC BillDetails_Insert @ID OUTPUT, @BillID, @FoodID, @Quantity";

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters.Add("@FoodID", SqlDbType.Int);
            cmd.Parameters.Add("@Quantity", SqlDbType.Int);

            cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
            cmd.Parameters["@BillID"].Value = BillID;

            if (cbbFood.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@FoodID"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@FoodID"].Value = cbbFood.SelectedValue;
            }

            cmd.Parameters["@Quantity"].Value = nmrQuantity.Value;

            conn.Open();
            int numRowAffected = cmd.ExecuteNonQuery();
            if (numRowAffected == 1)
                LoadListView(BillID);
            else
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            conn.Dispose();
        }

        private void ShowListView(SqlDataReader sqlDataReader)
        {
            lvFoodTable.Items.Clear();
            while (sqlDataReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlDataReader["Name"].ToString());
                item.SubItems.Add(sqlDataReader["Quantity"].ToString());
                item.SubItems.Add(sqlDataReader["Price"].ToString());
                item.SubItems.Add(sqlDataReader["Summary"].ToString());
                lvFoodTable.Items.Add(item);
            }
        }

        private void LoadListView(string BillID)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT B.Name, Quantity, B.Price, B.Price * Quantity as Summary FROM BillDetails A, Food B WHERE A.FoodID = B.ID AND A.InvoiceID = @BillID";

            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters["@BillID"].Value = BillID;
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            ShowListView(sqlDataReader);
            conn.Close();
            conn.Dispose();

            CalSummary();
        }

        private string CheckExistBill()
        {
            string kq = null;
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID FROM Bills WHERE TableID = @TableID AND Status = @Status";

            cmd.Parameters.Add("@TableID", SqlDbType.Int);
            cmd.Parameters.Add("@Status", SqlDbType.Bit);

            cmd.Parameters["@TableID"].Value = _TableID;
            cmd.Parameters["@Status"].Value = 0;

            conn.Open();
            var BillID = cmd.ExecuteScalar();
            if (BillID != null)
                kq = BillID.ToString();
            conn.Close();
            conn.Dispose();
            return kq;
        }

        private void CreateBill()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC Bills_Insert @ID OUTPUT, @Name, @TableID, @Amount, @Discount, @Tax, @Status, @CheckoutDate, @AccountName";

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            cmd.Parameters.Add("@TableID", SqlDbType.Int);
            cmd.Parameters.Add("@Amount", SqlDbType.Int);
            cmd.Parameters.Add("@Discount", SqlDbType.Float);
            cmd.Parameters.Add("@Tax", SqlDbType.Float);
            cmd.Parameters.Add("@Status", SqlDbType.Bit);
            cmd.Parameters.Add("@CheckoutDate", SqlDbType.SmallDateTime);        
            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);

            cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
            cmd.Parameters["@Name"].Value = "Hóa đơn thanh toán";
            cmd.Parameters["@TableID"].Value = _TableID;
            cmd.Parameters["@Amount"].Value = 0;
            cmd.Parameters["@Discount"].Value = txtDiscount.Text;
            cmd.Parameters["@Tax"].Value = txtTax.Text;
            cmd.Parameters["@Status"].Value = 0;
            cmd.Parameters["@CheckoutDate"].Value = DateTime.Now;
            cmd.Parameters["@AccountName"].Value = _AccountName;

            conn.Open();
            int numRowAffected = cmd.ExecuteNonQuery();
            if (numRowAffected == 2)
            {
                string BillID = cmd.Parameters["@ID"].Value.ToString();
                InsertBillDetail(BillID);
            }                
            else
                MessageBox.Show("Lỗi tạo hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            conn.Dispose();
        }

        private void UpdateBillAmount(string BillID)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC Bills_Update_Amount @ID, @TableID, @Amount";

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@TableID", SqlDbType.Int);
            cmd.Parameters.Add("@Amount", SqlDbType.Int);

            cmd.Parameters["@ID"].Value = BillID;
            cmd.Parameters["@TableID"].Value = _TableID;
            cmd.Parameters["@Amount"].Value = txtAmount.Text;

            conn.Open();
            int numRowAffected = cmd.ExecuteNonQuery();
            if (numRowAffected == 2)
                MessageBox.Show("Đã thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lỗi thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            conn.Dispose();
        }

        private void CalSummary()
        {
            long sum = 0;
            foreach (ListViewItem item in lvFoodTable.Items)
            {
                sum += Convert.ToInt64(item.SubItems[3].Text); 
            }
            txtAmount.Text = sum.ToString();
        }

        private string FindFoodID(string FoodName)
        {
            string kq = null;
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID FROM Food WHERE Name = @Name";

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            cmd.Parameters["@Name"].Value = FoodName;

            conn.Open();
            var FoodID = cmd.ExecuteScalar();
            if (FoodID != null)
                kq = FoodID.ToString();            
            conn.Close();
            conn.Dispose();
            return kq;
        }

        private void DeleteBillDetails(string BillID, string FoodID)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM BillDetails WHERE InvoiceID = @BillID AND FoodID = @FoodID";

            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters.Add("@FoodID", SqlDbType.Int);

            cmd.Parameters["@BillID"].Value = BillID;
            cmd.Parameters["@FoodID"].Value = FoodID;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        private void DeleteBill(string BillID)
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC Delete_Bills @BillID, @TableID";

            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters.Add("@TableID", SqlDbType.Int);

            cmd.Parameters["@BillID"].Value = BillID;
            cmd.Parameters["@TableID"].Value = _TableID;

            conn.Open();
            int numRowAffected = cmd.ExecuteNonQuery();
            if (numRowAffected != 2)
                MessageBox.Show("Lỗi khi xóa hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            conn.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK)
                Application.Exit();
            _AccountName = frm.txtAccountName.Text;
            CheckRoleAdmin();
            LoadTable();
            LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;

            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Food WHERE FoodCategoryID = @categoryId";

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
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbFood.DataSource = dt;
            cbbFood.DisplayMember = "Name";
            cbbFood.ValueMember = "ID";
        }

        private void AccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfoForm frm = new AccountInfoForm(_AccountName);
            frm.ShowDialog();
        }

        private void btnAddFoodBill_Click(object sender, EventArgs e)
        {
            if (_TableID == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món ăn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string BillID = CheckExistBill();
            if (BillID == null)
            {
                CreateBill();
                LoadTable();
                nmrQuantity.Value = 1;      
            }
            else
            {
                InsertBillDetail(BillID);
                nmrQuantity.Value = 1;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string BillID = CheckExistBill();
            if (BillID == null)
            {
                MessageBox.Show("Không thể thanh toán khi không có hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UpdateBillAmount(BillID);
                    LoadTable();
                    lvFoodTable.Items.Clear();
                    txtAmount.Text = "0";
                }
                else
                    return;
            }
        }

        private void FoodCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvFoodTable.SelectedItems.Count;

            if (count > 0)
            {
                string BillID = CheckExistBill();
                string FoodID;

                if (count == lvFoodTable.Items.Count)
                {
                    foreach (ListViewItem item in lvFoodTable.SelectedItems)
                    {
                        FoodID = FindFoodID(item.SubItems[0].Text);
                        DeleteBillDetails(BillID, FoodID);
                    }
                    DeleteBill(BillID);
                    LoadTable();
                    lvFoodTable.Items.Clear();
                    txtAmount.Text = "0";
                }
                else
                {
                    foreach (ListViewItem item in lvFoodTable.SelectedItems)
                    {
                        FoodID = FindFoodID(item.SubItems[0].Text);
                        DeleteBillDetails(BillID, FoodID);
                        LoadListView(BillID);

                        if (lvFoodTable.Items.Count == 0)
                        {
                            DeleteBill(BillID);
                            LoadTable();
                        }
                    }
                }                
            }
        }
    }
}
