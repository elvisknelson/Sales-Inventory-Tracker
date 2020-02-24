using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConceptApp
{
    public partial class SearchSales : UserControl
    {
        public SearchSales()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void BindGrid()
        {
            DataService dataService = new DataService();
            dgvSales.DataSource = dataService.SearchBins(dtStartDate.Text, dtEndDate.Text);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SaleDetails form = new SaleDetails(Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells[0].Value));
            form.ShowDialog();
        }
    }
}
