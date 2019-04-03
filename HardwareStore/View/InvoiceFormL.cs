using HardwareStore.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStore.View
{
    public partial class InvoiceFormL : Form
    {
        List<CartItem> cartItems;

        public InvoiceFormL()
        {
            InitializeComponent();
            this.cartItems = new List<CartItem>();//{ new CartItem("1", "12"), new CartItem("2", "13") 
            DesignConfigurator();
            
        }
         
       
        private void NextItemBut_Click(object sender, EventArgs e)
        {
            CartItem Item = this.cartItems.FirstOrDefault(a => a.Barcode == this.ScanBarcodeTxtBox.Text);
            if (Item != null) 
            {
                this.cartItems.Find(a => a.Barcode == this.ScanBarcodeTxtBox.Text).
                    Quantity += int.Parse(this.QuantityTxtBox.Text);

                this.cartItems.Find(a => a.Barcode == this.ScanBarcodeTxtBox.Text).
                    Total += int.Parse(this.QuantityTxtBox.Text)*Item.SinglePrice;
            }
            else
            {
                this.cartItems.Add(new CartItem(this.ScanBarcodeTxtBox.Text, this.QuantityTxtBox.Text));
            }
            this.ItemsDataGrid.DataSource = this.cartItems.ToList();

        }



        private void DesignConfigurator()
        {
            ItemsDataGrid.BorderStyle = BorderStyle.None;
            ItemsDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ItemsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsDataGrid.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
            ItemsDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ItemsDataGrid.BackgroundColor = Color.White;
            ItemsDataGrid.EnableHeadersVisualStyles = false;
            ItemsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemsDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ItemsDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ItemsDataGrid.ReadOnly = true;
            ItemsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsDataGrid.Font = new Font("Arial",16);
        }
    }
   
}
