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
        private SqlConnectionStringBuilder _builder = new SqlConnectionStringBuilder();
        private DataService _dataService = new DataService();
        private int _row;

        public NewCustomer()
        {
            InitializeComponent();
            _builder.DataSource = "conceptserv.database.windows.net";
            _builder.UserID = "sysadm";
            _builder.Password = "Password42";
            _builder.InitialCatalog = "conceptDB";
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgvCustomers.DataSource = _dataService.GetDataTable("SELECT Id AS 'Customer Id', Name AS 'Customer Name', Address FROM CUSTOMERS");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txtCustomerAddress.TextLength > 0 && txtCustomerName.TextLength > 0)
            {
                _dataService.AddData("CUSTOMERS", 
                    new SqlParam("Name", SqlDbType.VarChar, txtCustomerName.Text), 
                    new SqlParam("Address", SqlDbType.VarChar, txtCustomerAddress.Text));
                
                MessageBox.Show("Customer Added Successfully");
                BindGrid();
                ClearTextBoxes();
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
                    _row = currentMouseOverRow;
                    cMSCustomer.Show(dgvCustomers, new Point(e.X, e.Y));
                }
            }
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete " + dgvCustomers.Rows[_row].Cells[1].Value.ToString(),
                                                   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_builder.ConnectionString))
                    {
                        connection.Open();
                        string sql = "DELETE FROM CUSTOMERS WHERE Id = " + dgvCustomers.Rows[_row].Cells[0].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show(dgvCustomers.Rows[_row].Cells[1].Value.ToString() + " Deleted Successfully");
                    dgvCustomers.DataSource = _dataService.GetDataTable("SELECT Id AS 'Customer Id', Name AS 'Customer Name', Address FROM CUSTOMERS");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
