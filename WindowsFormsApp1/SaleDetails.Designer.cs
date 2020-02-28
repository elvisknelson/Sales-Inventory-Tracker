namespace ConceptApp
{
    partial class SaleDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSaleDetails = new System.Windows.Forms.DataGridView();
            this.txtSalesOrder = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtNumBins = new System.Windows.Forms.TextBox();
            this.txtBinSize = new System.Windows.Forms.TextBox();
            this.txtBinOptions = new System.Windows.Forms.TextBox();
            this.txtBinLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.chBWinterBin = new System.Windows.Forms.CheckBox();
            this.dtpDatePainted = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSaleDetails
            // 
            this.dgvSaleDetails.AllowUserToAddRows = false;
            this.dgvSaleDetails.AllowUserToDeleteRows = false;
            this.dgvSaleDetails.AllowUserToOrderColumns = true;
            this.dgvSaleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetails.Location = new System.Drawing.Point(12, 177);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.ReadOnly = true;
            this.dgvSaleDetails.Size = new System.Drawing.Size(899, 311);
            this.dgvSaleDetails.TabIndex = 0;
            this.dgvSaleDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleDetails_CellDoubleClick);
            // 
            // txtSalesOrder
            // 
            this.txtSalesOrder.Location = new System.Drawing.Point(34, 71);
            this.txtSalesOrder.Name = "txtSalesOrder";
            this.txtSalesOrder.Size = new System.Drawing.Size(172, 20);
            this.txtSalesOrder.TabIndex = 1;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(212, 71);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(172, 20);
            this.txtCustomer.TabIndex = 2;
            // 
            // txtNumBins
            // 
            this.txtNumBins.Location = new System.Drawing.Point(390, 71);
            this.txtNumBins.Name = "txtNumBins";
            this.txtNumBins.Size = new System.Drawing.Size(100, 20);
            this.txtNumBins.TabIndex = 3;
            // 
            // txtBinSize
            // 
            this.txtBinSize.Location = new System.Drawing.Point(34, 131);
            this.txtBinSize.Name = "txtBinSize";
            this.txtBinSize.Size = new System.Drawing.Size(172, 20);
            this.txtBinSize.TabIndex = 4;
            // 
            // txtBinOptions
            // 
            this.txtBinOptions.Location = new System.Drawing.Point(212, 131);
            this.txtBinOptions.Name = "txtBinOptions";
            this.txtBinOptions.Size = new System.Drawing.Size(172, 20);
            this.txtBinOptions.TabIndex = 5;
            // 
            // txtBinLocation
            // 
            this.txtBinLocation.Location = new System.Drawing.Point(596, 131);
            this.txtBinLocation.Name = "txtBinLocation";
            this.txtBinLocation.Size = new System.Drawing.Size(172, 20);
            this.txtBinLocation.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sales Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Bins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bin Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bin Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(780, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Winter Bin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date Painted";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bin Location";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(923, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApp1.Properties.Resources.Save_black;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // chBWinterBin
            // 
            this.chBWinterBin.AutoSize = true;
            this.chBWinterBin.Location = new System.Drawing.Point(783, 131);
            this.chBWinterBin.Name = "chBWinterBin";
            this.chBWinterBin.Size = new System.Drawing.Size(15, 14);
            this.chBWinterBin.TabIndex = 18;
            this.chBWinterBin.UseVisualStyleBackColor = true;
            // 
            // dtpDatePainted
            // 
            this.dtpDatePainted.Location = new System.Drawing.Point(390, 131);
            this.dtpDatePainted.Name = "dtpDatePainted";
            this.dtpDatePainted.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePainted.TabIndex = 19;
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 500);
            this.Controls.Add(this.dtpDatePainted);
            this.Controls.Add(this.chBWinterBin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBinLocation);
            this.Controls.Add(this.txtBinOptions);
            this.Controls.Add(this.txtBinSize);
            this.Controls.Add(this.txtNumBins);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtSalesOrder);
            this.Controls.Add(this.dgvSaleDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SaleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Details";
            this.Load += new System.EventHandler(this.BinDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaleDetails;
        private System.Windows.Forms.TextBox txtSalesOrder;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtNumBins;
        private System.Windows.Forms.TextBox txtBinSize;
        private System.Windows.Forms.TextBox txtBinOptions;
        private System.Windows.Forms.TextBox txtBinLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox chBWinterBin;
        private System.Windows.Forms.DateTimePicker dtpDatePainted;
    }
}