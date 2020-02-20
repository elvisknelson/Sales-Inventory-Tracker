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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetBin_Click(object sender, EventArgs e)
        {
            int salesOrder = -1;

            if (isValid(txtBinSalesId.Text))
            {
                salesOrder = Convert.ToByte(txtBinSalesId.Text);

                object[] binInfo = new object[4];

                binInfo = Pull_BinInfo(salesOrder);

                if (binInfo[0] != null)
                {
                    lblSalesOrderDate.Text = binInfo[0].ToString();
                    lblSalesOrder.Text = binInfo[1].ToString();
                    lblSalesPromise.Text = binInfo[2].ToString();
                    lblSalesPerson.Text = binInfo[3].ToString();
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

        public Boolean isValid(string str)
        {
            Boolean result = false;
            byte parseResult;

            if(str.Length > 0 && byte.TryParse(str, out parseResult))
            {
                result = true;
            }

            return result;
        }

        private object[] Pull_BinInfo(int salesOrder)
        {
            object[] result = new object[4];

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "conceptserv.database.windows.net";
                builder.UserID = "sysadm";
                builder.Password = "Password42";
                builder.InitialCatalog = "conceptDB";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM BINS WHERE salesOrder = " + salesOrder);
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if(reader.HasRows)
                                {
                                    result[0] = reader[0];
                                    result[1] = reader[1];
                                    result[2] = reader[2];
                                    result[3] = reader[3];
                                }
                                else
                                {
                                    return null;
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
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
                    string sql = "INSERT INTO BINS(orderDate,salesOrder,promiseDate,promiseDate,salesPerson) VALUES(@param1,@param2,@param3,@param4)";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.Add("@param1", SqlDbType.DateTime).Value = System.DateTime.Now;
                        cmd.Parameters.Add("@param2", SqlDbType.Int).Value = Convert.ToInt32(txtSalesOrder.Text);
                        cmd.Parameters.Add("@param3", SqlDbType.DateTime).Value = Convert.ToDateTime(txtPromiseDate.Text);
                        cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtPromiseDate.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
