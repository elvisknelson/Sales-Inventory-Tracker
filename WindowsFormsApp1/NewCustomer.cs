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
        int row;

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
            dgvCustomers.DataSource = dataService.GetDataTable("SELECT Id AS 'Customer Id', Name AS 'Customer Name', Address FROM CUSTOMERS");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txtCustomerAddress.TextLength > 0 && txtCustomerName.TextLength > 0)
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

        private void dgvCustomers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvCustomers.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    row = currentMouseOverRow;
                    cMSCustomer.Show(dgvCustomers, new Point(e.X, e.Y));
                }
            }
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete " + dgvCustomers.Rows[row].Cells[1].Value.ToString(),
                                                   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {
                        connection.Open();
                        string sql = "DELETE FROM CUSTOMERS WHERE Id = " + dgvCustomers.Rows[row].Cells[0].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show(dgvCustomers.Rows[row].Cells[1].Value.ToString() + " Deleted Successfully");
                    dgvCustomers.DataSource = dataService.GetDataTable("SELECT Id AS 'Customer Id', Name AS 'Customer Name', Address FROM CUSTOMERS");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
