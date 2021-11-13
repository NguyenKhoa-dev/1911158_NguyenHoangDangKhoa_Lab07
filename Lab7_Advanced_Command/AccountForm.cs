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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void LoadListView()
        {
            string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT AccountName, FullName, Email, Tell FROM Account";

            conn.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            lvAccount.Items.Clear();
            while (sqlReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlReader["AccountName"].ToString());
                item.SubItems.Add(sqlReader["FullName"].ToString());
                item.SubItems.Add(sqlReader["Email"].ToString());
                item.SubItems.Add(sqlReader["Tell"].ToString());
                lvAccount.Items.Add(item);
            }
            conn.Close();
            conn.Dispose();                  
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadListView();                
        }

        private void AddAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettingForm frm = new AccountSettingForm(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadListView();
            }
        }

        private void lvAccount_DoubleClick(object sender, EventArgs e)
        {
            int count = lvAccount.SelectedItems.Count;
            if (count > 0)
            {
                AccountSettingForm frm = new AccountSettingForm(lvAccount.SelectedItems[0].SubItems[0].Text);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadListView();
                }
            }
        }

        private void ViewRoleNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvAccount.SelectedItems.Count;
            if (count > 0)
            {
                ViewRoleForm frm = new ViewRoleForm(lvAccount.SelectedItems[0].SubItems[0].Text);
                frm.ShowDialog();
            }           
        }

        private void ViewDiaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvAccount.SelectedItems.Count;
            if (count > 0)
            {
                ViewDiaryForm frm = new ViewDiaryForm(lvAccount.SelectedItems[0].SubItems[0].Text);
                frm.ShowDialog();
            }
        }
    }
}
