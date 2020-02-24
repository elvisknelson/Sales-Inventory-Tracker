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
        int salesOrder;
        public SaleDetails(int _salesOrder)
        {
            InitializeComponent();
            salesOrder = _salesOrder;
        }

        private void BinDetails_Load(object sender, EventArgs e)
        {
            dgvSaleDetails.DataSource = dataService.GetDataTable("SELECT Sales_Order AS 'Sales #', Size, Options FROM BINS WHERE Sales_Order = " + salesOrder);
        }
    }
}
