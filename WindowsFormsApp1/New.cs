using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class New : UserControl
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public New()
        {
            InitializeComponent();
            builder.DataSource = "conceptserv.database.windows.net";
            builder.UserID = "sysadm";
            builder.Password = "Password42";
            builder.InitialCatalog = "conceptDB";
        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO BINS(Sales_Order, Size, Estimated_Hours, Actual_Hours, Promise_Date) VALUES(@param1,@param2,@param3,@param4,@param5)";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = txtSalesOrder.Text;
                        cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = txtBinSize.Text;
                        cmd.Parameters.Add("@param3", SqlDbType.Int).Value = 55;
                        cmd.Parameters.Add("@param4", SqlDbType.Int).Value = 55;
                        cmd.Parameters.Add("@param5", SqlDbType.DateTime).Value = Convert.ToDateTime(txtPromiseDate.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }

                    CheckBox[] checkBoxes = { ckB3VG, ckB4SIA, ckBAH2410, ckBAR7000, ckBAR8000, ckBFMB, ckBGN, ckBIP, ckBLA, ckBPH };

                    foreach (CheckBox box in checkBoxes)
                    {
                        if (box.Checked)
                        {
                            string optionsql = "INSERT INTO BIN_OPTIONS(Bin_Id, Option_Name) VALUES(@param1,@param2)";
                            using (SqlCommand cmd = new SqlCommand(optionsql, connection))
                            {
                                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = 2; //TODO(Elvis): Change to Bin ID
                                cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = box.Name;
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Bin Added Successfully");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
