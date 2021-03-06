﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private SqlConnectionStringBuilder _builder = new SqlConnectionStringBuilder();

        public SaleDetails(int salesOrder)
        {
            InitializeComponent();
            _salesOrder = salesOrder;

            _builder.DataSource = "conceptserv.database.windows.net";
            _builder.UserID = "sysadm";
            _builder.Password = "Password42";
            _builder.InitialCatalog = "conceptDB";
        }

        private void BinDetails_Load(object sender, EventArgs e)
        {
            BindDataGrid();
            BindTextBoxes();
        }

        private void BindDataGrid()
        {
            dgvSaleDetails.DataSource = dataService.GetDataTable("SELECT Id AS 'Bin Id', Sales_Order AS 'Sales #', Size, Options, " +
                "Winter_Bin AS 'Winter Bin', Painted AS 'Date Painted', Location FROM BINS WHERE Sales_Order = " + _salesOrder);
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
            dtpDatePainted.Text = binData.Rows[0].ItemArray[4].ToString();
            chBWinterBin.Checked = Convert.ToBoolean(binData.Rows[0].ItemArray[5].ToString());
            txtBinLocation.Text = binData.Rows[0].ItemArray[6].ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE BINS SET Size = @param1, Options = @param2, Painted = @param3, Winter_Bin = @param4, Location = @param5 " +
                        "WHERE Id = " + _binId;
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = txtBinOptions.Text;
                        cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = txtBinOptions.Text;
                        cmd.Parameters.Add("@param3", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpDatePainted.Text);
                        cmd.Parameters.Add("@param4", SqlDbType.Bit).Value = chBWinterBin.Checked;
                        cmd.Parameters.Add("@param5", SqlDbType.VarChar).Value = txtBinLocation.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bin Saved Successfully");
                    BindDataGrid();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
