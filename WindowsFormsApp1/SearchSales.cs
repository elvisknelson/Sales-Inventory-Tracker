using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
