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
        InvoiceForm InvoiceForm;

        public InvoiceFormL()
        {
            InitializeComponent();
            this.cartItems = new List<CartItem>();//{ new CartItem("1", "12"), new CartItem("2", "13") 
            DesignConfigurator();
            GenrateCustomerInfoListBox();
        }

        private void GenrateCustomerInfoListBox()
        {
            this.CustomerInfoTxtList.Items.Add($"Item Single Price           {0:f2}");
            this.CustomerInfoTxtList.Items.Add($"Item Quantity                {0}");
            this.CustomerInfoTxtList.Items.Add($"Item Total                      {0:f2}");
            this.CustomerInfoTxtList.Items.Add("");
            this.CustomerInfoTxtList.Items.Add($"Grand Total                    {0:f2}");
            this.CustomerInfoTxtList.SelectionMode = SelectionMode.None;
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

                this.CustomerInfoTxtList.Items[0]=$"Item Single Price           {Item.SinglePrice:f2}";
                this.CustomerInfoTxtList.Items[1]=$"Item Quantity                {Item.Quantity}";
                this.CustomerInfoTxtList.Items[2] =$"Item Total                      {Item.Total:f2}";
            }
            else
            {
                CartItem Item2 = new CartItem(this.ScanBarcodeTxtBox.Text, this.QuantityTxtBox.Text);
                this.cartItems.Add(Item2);
                this.CustomerInfoTxtList.Items[0]=$"Item Single Price           {Item2.SinglePrice:f2}";
                this.CustomerInfoTxtList.Items[1]=$"Item Quantity                {Item2.Quantity}";
                this.CustomerInfoTxtList.Items[2]=$"Item Total                      {Item2.Total:f2}";
            }
            this.CustomerInfoTxtList.Items[4] =$"Grand Total                    {cartItems.Sum(a=>a.Total):f2}";
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

        private void PayBut_Click(object sender, EventArgs e)
        {
            this.InvoiceForm = new InvoiceForm(this.cartItems);
            this.InvoiceForm.ShowDialog();
        }
    }
   
}
