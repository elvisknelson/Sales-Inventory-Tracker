namespace ConceptApp
{
    partial class NewSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPromiseDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalesOrder = new System.Windows.Forms.TextBox();
            this.dgvCurrentSale = new System.Windows.Forms.DataGridView();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckBPH = new System.Windows.Forms.CheckBox();
            this.chBSK = new System.Windows.Forms.CheckBox();
            this.chBMW = new System.Windows.Forms.CheckBox();
            this.ckBLA = new System.Windows.Forms.CheckBox();
            this.ckBAR7000 = new System.Windows.Forms.CheckBox();
            this.ckBAR8000 = new System.Windows.Forms.CheckBox();
            this.ckBGN = new System.Windows.Forms.CheckBox();
            this.ckBFMB = new System.Windows.Forms.CheckBox();
            this.ckB4SIA = new System.Windows.Forms.CheckBox();
            this.ckBAH2410 = new System.Windows.Forms.CheckBox();
            this.ckB3VG = new System.Windows.Forms.CheckBox();
            this.ckBIP = new System.Windows.Forms.CheckBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBinSize = new System.Windows.Forms.TextBox();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentSale)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(772, 31);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(200, 23);
            this.btnAddSale.TabIndex = 35;
            this.btnAddSale.Text = "Create Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Promise Date:";
            // 
            // dtpPromiseDate
            // 
            this.dtpPromiseDate.Location = new System.Drawing.Point(443, 34);
            this.dtpPromiseDate.Name = "dtpPromiseDate";
            this.dtpPromiseDate.Size = new System.Drawing.Size(323, 20);
            this.dtpPromiseDate.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Customer:";
            // 
            // cboCustomers
            // 
            this.cboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(162, 33);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(275, 21);
            this.cboCustomers.TabIndex = 57;
            this.cboCustomers.Click += new System.EventHandler(this.cboCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sales Order:";
            // 
            // txtSalesOrder
            // 
            this.txtSalesOrder.Location = new System.Drawing.Point(11, 34);
            this.txtSalesOrder.Name = "txtSalesOrder";
            this.txtSalesOrder.Size = new System.Drawing.Size(145, 20);
            this.txtSalesOrder.TabIndex = 36;
            // 
            // dgvCurrentSale
            // 
            this.dgvCurrentSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentSale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCurrentSale.Location = new System.Drawing.Point(0, 319);
            this.dgvCurrentSale.Name = "dgvCurrentSale";
            this.dgvCurrentSale.Size = new System.Drawing.Size(984, 263);
            this.dgvCurrentSale.TabIndex = 60;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(11, 90);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(961, 49);
            this.txtNotes.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Notes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBin);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtHoursWorked);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBinSize);
            this.groupBox2.Location = new System.Drawing.Point(11, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 168);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bin";
            // 
            // btnAddBin
            // 
            this.btnAddBin.Location = new System.Drawing.Point(21, 95);
            this.btnAddBin.Name = "btnAddBin";
            this.btnAddBin.Size = new System.Drawing.Size(200, 23);
            this.btnAddBin.TabIndex = 66;
            this.btnAddBin.Text = "Add Bin to Order";
            this.btnAddBin.UseVisualStyleBackColor = true;
            this.btnAddBin.Click += new System.EventHandler(this.btnAddBin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckBPH);
            this.groupBox1.Controls.Add(this.chBSK);
            this.groupBox1.Controls.Add(this.chBMW);
            this.groupBox1.Controls.Add(this.ckBLA);
            this.groupBox1.Controls.Add(this.ckBAR7000);
            this.groupBox1.Controls.Add(this.ckBAR8000);
            this.groupBox1.Controls.Add(this.ckBGN);
            this.groupBox1.Controls.Add(this.ckBFMB);
            this.groupBox1.Controls.Add(this.ckB4SIA);
            this.groupBox1.Controls.Add(this.ckBAH2410);
            this.groupBox1.Controls.Add(this.ckB3VG);
            this.groupBox1.Controls.Add(this.ckBIP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(264, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 87);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ckBPH
            // 
            this.ckBPH.AutoSize = true;
            this.ckBPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBPH.Location = new System.Drawing.Point(283, 51);
            this.ckBPH.Name = "ckBPH";
            this.ckBPH.Size = new System.Drawing.Size(40, 19);
            this.ckBPH.TabIndex = 53;
            this.ckBPH.Text = "ph";
            this.ckBPH.UseVisualStyleBackColor = true;
            // 
            // chBSK
            // 
            this.chBSK.AutoSize = true;
            this.chBSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBSK.Location = new System.Drawing.Point(23, 28);
            this.chBSK.Name = "chBSK";
            this.chBSK.Size = new System.Drawing.Size(38, 19);
            this.chBSK.TabIndex = 43;
            this.chBSK.Text = "sk";
            this.chBSK.UseVisualStyleBackColor = true;
            // 
            // chBMW
            // 
            this.chBMW.AutoSize = true;
            this.chBMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBMW.Location = new System.Drawing.Point(23, 51);
            this.chBMW.Name = "chBMW";
            this.chBMW.Size = new System.Drawing.Size(46, 19);
            this.chBMW.TabIndex = 44;
            this.chBMW.Text = "mw";
            this.chBMW.UseVisualStyleBackColor = true;
            // 
            // ckBLA
            // 
            this.ckBLA.AutoSize = true;
            this.ckBLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBLA.Location = new System.Drawing.Point(128, 28);
            this.ckBLA.Name = "ckBLA";
            this.ckBLA.Size = new System.Drawing.Size(40, 19);
            this.ckBLA.TabIndex = 45;
            this.ckBLA.Text = "LA";
            this.ckBLA.UseVisualStyleBackColor = true;
            // 
            // ckBAR7000
            // 
            this.ckBAR7000.AutoSize = true;
            this.ckBAR7000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBAR7000.Location = new System.Drawing.Point(329, 51);
            this.ckBAR7000.Name = "ckBAR7000";
            this.ckBAR7000.Size = new System.Drawing.Size(65, 19);
            this.ckBAR7000.TabIndex = 54;
            this.ckBAR7000.Text = "ar7000";
            this.ckBAR7000.UseVisualStyleBackColor = true;
            // 
            // ckBAR8000
            // 
            this.ckBAR8000.AutoSize = true;
            this.ckBAR8000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBAR8000.Location = new System.Drawing.Point(127, 51);
            this.ckBAR8000.Name = "ckBAR8000";
            this.ckBAR8000.Size = new System.Drawing.Size(76, 19);
            this.ckBAR8000.TabIndex = 46;
            this.ckBAR8000.Text = "ar8000-4";
            this.ckBAR8000.UseVisualStyleBackColor = true;
            // 
            // ckBGN
            // 
            this.ckBGN.AutoSize = true;
            this.ckBGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBGN.Location = new System.Drawing.Point(283, 28);
            this.ckBGN.Name = "ckBGN";
            this.ckBGN.Size = new System.Drawing.Size(40, 19);
            this.ckBGN.TabIndex = 47;
            this.ckBGN.Text = "gn";
            this.ckBGN.UseVisualStyleBackColor = true;
            // 
            // ckBFMB
            // 
            this.ckBFMB.AutoSize = true;
            this.ckBFMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBFMB.Location = new System.Drawing.Point(75, 28);
            this.ckBFMB.Name = "ckBFMB";
            this.ckBFMB.Size = new System.Drawing.Size(47, 19);
            this.ckBFMB.TabIndex = 48;
            this.ckBFMB.Text = "fmb";
            this.ckBFMB.UseVisualStyleBackColor = true;
            // 
            // ckB4SIA
            // 
            this.ckB4SIA.AutoSize = true;
            this.ckB4SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB4SIA.Location = new System.Drawing.Point(75, 51);
            this.ckB4SIA.Name = "ckB4SIA";
            this.ckB4SIA.Size = new System.Drawing.Size(49, 19);
            this.ckB4SIA.TabIndex = 49;
            this.ckB4SIA.Text = "4sia";
            this.ckB4SIA.UseVisualStyleBackColor = true;
            // 
            // ckBAH2410
            // 
            this.ckBAH2410.AutoSize = true;
            this.ckBAH2410.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBAH2410.Location = new System.Drawing.Point(209, 28);
            this.ckBAH2410.Name = "ckBAH2410";
            this.ckBAH2410.Size = new System.Drawing.Size(68, 19);
            this.ckBAH2410.TabIndex = 50;
            this.ckBAH2410.Text = "ah2410";
            this.ckBAH2410.UseVisualStyleBackColor = true;
            // 
            // ckB3VG
            // 
            this.ckB3VG.AutoSize = true;
            this.ckB3VG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB3VG.Location = new System.Drawing.Point(209, 51);
            this.ckB3VG.Name = "ckB3VG";
            this.ckB3VG.Size = new System.Drawing.Size(45, 19);
            this.ckB3VG.TabIndex = 51;
            this.ckB3VG.Text = "3vg";
            this.ckB3VG.UseVisualStyleBackColor = true;
            // 
            // ckBIP
            // 
            this.ckBIP.AutoSize = true;
            this.ckBIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBIP.Location = new System.Drawing.Point(329, 28);
            this.ckBIP.Name = "ckBIP";
            this.ckBIP.Size = new System.Drawing.Size(37, 19);
            this.ckBIP.TabIndex = 52;
            this.ckBIP.Text = "IP";
            this.ckBIP.UseVisualStyleBackColor = true;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(143, 67);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(78, 20);
            this.txtHoursWorked.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Expected Hours:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Size:";
            // 
            // txtBinSize
            // 
            this.txtBinSize.Location = new System.Drawing.Point(70, 44);
            this.txtBinSize.Name = "txtBinSize";
            this.txtBinSize.Size = new System.Drawing.Size(151, 20);
            this.txtBinSize.TabIndex = 64;
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Location = new System.Drawing.Point(772, 63);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(200, 23);
            this.btnCompleteSale.TabIndex = 68;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dgvCurrentSale);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpPromiseDate);
            this.Controls.Add(this.txtSalesOrder);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewSale";
            this.Size = new System.Drawing.Size(984, 582);
            this.Load += new System.EventHandler(this.New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentSale)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPromiseDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesOrder;
        private System.Windows.Forms.DataGridView dgvCurrentSale;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckBPH;
        private System.Windows.Forms.CheckBox chBSK;
        private System.Windows.Forms.CheckBox chBMW;
        private System.Windows.Forms.CheckBox ckBLA;
        private System.Windows.Forms.CheckBox ckBAR7000;
        private System.Windows.Forms.CheckBox ckBAR8000;
        private System.Windows.Forms.CheckBox ckBGN;
        private System.Windows.Forms.CheckBox ckBFMB;
        private System.Windows.Forms.CheckBox ckB4SIA;
        private System.Windows.Forms.CheckBox ckBAH2410;
        private System.Windows.Forms.CheckBox ckB3VG;
        private System.Windows.Forms.CheckBox ckBIP;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBinSize;
        private System.Windows.Forms.Button btnCompleteSale;
    }
}
