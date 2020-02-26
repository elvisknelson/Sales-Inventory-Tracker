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
    public partial class ShippingSchedule : UserControl
    {
        private DataService _dataService = new DataService();

        public ShippingSchedule()
        {
            InitializeComponent();
        }

        private void ShippingSchedule_Load(object sender, EventArgs e)
        {
            dgvShippingSchedule.DataSource = _dataService.GetDataTable("SELECT * FROM SALES");
        }
    }
}
