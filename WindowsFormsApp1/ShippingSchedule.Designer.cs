namespace ConceptApp
{
    partial class ShippingSchedule
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
            this.dgvShippingSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippingSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShippingSchedule
            // 
            this.dgvShippingSchedule.AllowUserToAddRows = false;
            this.dgvShippingSchedule.AllowUserToDeleteRows = false;
            this.dgvShippingSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShippingSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShippingSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippingSchedule.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvShippingSchedule.Location = new System.Drawing.Point(313, 0);
            this.dgvShippingSchedule.Name = "dgvShippingSchedule";
            this.dgvShippingSchedule.ReadOnly = true;
            this.dgvShippingSchedule.Size = new System.Drawing.Size(866, 537);
            this.dgvShippingSchedule.TabIndex = 0;
            // 
            // ShippingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShippingSchedule);
            this.Name = "ShippingSchedule";
            this.Size = new System.Drawing.Size(1179, 537);
            this.Load += new System.EventHandler(this.ShippingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippingSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShippingSchedule;
    }
}
