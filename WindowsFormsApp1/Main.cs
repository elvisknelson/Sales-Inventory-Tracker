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
    public partial class Main : Form
    {
        private TabPage _newSaleTab;
        private TabPage _searchSalesTab;
        private TabPage _newCustTab;
        private TabPage _searchCustTab;
        private TabPage _shippingScheduleTab;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            treeViewModules.ExpandAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void treeViewModules_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pbLogo.Hide();
            if (e.Node.IsSelected)
            {
                if (e.Node.Name == "AddSaleNode")
                {
                    if (_newSaleTab != null)
                    {
                        tabControl.SelectedTab = _newSaleTab;
                    }
                    else
                    {
                        _newSaleTab = new TabPage("New Sale");
                        tabControl.TabPages.Add(_newSaleTab);
                        _newSaleTab.Controls.Add(new NewSale());
                        tabControl.SelectedTab = _newSaleTab;
                    }
                }
                else if (e.Node.Name == "FindSaleNode")
                {
                    if (_searchSalesTab != null)
                    {
                        tabControl.SelectedTab = _searchSalesTab;
                    }
                    else
                    {
                        _searchSalesTab = new TabPage("Search Sales");
                        tabControl.TabPages.Add(_searchSalesTab);
                        _searchSalesTab.Controls.Add(new SearchSales());
                        tabControl.SelectedTab = _searchSalesTab;
                    }
                }
                else if (e.Node.Name == "AddCustomerNode")
                {
                    if (_newCustTab != null)
                    {
                        tabControl.SelectedTab = _newCustTab;
                    }
                    else
                    {
                        _newCustTab = new TabPage("New Customer");
                        tabControl.TabPages.Add(_newCustTab);
                        _newCustTab.Controls.Add(new NewCustomer());
                        tabControl.SelectedTab = _newCustTab;
                    }
                }
                else if (e.Node.Name == "SearchCustomerNode")
                {
                    if (_searchCustTab != null)
                    {
                        tabControl.SelectedTab = _searchCustTab;
                    }
                    else
                    {
                        _searchCustTab = new TabPage("Search Customers");
                        tabControl.TabPages.Add(_searchCustTab);
                        _searchCustTab.Controls.Add(new SearchCustomer());
                        tabControl.SelectedTab = _searchCustTab;
                    }
                }
                else if (e.Node.Name == "ShippingScheduleNode")
                {
                    if (_shippingScheduleTab != null)
                    {
                        tabControl.SelectedTab = _shippingScheduleTab;
                    }
                    else
                    {
                        _shippingScheduleTab = new TabPage("Shipping Schedule");
                        tabControl.TabPages.Add(_shippingScheduleTab);
                        _shippingScheduleTab.Controls.Add(new ShippingSchedule());
                        tabControl.SelectedTab = _shippingScheduleTab;
                    }
                }
            }
        }
    }
}
