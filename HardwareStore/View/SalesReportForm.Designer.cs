namespace HardwareStore.View
{
    partial class SalesReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SalesReportDataGrid = new System.Windows.Forms.DataGridView();
            this.GrantTotalLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesReportDataGrid
            // 
            this.SalesReportDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesReportDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalesReportDataGrid.Location = new System.Drawing.Point(11, 153);
            this.SalesReportDataGrid.Name = "SalesReportDataGrid";
            this.SalesReportDataGrid.RowTemplate.Height = 24;
            this.SalesReportDataGrid.Size = new System.Drawing.Size(1071, 276);
            this.SalesReportDataGrid.TabIndex = 0;
            // 
            // GrantTotalLbl
            // 
            this.GrantTotalLbl.AutoSize = true;
            this.GrantTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrantTotalLbl.Location = new System.Drawing.Point(12, 452);
            this.GrantTotalLbl.Name = "GrantTotalLbl";
            this.GrantTotalLbl.Size = new System.Drawing.Size(169, 33);
            this.GrantTotalLbl.TabIndex = 1;
            this.GrantTotalLbl.Text = "Grand Total";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(884, 452);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(0, 33);
            this.TotalLbl.TabIndex = 2;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 508);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.GrantTotalLbl);
            this.Controls.Add(this.SalesReportDataGrid);
            this.MaximizeBox = false;
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesReportDataGrid;
        private System.Windows.Forms.Label GrantTotalLbl;
        private System.Windows.Forms.Label TotalLbl;
    }
}