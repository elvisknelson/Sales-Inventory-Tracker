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
    public partial class NewSale : UserControl
    {
        //TODO(Elvis): Mass validation (Validation class?)
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        Sale sale;

        public NewSale()
        {
            InitializeComponent();
            builder.DataSource = "conceptserv.database.windows.net";
            builder.UserID = "sysadm";
            builder.Password = "Password42";
            builder.InitialCatalog = "conceptDB";
        }

        private void New_Load(object sender, EventArgs e)
        {
            bindComboBox();
        }

        private void bindComboBox()
        {
            DataService dataService = new DataService();
            cboCustomers.DataSource = dataService.GetData("SELECT * FROM CUSTOMERS");
            cboCustomers.DisplayMember = "Name";
            cboCustomers.ValueMember = "Id";
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            sale = new Sale(Convert.ToInt32(txtSalesOrder.Text));
        }

        private void btnAddBin_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = { chBSK, chBMW, ckB3VG, ckB4SIA, ckBAH2410, ckBAR7000, ckBAR8000, ckBFMB, ckBGN, ckBIP, ckBLA, ckBPH };
            string options = "";
            foreach (CheckBox box in checkBoxes)
            {
                if (box.Checked)
                {
                    options += box.Name.Substring(3) + ", ";
                }
            }

            Bin bin = new Bin(sale.salesOrder, txtBinSize.Text, Convert.ToDateTime(dtpPromiseDate.Text), Convert.ToInt32(txtHoursWorked.Text), options);
            sale.bins.Add(bin);
            updateGrid();
        }

        private void updateGrid()
        {
            dgvCurrentSale.DataSource = sale.bins.ToList();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {

        }
    }
}

