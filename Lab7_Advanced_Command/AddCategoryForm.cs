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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=DESKTOP-RN0HE9G\\SQLEXPRESS; database=RestaurantManagement; Integrated Security=true";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC Category_Insert @id, @name, @type";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@type", SqlDbType.Int);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd.Parameters["@name"].Value = txtNameCat.Text;
                if (rdTypeFood.Checked)
                    cmd.Parameters["@type"].Value = "1";
                else
                    cmd.Parameters["@type"].Value = "0";

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Thêm nhóm món ăn thành công!", "Thông báo");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm nhóm món ăn thất bại!", "Thông báo");
                }
                conn.Close();
                conn.Dispose();
                this.DialogResult = DialogResult.OK;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }


    }
}
