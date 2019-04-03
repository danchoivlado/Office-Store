namespace HardwareStore.View
{
    partial class InvoiceFormL
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
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.ScanBarcodeLbl = new System.Windows.Forms.Label();
            this.ScanBarcodeTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.QuantityTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.NextItemBut = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Location = new System.Drawing.Point(25, 194);
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.RowHeadersWidth = 50;
            this.ItemsDataGrid.RowTemplate.Height = 24;
            this.ItemsDataGrid.Size = new System.Drawing.Size(648, 681);
            this.ItemsDataGrid.TabIndex = 0;
            // 
            // ScanBarcodeLbl
            // 
            this.ScanBarcodeLbl.AutoSize = true;
            this.ScanBarcodeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ScanBarcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanBarcodeLbl.ForeColor = System.Drawing.Color.White;
            this.ScanBarcodeLbl.Location = new System.Drawing.Point(18, 67);
            this.ScanBarcodeLbl.Name = "ScanBarcodeLbl";
            this.ScanBarcodeLbl.Size = new System.Drawing.Size(231, 39);
            this.ScanBarcodeLbl.TabIndex = 2;
            this.ScanBarcodeLbl.Text = "Scan Barcode";
            // 
            // ScanBarcodeTxtBox
            // 
            this.ScanBarcodeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ScanBarcodeTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.ScanBarcodeTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.ScanBarcodeTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.ScanBarcodeTxtBox.BorderThickness = 3;
            this.ScanBarcodeTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScanBarcodeTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.ScanBarcodeTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.ScanBarcodeTxtBox.isPassword = false;
            this.ScanBarcodeTxtBox.Location = new System.Drawing.Point(25, 110);
            this.ScanBarcodeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScanBarcodeTxtBox.Name = "ScanBarcodeTxtBox";
            this.ScanBarcodeTxtBox.Size = new System.Drawing.Size(297, 44);
            this.ScanBarcodeTxtBox.TabIndex = 29;
            this.ScanBarcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.QuantityTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.QuantityTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.QuantityTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.QuantityTxtBox.BorderThickness = 3;
            this.QuantityTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.QuantityTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.QuantityTxtBox.isPassword = false;
            this.QuantityTxtBox.Location = new System.Drawing.Point(344, 110);
            this.QuantityTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(178, 44);
            this.QuantityTxtBox.TabIndex = 31;
            this.QuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.ForeColor = System.Drawing.Color.White;
            this.QuantityLbl.Location = new System.Drawing.Point(337, 67);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(143, 39);
            this.QuantityLbl.TabIndex = 30;
            this.QuantityLbl.Text = "Quantity";
            // 
            // NextItemBut
            // 
            this.NextItemBut.BorderColor = System.Drawing.Color.Silver;
            this.NextItemBut.ButtonColor = System.Drawing.Color.SeaGreen;
            this.NextItemBut.FlatAppearance.BorderSize = 0;
            this.NextItemBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.NextItemBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.NextItemBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextItemBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextItemBut.Location = new System.Drawing.Point(540, 91);
            this.NextItemBut.Name = "NextItemBut";
            this.NextItemBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NextItemBut.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.NextItemBut.OnHoverTextColor = System.Drawing.Color.White;
            this.NextItemBut.Size = new System.Drawing.Size(133, 63);
            this.NextItemBut.TabIndex = 34;
            this.NextItemBut.Text = "Next Item";
            this.NextItemBut.TextColor = System.Drawing.Color.White;
            this.NextItemBut.UseVisualStyleBackColor = true;
            this.NextItemBut.Click += new System.EventHandler(this.NextItemBut_Click);
            // 
            // InvoiceFormL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1282, 903);
            this.Controls.Add(this.NextItemBut);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ScanBarcodeTxtBox);
            this.Controls.Add(this.ScanBarcodeLbl);
            this.Controls.Add(this.ItemsDataGrid);
            this.Name = "InvoiceFormL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceFormL";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGrid;
        private System.Windows.Forms.Label ScanBarcodeLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox ScanBarcodeTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox QuantityTxtBox;
        private System.Windows.Forms.Label QuantityLbl;
        private ePOSOne.btnProduct.Button_WOC NextItemBut;
    }
}