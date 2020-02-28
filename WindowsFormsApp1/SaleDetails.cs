using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConceptApp
{
    public partial class SaleDetails : Form
    {
        DataService dataService = new DataService();
        private int _salesOrder;
        private int _binId;

        public SaleDetails(int salesOrder)
        {
            InitializeComponent();
            _salesOrder = salesOrder;
        }

        private void BinDetails_Load(object sender, EventArgs e)
        {
            dgvSaleDetails.DataSource = dataService.GetDataTable("SELECT Id AS 'Bin Id', Sales_Order AS 'Sales #', Size, Options, " +
                "Winter_Bin AS 'Winter Bin', Painted AS 'Date Painted', Location FROM BINS WHERE Sales_Order = " + _salesOrder);

            BindTextBoxes();
        }

        private void BindTextBoxes()
        {
            DataTable salesData = dataService.GetDataTable("SELECT * FROM SALES WHERE Sales_Order = '" + _salesOrder + "'");

            txtSalesOrder.Text = _salesOrder.ToString();
            txtCustomer.Text = salesData.Rows[0].ItemArray[1].ToString();
            txtNumBins.Text = salesData.Rows[0].ItemArray[5].ToString();
        }

        private void dgvSaleDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable binData = dataService.GetDataTable("SELECT * FROM BINS WHERE Id = " + Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells[0].Value));
            txtBinSize.Text = binData.Rows[0].ItemArray[1].ToString();
            _binId = Convert.ToInt32(binData.Rows[0].ItemArray[2].ToString());
            txtBinOptions.Text = binData.Rows[0].ItemArray[3].ToString();
            txtPaintedDate.Text = binData.Rows[0].ItemArray[4].ToString();
            txtWinterBin.Text = binData.Rows[0].ItemArray[5].ToString();
            txtBinLocation.Text = binData.Rows[0].ItemArray[6].ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
