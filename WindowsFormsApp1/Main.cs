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
        private TabPage newSaleTab;
        private TabPage searchSalesTab;
        private TabPage newCustTab;
        private TabPage searchCustTab;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.IsSelected)
            {
                if(e.Node.Name == "AddSaleNode")
                {
                    if(newSaleTab != null)
                    {
                        tabControl.SelectedTab = newSaleTab;
                    }
                    else
                    {
                        newSaleTab = new TabPage("New Sale");
                        tabControl.TabPages.Add(newSaleTab);
                        newSaleTab.Controls.Add(new NewSale());
                        tabControl.SelectedTab = newSaleTab;
                    }
                }
                else if(e.Node.Name == "FindSaleNode")
                {
                    if (searchSalesTab != null)
                    {
                        tabControl.SelectedTab = searchSalesTab;
                    }
                    else
                    {
                        searchSalesTab = new TabPage("Search Sales");
                        tabControl.TabPages.Add(searchSalesTab);
                        searchSalesTab.Controls.Add(new SearchSales());
                        tabControl.SelectedTab = searchSalesTab;
                    }
                }
                else if (e.Node.Name == "AddCustomerNode")
                {
                    if (newCustTab != null)
                    {
                        tabControl.SelectedTab = newCustTab;
                    }
                    else
                    {
                        newCustTab = new TabPage("New Customer");
                        tabControl.TabPages.Add(newCustTab);
                        newCustTab.Controls.Add(new NewCustomer());
                        tabControl.SelectedTab = newCustTab;
                    }
                }
                else if (e.Node.Name == "SearchCustomerNode")
                {
                    if (searchCustTab != null)
                    {
                        tabControl.SelectedTab = searchCustTab;
                    }
                    else
                    {
                        searchCustTab = new TabPage("Search Customers");
                        tabControl.TabPages.Add(searchCustTab);
                        searchCustTab.Controls.Add(new SearchCustomer());
                        tabControl.SelectedTab = searchCustTab;
                    }
                }
            }
        }
    }
}
