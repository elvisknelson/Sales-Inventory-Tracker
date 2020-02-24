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

namespace ConceptApp
{
    public partial class NewCustomer : UserControl
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        DataService dataService = new DataService();

        public NewCustomer()
        {
            InitializeComponent();
            builder.DataSource = "conceptserv.database.windows.net";
            builder.UserID = "sysadm";
            builder.Password = "Password42";
            builder.InitialCatalog = "conceptDB";
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgvCustomers.DataSource = dataService.GetDataTable("SELECT Name AS 'Customer Name', Address FROM CUSTOMERS");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(Utility.IsValidString(txtCustomerName.Text) && Utility.IsValidString(txtCustomerAddress.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {
                        connection.Open();
                        string sql = "INSERT INTO CUSTOMERS(Name, Address) VALUES(@param1, @param2)";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = txtCustomerName.Text;
                            cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = txtCustomerAddress.Text;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer Added Successfully");
                    BindGrid();
                    ClearTextBoxes();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please make sure both fields are not blank", "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBoxes()
        {
            txtCustomerAddress.Clear();
            txtCustomerName.Clear();
        }
    }
}
