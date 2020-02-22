﻿namespace WindowsFormsApp1
{
    partial class Shipping
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.txtPromiseDate = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.txtSalesOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetBin
            // 
            this.btnGetBin.Location = new System.Drawing.Point(406, 330);
            this.btnGetBin.Name = "btnGetBin";
            this.btnGetBin.Size = new System.Drawing.Size(144, 23);
            this.btnGetBin.TabIndex = 0;
            this.btnGetBin.Text = "Get Bin";
            this.btnGetBin.UseVisualStyleBackColor = true;
            this.btnGetBin.Click += new System.EventHandler(this.btnGetBin_Click);
            // 
            // lblSalesOrderDate
            // 
            this.lblSalesOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesOrderDate.Location = new System.Drawing.Point(406, 103);
            this.lblSalesOrderDate.Name = "lblSalesOrderDate";
            this.lblSalesOrderDate.Size = new System.Drawing.Size(144, 23);
            this.lblSalesOrderDate.TabIndex = 1;
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesOrder.Location = new System.Drawing.Point(406, 158);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(144, 23);
            this.lblSalesOrder.TabIndex = 2;
            // 
            // lblSalesPromise
            // 
            this.lblSalesPromise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesPromise.Location = new System.Drawing.Point(406, 209);
            this.lblSalesPromise.Name = "lblSalesPromise";
            this.lblSalesPromise.Size = new System.Drawing.Size(144, 23);
            this.lblSalesPromise.TabIndex = 3;
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesPerson.Location = new System.Drawing.Point(406, 268);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(144, 23);
            this.lblSalesPerson.TabIndex = 4;
            // 
            // txtBinSalesId
            // 
            this.txtBinSalesId.Location = new System.Drawing.Point(406, 304);
            this.txtBinSalesId.Name = "txtBinSalesId";
            this.txtBinSalesId.Size = new System.Drawing.Size(144, 20);
            this.txtBinSalesId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sales Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sales Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Promise Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sales Person";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findBinToolStripMenuItem,
            this.addBinToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(245, 230);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(125, 20);
            this.txtSalesPerson.TabIndex = 6;
            // 
            // txtPromiseDate
            // 
            this.txtPromiseDate.Location = new System.Drawing.Point(245, 289);
            this.txtPromiseDate.Name = "txtPromiseDate";
            this.txtPromiseDate.Size = new System.Drawing.Size(125, 20);
            this.txtPromiseDate.TabIndex = 7;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(245, 330);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(125, 23);
            this.btnAddSale.TabIndex = 8;
            this.btnAddSale.Text = "Add Bin Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.BtnAddSale_Click);
            // 
            // txtSalesOrder
            // 
            this.txtSalesOrder.Location = new System.Drawing.Point(245, 179);
            this.txtSalesOrder.Name = "txtSalesOrder";
            this.txtSalesOrder.Size = new System.Drawing.Size(125, 20);
            this.txtSalesOrder.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sales Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sales Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Promise Date";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // addBinToolStripMenuItem
            // 
            this.addBinToolStripMenuItem.Name = "addBinToolStripMenuItem";
            this.addBinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBinToolStripMenuItem.Text = "Add Bin";
            // 
            // findBinToolStripMenuItem
            // 
            this.findBinToolStripMenuItem.Name = "findBinToolStripMenuItem";
            this.findBinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findBinToolStripMenuItem.Text = "Find Bin";
            // 
            // Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Shipping";
            this.Text = "Concept Bins";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.TextBox txtPromiseDate;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.TextBox txtSalesOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem findBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

