namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnGetBin = new System.Windows.Forms.Button();
            this.lblSalesOrderDate = new System.Windows.Forms.Label();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblSalesPromise = new System.Windows.Forms.Label();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.txtBinSalesId = new System.Windows.Forms.TextBox();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.txtPromiseDate = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.txtSalesOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetBin
            // 
            this.btnGetBin.Location = new System.Drawing.Point(415, 113);
            this.btnGetBin.Name = "btnGetBin";
            this.btnGetBin.Size = new System.Drawing.Size(75, 23);
            this.btnGetBin.TabIndex = 0;
            this.btnGetBin.Text = "Get Bin";
            this.btnGetBin.UseVisualStyleBackColor = true;
            this.btnGetBin.Click += new System.EventHandler(this.btnGetBin_Click);
            // 
            // lblSalesOrderDate
            // 
            this.lblSalesOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesOrderDate.Location = new System.Drawing.Point(59, 34);
            this.lblSalesOrderDate.Name = "lblSalesOrderDate";
            this.lblSalesOrderDate.Size = new System.Drawing.Size(144, 23);
            this.lblSalesOrderDate.TabIndex = 1;
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesOrder.Location = new System.Drawing.Point(243, 34);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(144, 23);
            this.lblSalesOrder.TabIndex = 2;
            // 
            // lblSalesPromise
            // 
            this.lblSalesPromise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesPromise.Location = new System.Drawing.Point(425, 34);
            this.lblSalesPromise.Name = "lblSalesPromise";
            this.lblSalesPromise.Size = new System.Drawing.Size(144, 23);
            this.lblSalesPromise.TabIndex = 3;
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesPerson.Location = new System.Drawing.Point(606, 34);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(144, 23);
            this.lblSalesPerson.TabIndex = 4;
            // 
            // txtBinSalesId
            // 
            this.txtBinSalesId.Location = new System.Drawing.Point(300, 113);
            this.txtBinSalesId.Name = "txtBinSalesId";
            this.txtBinSalesId.Size = new System.Drawing.Size(100, 20);
            this.txtBinSalesId.TabIndex = 5;
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(78, 245);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(125, 20);
            this.txtSalesPerson.TabIndex = 6;
            // 
            // txtPromiseDate
            // 
            this.txtPromiseDate.Location = new System.Drawing.Point(78, 304);
            this.txtPromiseDate.Name = "txtPromiseDate";
            this.txtPromiseDate.Size = new System.Drawing.Size(125, 20);
            this.txtPromiseDate.TabIndex = 7;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(78, 345);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(125, 23);
            this.btnAddSale.TabIndex = 8;
            this.btnAddSale.Text = "Add Bin Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.BtnAddSale_Click);
            // 
            // txtSalesOrder
            // 
            this.txtSalesOrder.Location = new System.Drawing.Point(78, 194);
            this.txtSalesOrder.Name = "txtSalesOrder";
            this.txtSalesOrder.Size = new System.Drawing.Size(125, 20);
            this.txtSalesOrder.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sales Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sales Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Promise Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalesOrder);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.txtPromiseDate);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.txtBinSalesId);
            this.Controls.Add(this.lblSalesPerson);
            this.Controls.Add(this.lblSalesPromise);
            this.Controls.Add(this.lblSalesOrder);
            this.Controls.Add(this.lblSalesOrderDate);
            this.Controls.Add(this.btnGetBin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetBin;
        private System.Windows.Forms.Label lblSalesOrderDate;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Label lblSalesPromise;
        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.TextBox txtBinSalesId;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.TextBox txtPromiseDate;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.TextBox txtSalesOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

