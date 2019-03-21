namespace HardwareStore.View
{
    partial class RegisterForm
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
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.RegisterBut = new System.Windows.Forms.Button();
            this.AdminPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.TownTxtBox = new System.Windows.Forms.TextBox();
            this.TownLbl = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(280, 37);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(218, 36);
            this.FirstNameTxtBox.TabIndex = 10;
            this.FirstNameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstNameTxtBox_KeyDown);
            // 
            // RegisterBut
            // 
            this.RegisterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBut.Location = new System.Drawing.Point(181, 363);
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Size = new System.Drawing.Size(170, 50);
            this.RegisterBut.TabIndex = 9;
            this.RegisterBut.Text = "Register";
            this.RegisterBut.UseVisualStyleBackColor = true;
            this.RegisterBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // AdminPasswordTxtBox
            // 
            this.AdminPasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasswordTxtBox.Location = new System.Drawing.Point(280, 281);
            this.AdminPasswordTxtBox.Name = "AdminPasswordTxtBox";
            this.AdminPasswordTxtBox.PasswordChar = '*';
            this.AdminPasswordTxtBox.Size = new System.Drawing.Size(218, 36);
            this.AdminPasswordTxtBox.TabIndex = 8;
            this.AdminPasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminPasswordTxtBox_KeyDown);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(16, 281);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(198, 32);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "AdminPassword";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(18, 41);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(155, 32);
            this.FirstNameLbl.TabIndex = 6;
            this.FirstNameLbl.Text = "First Name";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(18, 101);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(155, 32);
            this.LastNameLbl.TabIndex = 11;
            this.LastNameLbl.Text = "LastName";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxtBox.Location = new System.Drawing.Point(280, 97);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(218, 36);
            this.LastNameTxtBox.TabIndex = 12;
            this.LastNameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LastNameTxtBox_KeyDown);
            // 
            // TownTxtBox
            // 
            this.TownTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownTxtBox.Location = new System.Drawing.Point(280, 157);
            this.TownTxtBox.Name = "TownTxtBox";
            this.TownTxtBox.Size = new System.Drawing.Size(218, 36);
            this.TownTxtBox.TabIndex = 14;
            this.TownTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TownTxtBox_KeyDown);
            // 
            // TownLbl
            // 
            this.TownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownLbl.Location = new System.Drawing.Point(16, 161);
            this.TownLbl.Name = "TownLbl";
            this.TownLbl.Size = new System.Drawing.Size(155, 32);
            this.TownLbl.TabIndex = 13;
            this.TownLbl.Text = "Town";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(280, 221);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(218, 36);
            this.PasswordTxtBox.TabIndex = 16;
            this.PasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxtBox_KeyDown);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(16, 221);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(155, 32);
            this.PasswordLbl.TabIndex = 15;
            this.PasswordLbl.Text = "Password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 453);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.TownTxtBox);
            this.Controls.Add(this.TownLbl);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.RegisterBut);
            this.Controls.Add(this.AdminPasswordTxtBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.FirstNameLbl);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Button RegisterBut;
        private System.Windows.Forms.TextBox AdminPasswordTxtBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox TownTxtBox;
        private System.Windows.Forms.Label TownLbl;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label PasswordLbl;
    }
}