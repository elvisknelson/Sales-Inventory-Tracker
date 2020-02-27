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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaleDetails
            // 
            this.dgvSaleDetails.AllowUserToAddRows = false;
            this.dgvSaleDetails.AllowUserToDeleteRows = false;
            this.dgvSaleDetails.AllowUserToOrderColumns = true;
            this.dgvSaleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.Size = new System.Drawing.Size(614, 317);
            this.dgvSaleDetails.TabIndex = 0;
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 317);
            this.Controls.Add(this.dgvSaleDetails);
            this.Name = "SaleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Details";
            this.Load += new System.EventHandler(this.BinDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaleDetails;
    }
}