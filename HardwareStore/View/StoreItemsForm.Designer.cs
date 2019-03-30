namespace HardwareStore.View
{
    partial class StoreItemsForm
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
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBut = new ePOSOne.btnProduct.Button_WOC();
            this.UpdateBut = new ePOSOne.btnProduct.Button_WOC();
            this.CreateBut = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsGridView.Location = new System.Drawing.Point(27, 37);
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(925, 273);
            this.ItemsGridView.TabIndex = 0;
            // 
            // DeleteBut
            // 
            this.DeleteBut.BorderColor = System.Drawing.Color.Silver;
            this.DeleteBut.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.DeleteBut.FlatAppearance.BorderSize = 0;
            this.DeleteBut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteBut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBut.Location = new System.Drawing.Point(707, 409);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteBut.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.DeleteBut.OnHoverTextColor = System.Drawing.Color.SandyBrown;
            this.DeleteBut.Size = new System.Drawing.Size(245, 80);
            this.DeleteBut.TabIndex = 3;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.TextColor = System.Drawing.Color.White;
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.BorderColor = System.Drawing.Color.Silver;
            this.UpdateBut.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBut.FlatAppearance.BorderSize = 0;
            this.UpdateBut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UpdateBut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBut.Location = new System.Drawing.Point(367, 409);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateBut.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.UpdateBut.OnHoverTextColor = System.Drawing.Color.SandyBrown;
            this.UpdateBut.Size = new System.Drawing.Size(245, 80);
            this.UpdateBut.TabIndex = 2;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.TextColor = System.Drawing.Color.White;
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // CreateBut
            // 
            this.CreateBut.BorderColor = System.Drawing.Color.Silver;
            this.CreateBut.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.CreateBut.FlatAppearance.BorderSize = 0;
            this.CreateBut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CreateBut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CreateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBut.Location = new System.Drawing.Point(27, 409);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateBut.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.CreateBut.OnHoverTextColor = System.Drawing.Color.SandyBrown;
            this.CreateBut.Size = new System.Drawing.Size(245, 80);
            this.CreateBut.TabIndex = 1;
            this.CreateBut.Text = "Create";
            this.CreateBut.TextColor = System.Drawing.Color.White;
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // StoreItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(983, 516);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.CreateBut);
            this.Controls.Add(this.ItemsGridView);
            this.MaximizeBox = false;
            this.Name = "StoreItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreItemsForm";
            this.Activated += new System.EventHandler(this.StoreItemsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StoreItemsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsGridView;
        private ePOSOne.btnProduct.Button_WOC CreateBut;
        private ePOSOne.btnProduct.Button_WOC UpdateBut;
        private ePOSOne.btnProduct.Button_WOC DeleteBut;
    }
}