namespace HardwareStore.View
{
    partial class Store_Info
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
            this.StoreAddressTxtBox = new System.Windows.Forms.TextBox();
            this.StoreAdreesLbl = new System.Windows.Forms.Label();
            this.StoreNameTxtBox = new System.Windows.Forms.TextBox();
            this.StoreNameLbl = new System.Windows.Forms.Label();
            this.SaveBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StoreAddressTxtBox
            // 
            this.StoreAddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAddressTxtBox.Location = new System.Drawing.Point(281, 85);
            this.StoreAddressTxtBox.Name = "StoreAddressTxtBox";
            this.StoreAddressTxtBox.Size = new System.Drawing.Size(218, 36);
            this.StoreAddressTxtBox.TabIndex = 16;
            // 
            // StoreAdreesLbl
            // 
            this.StoreAdreesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAdreesLbl.Location = new System.Drawing.Point(19, 89);
            this.StoreAdreesLbl.Name = "StoreAdreesLbl";
            this.StoreAdreesLbl.Size = new System.Drawing.Size(190, 32);
            this.StoreAdreesLbl.TabIndex = 15;
            this.StoreAdreesLbl.Text = "Store Address";
            // 
            // StoreNameTxtBox
            // 
            this.StoreNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNameTxtBox.Location = new System.Drawing.Point(281, 25);
            this.StoreNameTxtBox.Name = "StoreNameTxtBox";
            this.StoreNameTxtBox.Size = new System.Drawing.Size(218, 36);
            this.StoreNameTxtBox.TabIndex = 14;
            // 
            // StoreNameLbl
            // 
            this.StoreNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNameLbl.Location = new System.Drawing.Point(19, 29);
            this.StoreNameLbl.Name = "StoreNameLbl";
            this.StoreNameLbl.Size = new System.Drawing.Size(155, 32);
            this.StoreNameLbl.TabIndex = 13;
            this.StoreNameLbl.Text = "Store Name";
            // 
            // SaveBut
            // 
            this.SaveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.Location = new System.Drawing.Point(170, 167);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(162, 50);
            this.SaveBut.TabIndex = 17;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // Store_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 243);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.StoreAddressTxtBox);
            this.Controls.Add(this.StoreAdreesLbl);
            this.Controls.Add(this.StoreNameTxtBox);
            this.Controls.Add(this.StoreNameLbl);
            this.Name = "Store_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StoreAddressTxtBox;
        private System.Windows.Forms.Label StoreAdreesLbl;
        private System.Windows.Forms.TextBox StoreNameTxtBox;
        private System.Windows.Forms.Label StoreNameLbl;
        private System.Windows.Forms.Button SaveBut;
    }
}