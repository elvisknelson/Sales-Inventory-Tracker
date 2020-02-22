using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void addNewBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage("New Bin");
            tabControl.TabPages.Add(tabPage);
            tabPage.Controls.Add(new New());
        }

        private void findBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage("Find Bin");
            tabControl.TabPages.Add(tabPage);
            tabPage.Controls.Add(new Find());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
