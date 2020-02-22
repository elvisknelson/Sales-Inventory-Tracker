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

namespace WindowsFormsApp1
{
    public partial class Shipping : Form
    {
        public Shipping()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGetBin_Click(object sender, EventArgs e)
        {
            int salesOrder = -1;

            if (Utility.IsValid(txtBinSalesId.Text))
            {
                salesOrder = Convert.ToByte(txtBinSalesId.Text);

                List<object> binInfo = new List<object>();

                DataService dataService = new DataService();
                binInfo = dataService.GetData("SELECT * FROM BINS");

                if (binInfo[0] != null)
                {
                    lblSalesOrderDate.Text = binInfo[4].ToString();
                    lblSalesOrder.Text = binInfo[5].ToString();
                    lblSalesPromise.Text = binInfo[6].ToString();
                    lblSalesPerson.Text = binInfo[7].ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a Valid Sales Order", "Invalid Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Valid Sales Order", "Invalid Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "conceptserv.database.windows.net";
                builder.UserID = "sysadm";
                builder.Password = "Password42";
                builder.InitialCatalog = "conceptDB";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO BINS(orderDate,salesOrder,promiseDate,salesPerson) VALUES(@param1,@param2,@param3,@param4)";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.Add("@param1", SqlDbType.DateTime).Value = System.DateTime.Now;
                        cmd.Parameters.Add("@param2", SqlDbType.Int).Value = Convert.ToInt32(txtSalesOrder.Text);
                        cmd.Parameters.Add("@param3", SqlDbType.DateTime).Value = Convert.ToDateTime(txtPromiseDate.Text);
                        cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = txtSalesPerson.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Shipping_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
