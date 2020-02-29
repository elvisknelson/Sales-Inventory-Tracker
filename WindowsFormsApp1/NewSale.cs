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
    public partial class NewSale : UserControl
    {
        //TODO(Elvis): Mass validation (Validation class?)
        private SqlConnectionStringBuilder _builder = new SqlConnectionStringBuilder();
        private Sale _sale;
        private DataService _dataService = new DataService();

        public NewSale()
        {
            InitializeComponent();
            _builder.DataSource = "conceptserv.database.windows.net";
            _builder.UserID = "sysadm";
            _builder.Password = "Password42";
            _builder.InitialCatalog = "conceptDB";
        }

        /// <summary>
        /// Form Initial load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Load(object sender, EventArgs e)
        {
            bindComboBox();
        }

        /// <summary>
        /// Binds the Combobox to Customer Table
        /// </summary>
        private void bindComboBox()
        {
            DataService dataService = new DataService();
            cboCustomers.DataSource = dataService.GetDataTable("SELECT * FROM CUSTOMERS");
            cboCustomers.DisplayMember = "Name";
            cboCustomers.ValueMember = "Id";
        }

        /// <summary>
        /// Creates a Sale Object to store all the relevant sales information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            
            if(Utility.IsValidInt(txtSalesOrder.Text))
            {
                btnAddSale.Enabled = false;
                _sale = new Sale(Convert.ToInt32(txtSalesOrder.Text));
            }
            else
            {
                MessageBox.Show("Please enter a valid Sales Order Number", "Invalid Order Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Adds a new bin to the Sales object and populates the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBin_Click(object sender, EventArgs e)
        {
            if(_sale != null)
            {
                CheckBox[] checkBoxes = { chBSK, chBMW, ckB3VG, ckB4SIA, ckBAH2410, ckBAR7000, ckBAR8000, ckBFMB, ckBGN, ckBIP, ckBLA, ckBPH };
                string options = "";
                string comma = "";
                foreach (CheckBox box in checkBoxes)
                {
                    if (box.Checked)
                    {
                        options += comma + box.Name.Substring(3);
                        comma = ", ";
                    }
                }
                    
                if(Utility.IsValidInt(txtHoursWorked.Text))
                {
                    Bin bin = new Bin(_sale.salesOrder, txtBinSize.Text, Convert.ToDateTime(dtpPromiseDate.Text), Convert.ToInt32(txtHoursWorked.Text), options, chBWinterBin.Checked);
                    _sale.bins.Add(bin);
                    updateGrid();
                }
                else
                {
                    MessageBox.Show("Invalid Bin Hours Worked");
                }
            }
            else
            {
                MessageBox.Show("Please create a new sales order before adding bins.", "No Sales Order Created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Updates the DataGridView
        /// </summary>
        private void updateGrid()
        {
            dgvCurrentSale.DataSource = _sale.bins.ToList();
        }

        /// <summary>
        /// Adds the Sales information to the Sales Table and the Bin information to their respective tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if(_sale != null && _sale.bins.Count > 0)
            {
                _dataService.AddData("SALES",
                    new SqlParam("Sales_Order", SqlDbType.VarChar, txtSalesOrder.Text),
                    new SqlParam("Estimated_Hours", SqlDbType.Int, txtHoursWorked.Text),
                    new SqlParam("Actual_Hours", SqlDbType.Int, 55),
                    new SqlParam("Promise_Date", SqlDbType.DateTime, dtpPromiseDate.Text),
                    new SqlParam("Customer", SqlDbType.VarChar, cboCustomers.Text),
                    new SqlParam("Num_Bins", SqlDbType.Int, _sale.bins.Count),
                    new SqlParam("Notes", SqlDbType.VarChar, txtNotes.Text));

                foreach (Bin bin in _sale.bins)
                {
                    _dataService.AddData("BINS",
                        new SqlParam("Sales_Order", SqlDbType.Int, txtSalesOrder.Text),
                        new SqlParam("Size", SqlDbType.VarChar, bin.binSize),
                        new SqlParam("Options", SqlDbType.VarChar, bin.options),
                        new SqlParam("Winter_Bin", SqlDbType.Bit, bin.winterBin));
                }

                MessageBox.Show("Sale Created Successfully");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please create a new sales order before completing order or add bins to the current sale.", 
                    "No Sales Order Created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Clears all the controls on the form
        /// </summary>
        private void ClearForm()
        {
            txtBinSize.Clear();
            txtHoursWorked.Clear();
            txtSalesOrder.Clear();

            CheckBox[] checkBoxes = { chBSK, chBMW, ckB3VG, ckB4SIA, ckBAH2410, ckBAR7000, ckBAR8000, ckBFMB, ckBGN, ckBIP, ckBLA, ckBPH };
            foreach (CheckBox box in checkBoxes)
            {
                if (box.Checked)
                {
                    box.Checked = false;
                }
            }

            btnAddSale.Enabled = true;
            dgvCurrentSale.DataSource = null;
        }

        /// <summary>
        /// Update ComboBox on click to guarantee latest data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCustomers_Click(object sender, EventArgs e)
        {
            bindComboBox();
        }
    }
}

