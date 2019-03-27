namespace HardwareStore.View
{
    partial class NewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.ProductNameTxtBox = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.SalesPriceTxtBox = new System.Windows.Forms.TextBox();
            this.SalesPriceLbl = new System.Windows.Forms.Label();
            this.OriginalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.OriginalPriceLbl = new System.Windows.Forms.Label();
            this.CreateBut = new System.Windows.Forms.Button();
            this.SecondHandCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.Location = new System.Drawing.Point(24, 236);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(123, 33);
            this.BarcodeLbl.TabIndex = 1;
            this.BarcodeLbl.Text = "Barcode";
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.Location = new System.Drawing.Point(168, 236);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(277, 36);
            this.BarcodeTxtBox.TabIndex = 2;
            this.BarcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeTxtBox_KeyDown);
            // 
            // ProductNameTxtBox
            // 
            this.ProductNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxtBox.Location = new System.Drawing.Point(252, 303);
            this.ProductNameTxtBox.Name = "ProductNameTxtBox";
            this.ProductNameTxtBox.Size = new System.Drawing.Size(193, 36);
            this.ProductNameTxtBox.TabIndex = 4;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLbl.Location = new System.Drawing.Point(24, 306);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(201, 33);
            this.ProductNameLbl.TabIndex = 3;
            this.ProductNameLbl.Text = "Product Name";
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxtBox.Location = new System.Drawing.Point(712, 379);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(82, 36);
            this.QuantityTxtBox.TabIndex = 14;
            this.QuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(503, 382);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(124, 33);
            this.QuantityLbl.TabIndex = 13;
            this.QuantityLbl.Text = "Quantity";
            // 
            // SalesPriceTxtBox
            // 
            this.SalesPriceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPriceTxtBox.Location = new System.Drawing.Point(712, 306);
            this.SalesPriceTxtBox.Name = "SalesPriceTxtBox";
            this.SalesPriceTxtBox.Size = new System.Drawing.Size(82, 36);
            this.SalesPriceTxtBox.TabIndex = 12;
            this.SalesPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesPriceLbl
            // 
            this.SalesPriceLbl.AutoSize = true;
            this.SalesPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPriceLbl.Location = new System.Drawing.Point(503, 309);
            this.SalesPriceLbl.Name = "SalesPriceLbl";
            this.SalesPriceLbl.Size = new System.Drawing.Size(163, 33);
            this.SalesPriceLbl.TabIndex = 11;
            this.SalesPriceLbl.Text = "Sales Price";
            // 
            // OriginalPriceTxtBox
            // 
            this.OriginalPriceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPriceTxtBox.Location = new System.Drawing.Point(712, 233);
            this.OriginalPriceTxtBox.Name = "OriginalPriceTxtBox";
            this.OriginalPriceTxtBox.Size = new System.Drawing.Size(82, 36);
            this.OriginalPriceTxtBox.TabIndex = 10;
            this.OriginalPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OriginalPriceLbl
            // 
            this.OriginalPriceLbl.AutoSize = true;
            this.OriginalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPriceLbl.Location = new System.Drawing.Point(503, 236);
            this.OriginalPriceLbl.Name = "OriginalPriceLbl";
            this.OriginalPriceLbl.Size = new System.Drawing.Size(192, 33);
            this.OriginalPriceLbl.TabIndex = 9;
            this.OriginalPriceLbl.Text = "Original Price";
            // 
            // CreateBut
            // 
            this.CreateBut.BackColor = System.Drawing.Color.YellowGreen;
            this.CreateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBut.Location = new System.Drawing.Point(319, 474);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(248, 64);
            this.CreateBut.TabIndex = 15;
            this.CreateBut.Text = "Create";
            this.CreateBut.UseVisualStyleBackColor = false;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // SecondHandCheckBox
            // 
            this.SecondHandCheckBox.AutoSize = true;
            this.SecondHandCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondHandCheckBox.Location = new System.Drawing.Point(99, 378);
            this.SecondHandCheckBox.Name = "SecondHandCheckBox";
            this.SecondHandCheckBox.Size = new System.Drawing.Size(212, 37);
            this.SecondHandCheckBox.TabIndex = 16;
            this.SecondHandCheckBox.Text = "Second Hand";
            this.SecondHandCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.SecondHandCheckBox);
            this.Controls.Add(this.CreateBut);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.SalesPriceTxtBox);
            this.Controls.Add(this.SalesPriceLbl);
            this.Controls.Add(this.OriginalPriceTxtBox);
            this.Controls.Add(this.OriginalPriceLbl);
            this.Controls.Add(this.ProductNameTxtBox);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.BarcodeTxtBox);
            this.Controls.Add(this.BarcodeLbl);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "NewItemForm";
            this.Text = "New Item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.TextBox ProductNameTxtBox;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.TextBox QuantityTxtBox;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.TextBox SalesPriceTxtBox;
        private System.Windows.Forms.Label SalesPriceLbl;
        private System.Windows.Forms.TextBox OriginalPriceTxtBox;
        private System.Windows.Forms.Label OriginalPriceLbl;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.CheckBox SecondHandCheckBox;
    }
}