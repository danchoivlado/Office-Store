namespace HardwareStore.View
{
    partial class MainForm
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
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ShowReceiptBut = new System.Windows.Forms.Button();
            this.PrintReceiptBut = new System.Windows.Forms.Button();
            this.ResetReceiptBut = new System.Windows.Forms.Button();
            this.OneBut = new System.Windows.Forms.Button();
            this.TwoBut = new System.Windows.Forms.Button();
            this.ThreeBut = new System.Windows.Forms.Button();
            this.SixBut = new System.Windows.Forms.Button();
            this.FiveBut = new System.Windows.Forms.Button();
            this.FourBut = new System.Windows.Forms.Button();
            this.NineBut = new System.Windows.Forms.Button();
            this.EightBut = new System.Windows.Forms.Button();
            this.SevenBut = new System.Windows.Forms.Button();
            this.DoubleZeroBut = new System.Windows.Forms.Button();
            this.ComaBut = new System.Windows.Forms.Button();
            this.ZeroBut = new System.Windows.Forms.Button();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.DiscountBut = new System.Windows.Forms.Button();
            this.NextItemBut = new System.Windows.Forms.Button();
            this.EndTransactionBut = new System.Windows.Forms.Button();
            this.PlusBut = new System.Windows.Forms.Button();
            this.DeleteNumberBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.Location = new System.Drawing.Point(12, 12);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(254, 36);
            this.BarcodeTxtBox.TabIndex = 0;
            this.BarcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BarcodeTxtBox_MouseClick);
            this.BarcodeTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeTxtBox_KeyDown);
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxtBox.Location = new System.Drawing.Point(199, 64);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(67, 36);
            this.QuantityTxtBox.TabIndex = 1;
            this.QuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QuantityTxtBox_MouseClick);
            this.QuantityTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityTxtBox_KeyDown);
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(12, 64);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(133, 36);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity ";
            // 
            // ShowReceiptBut
            // 
            this.ShowReceiptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReceiptBut.Location = new System.Drawing.Point(12, 239);
            this.ShowReceiptBut.Name = "ShowReceiptBut";
            this.ShowReceiptBut.Size = new System.Drawing.Size(254, 37);
            this.ShowReceiptBut.TabIndex = 3;
            this.ShowReceiptBut.Text = "Show Receipt";
            this.ShowReceiptBut.UseVisualStyleBackColor = true;
            this.ShowReceiptBut.Click += new System.EventHandler(this.ShowReceiptBut_Click);
            // 
            // PrintReceiptBut
            // 
            this.PrintReceiptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptBut.Location = new System.Drawing.Point(12, 292);
            this.PrintReceiptBut.Name = "PrintReceiptBut";
            this.PrintReceiptBut.Size = new System.Drawing.Size(254, 34);
            this.PrintReceiptBut.TabIndex = 4;
            this.PrintReceiptBut.Text = "Print Receipt";
            this.PrintReceiptBut.UseVisualStyleBackColor = true;
            // 
            // ResetReceiptBut
            // 
            this.ResetReceiptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetReceiptBut.ForeColor = System.Drawing.Color.Red;
            this.ResetReceiptBut.Location = new System.Drawing.Point(12, 144);
            this.ResetReceiptBut.Name = "ResetReceiptBut";
            this.ResetReceiptBut.Size = new System.Drawing.Size(254, 34);
            this.ResetReceiptBut.TabIndex = 6;
            this.ResetReceiptBut.Text = "Reset Receipt";
            this.ResetReceiptBut.UseVisualStyleBackColor = true;
            // 
            // OneBut
            // 
            this.OneBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OneBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBut.Location = new System.Drawing.Point(287, 209);
            this.OneBut.Name = "OneBut";
            this.OneBut.Size = new System.Drawing.Size(79, 55);
            this.OneBut.TabIndex = 7;
            this.OneBut.Text = "1";
            this.OneBut.UseVisualStyleBackColor = false;
            this.OneBut.Click += new System.EventHandler(this.OneBut_Click);
            // 
            // TwoBut
            // 
            this.TwoBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TwoBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoBut.Location = new System.Drawing.Point(383, 209);
            this.TwoBut.Name = "TwoBut";
            this.TwoBut.Size = new System.Drawing.Size(79, 55);
            this.TwoBut.TabIndex = 8;
            this.TwoBut.Text = "2";
            this.TwoBut.UseVisualStyleBackColor = false;
            this.TwoBut.Click += new System.EventHandler(this.TwoBut_Click);
            // 
            // ThreeBut
            // 
            this.ThreeBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThreeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeBut.Location = new System.Drawing.Point(479, 209);
            this.ThreeBut.Name = "ThreeBut";
            this.ThreeBut.Size = new System.Drawing.Size(79, 55);
            this.ThreeBut.TabIndex = 9;
            this.ThreeBut.Text = "3";
            this.ThreeBut.UseVisualStyleBackColor = false;
            this.ThreeBut.Click += new System.EventHandler(this.ThreeBut_Click);
            // 
            // SixBut
            // 
            this.SixBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SixBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixBut.Location = new System.Drawing.Point(479, 135);
            this.SixBut.Name = "SixBut";
            this.SixBut.Size = new System.Drawing.Size(79, 55);
            this.SixBut.TabIndex = 12;
            this.SixBut.Text = "6";
            this.SixBut.UseVisualStyleBackColor = false;
            this.SixBut.Click += new System.EventHandler(this.SixBut_Click);
            // 
            // FiveBut
            // 
            this.FiveBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FiveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveBut.Location = new System.Drawing.Point(383, 135);
            this.FiveBut.Name = "FiveBut";
            this.FiveBut.Size = new System.Drawing.Size(79, 55);
            this.FiveBut.TabIndex = 11;
            this.FiveBut.Text = "5";
            this.FiveBut.UseVisualStyleBackColor = false;
            this.FiveBut.Click += new System.EventHandler(this.FiveBut_Click);
            // 
            // FourBut
            // 
            this.FourBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FourBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourBut.Location = new System.Drawing.Point(287, 135);
            this.FourBut.Name = "FourBut";
            this.FourBut.Size = new System.Drawing.Size(79, 55);
            this.FourBut.TabIndex = 10;
            this.FourBut.Text = "4";
            this.FourBut.UseVisualStyleBackColor = false;
            this.FourBut.Click += new System.EventHandler(this.FourBut_Click);
            // 
            // NineBut
            // 
            this.NineBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NineBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineBut.Location = new System.Drawing.Point(479, 61);
            this.NineBut.Name = "NineBut";
            this.NineBut.Size = new System.Drawing.Size(79, 55);
            this.NineBut.TabIndex = 15;
            this.NineBut.Text = "9";
            this.NineBut.UseVisualStyleBackColor = false;
            this.NineBut.Click += new System.EventHandler(this.NineBut_Click);
            // 
            // EightBut
            // 
            this.EightBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EightBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightBut.Location = new System.Drawing.Point(383, 61);
            this.EightBut.Name = "EightBut";
            this.EightBut.Size = new System.Drawing.Size(79, 55);
            this.EightBut.TabIndex = 14;
            this.EightBut.Text = "8";
            this.EightBut.UseVisualStyleBackColor = false;
            this.EightBut.Click += new System.EventHandler(this.EightBut_Click);
            // 
            // SevenBut
            // 
            this.SevenBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SevenBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenBut.Location = new System.Drawing.Point(287, 61);
            this.SevenBut.Name = "SevenBut";
            this.SevenBut.Size = new System.Drawing.Size(79, 55);
            this.SevenBut.TabIndex = 13;
            this.SevenBut.Text = "7";
            this.SevenBut.UseVisualStyleBackColor = false;
            this.SevenBut.Click += new System.EventHandler(this.SevenBut_Click);
            // 
            // DoubleZeroBut
            // 
            this.DoubleZeroBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DoubleZeroBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleZeroBut.Location = new System.Drawing.Point(287, 278);
            this.DoubleZeroBut.Name = "DoubleZeroBut";
            this.DoubleZeroBut.Size = new System.Drawing.Size(125, 55);
            this.DoubleZeroBut.TabIndex = 16;
            this.DoubleZeroBut.Text = "00";
            this.DoubleZeroBut.UseVisualStyleBackColor = false;
            this.DoubleZeroBut.Click += new System.EventHandler(this.DoubleZeroBut_Click);
            // 
            // ComaBut
            // 
            this.ComaBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ComaBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComaBut.Location = new System.Drawing.Point(418, 278);
            this.ComaBut.Name = "ComaBut";
            this.ComaBut.Size = new System.Drawing.Size(44, 55);
            this.ComaBut.TabIndex = 17;
            this.ComaBut.Text = ".";
            this.ComaBut.UseVisualStyleBackColor = false;
            this.ComaBut.Click += new System.EventHandler(this.ComaBut_Click);
            // 
            // ZeroBut
            // 
            this.ZeroBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ZeroBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBut.Location = new System.Drawing.Point(479, 278);
            this.ZeroBut.Name = "ZeroBut";
            this.ZeroBut.Size = new System.Drawing.Size(79, 55);
            this.ZeroBut.TabIndex = 18;
            this.ZeroBut.Text = "0";
            this.ZeroBut.UseVisualStyleBackColor = false;
            this.ZeroBut.Click += new System.EventHandler(this.ZeroBut_Click);
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.Enabled = false;
            this.TotalTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.Location = new System.Drawing.Point(323, 12);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.Size = new System.Drawing.Size(196, 36);
            this.TotalTxtBox.TabIndex = 19;
            this.TotalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscountBut
            // 
            this.DiscountBut.BackColor = System.Drawing.Color.Gold;
            this.DiscountBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBut.Location = new System.Drawing.Point(578, 12);
            this.DiscountBut.Name = "DiscountBut";
            this.DiscountBut.Size = new System.Drawing.Size(207, 53);
            this.DiscountBut.TabIndex = 20;
            this.DiscountBut.Text = "Use Discount";
            this.DiscountBut.UseVisualStyleBackColor = false;
            // 
            // NextItemBut
            // 
            this.NextItemBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NextItemBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextItemBut.Location = new System.Drawing.Point(578, 83);
            this.NextItemBut.Name = "NextItemBut";
            this.NextItemBut.Size = new System.Drawing.Size(207, 53);
            this.NextItemBut.TabIndex = 21;
            this.NextItemBut.Text = "Next Item";
            this.NextItemBut.UseVisualStyleBackColor = false;
            this.NextItemBut.Click += new System.EventHandler(this.NextItemBut_Click);
            // 
            // EndTransactionBut
            // 
            this.EndTransactionBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EndTransactionBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTransactionBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EndTransactionBut.Location = new System.Drawing.Point(648, 151);
            this.EndTransactionBut.Name = "EndTransactionBut";
            this.EndTransactionBut.Size = new System.Drawing.Size(137, 182);
            this.EndTransactionBut.TabIndex = 22;
            this.EndTransactionBut.Text = "End Transaction";
            this.EndTransactionBut.UseVisualStyleBackColor = false;
            this.EndTransactionBut.Click += new System.EventHandler(this.EndTransactionBut_Click);
            // 
            // PlusBut
            // 
            this.PlusBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBut.Location = new System.Drawing.Point(578, 209);
            this.PlusBut.Name = "PlusBut";
            this.PlusBut.Size = new System.Drawing.Size(64, 127);
            this.PlusBut.TabIndex = 23;
            this.PlusBut.Text = "+";
            this.PlusBut.UseVisualStyleBackColor = true;
            this.PlusBut.Click += new System.EventHandler(this.PlusBut_Click);
            // 
            // DeleteNumberBut
            // 
            this.DeleteNumberBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteNumberBut.Location = new System.Drawing.Point(578, 148);
            this.DeleteNumberBut.Name = "DeleteNumberBut";
            this.DeleteNumberBut.Size = new System.Drawing.Size(64, 54);
            this.DeleteNumberBut.TabIndex = 24;
            this.DeleteNumberBut.Text = "C";
            this.DeleteNumberBut.UseVisualStyleBackColor = true;
            this.DeleteNumberBut.Click += new System.EventHandler(this.DeleteNumberBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 348);
            this.Controls.Add(this.DeleteNumberBut);
            this.Controls.Add(this.PlusBut);
            this.Controls.Add(this.EndTransactionBut);
            this.Controls.Add(this.NextItemBut);
            this.Controls.Add(this.DiscountBut);
            this.Controls.Add(this.TotalTxtBox);
            this.Controls.Add(this.ZeroBut);
            this.Controls.Add(this.ComaBut);
            this.Controls.Add(this.DoubleZeroBut);
            this.Controls.Add(this.NineBut);
            this.Controls.Add(this.EightBut);
            this.Controls.Add(this.SevenBut);
            this.Controls.Add(this.SixBut);
            this.Controls.Add(this.FiveBut);
            this.Controls.Add(this.FourBut);
            this.Controls.Add(this.ThreeBut);
            this.Controls.Add(this.TwoBut);
            this.Controls.Add(this.OneBut);
            this.Controls.Add(this.ResetReceiptBut);
            this.Controls.Add(this.PrintReceiptBut);
            this.Controls.Add(this.ShowReceiptBut);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.BarcodeTxtBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.TextBox QuantityTxtBox;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button ShowReceiptBut;
        private System.Windows.Forms.Button PrintReceiptBut;
        private System.Windows.Forms.Button ResetReceiptBut;
        private System.Windows.Forms.Button OneBut;
        private System.Windows.Forms.Button TwoBut;
        private System.Windows.Forms.Button ThreeBut;
        private System.Windows.Forms.Button SixBut;
        private System.Windows.Forms.Button FiveBut;
        private System.Windows.Forms.Button FourBut;
        private System.Windows.Forms.Button NineBut;
        private System.Windows.Forms.Button EightBut;
        private System.Windows.Forms.Button SevenBut;
        private System.Windows.Forms.Button DoubleZeroBut;
        private System.Windows.Forms.Button ComaBut;
        private System.Windows.Forms.Button ZeroBut;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.Button DiscountBut;
        private System.Windows.Forms.Button NextItemBut;
        private System.Windows.Forms.Button EndTransactionBut;
        private System.Windows.Forms.Button PlusBut;
        private System.Windows.Forms.Button DeleteNumberBut;
    }
}