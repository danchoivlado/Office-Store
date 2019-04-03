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
        MainFrom MainFrom;

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
            this.CustomerInfoTxtList.Items.Add($"Grand Total                    {cartItems.Sum(a => a.Total):f2}");
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
                    Total += int.Parse(this.QuantityTxtBox.Text) * Item.SinglePrice;

                UpdateTextbox(Item);

            }
            else
            {
                CartItem Item2 = new CartItem(this.ScanBarcodeTxtBox.Text, this.QuantityTxtBox.Text);
                this.cartItems.Add(Item2);

                UpdateTextbox(Item2);
            }
            this.ItemsDataGrid.DataSource = this.cartItems.ToList();
            ItemsDataGrid.Columns[2].Width = 185;
        }

        private void UpdateTextbox(CartItem Item)
        {
            this.CustomerInfoTxtList.Items[0] = $"Item Single Price           {Item.SinglePrice:f2}";
            this.CustomerInfoTxtList.Items[1] = $"Item Quantity                {Item.Quantity}";
            this.CustomerInfoTxtList.Items[2] = $"Item Total                      {Item.Total:f2}";
            this.CustomerInfoTxtList.Items[4] = $"Grand Total                    {cartItems.Sum(a => a.Total):f2}";
        }




        private void DesignConfigurator()
        {
            ItemsDataGrid.BorderStyle = BorderStyle.None;
            ItemsDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ItemsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsDataGrid.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
            ItemsDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //  ItemsDataGrid.BackgroundColor = new Color(;
            ItemsDataGrid.EnableHeadersVisualStyles = false;
            ItemsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemsDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ItemsDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ItemsDataGrid.ReadOnly = true;
            ItemsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsDataGrid.Font = new Font("Arial", 20);
            ItemsDataGrid.RowTemplate.Height = 50;
        }

        private void PayBut_Click(object sender, EventArgs e)
        {
            this.InvoiceForm = new InvoiceForm(this.cartItems);
            this.InvoiceForm.ShowDialog();
        }

        private void DeleteItemBut_Click(object sender, EventArgs e)
        {
            var Item = ItemsDataGrid.SelectedRows[0].Cells;
            var Barcode = Item[0].Value.ToString();
            CartItem DeletedItem = this.cartItems.First(a => a.Barcode == Barcode);
            this.cartItems.Remove(DeletedItem);
            this.ItemsDataGrid.DataSource = this.cartItems.ToList();


            UpdateTextbox(new CartItem());
        }

        private void ChangeQuantityBut_Click(object sender, EventArgs e)
        {
            var Item = ItemsDataGrid.SelectedRows[0].Cells;
            var Barcode = Item[0].Value.ToString();
            CartItem DeletedItem = this.cartItems.First(a => a.Barcode == Barcode);
            DeletedItem.QuantityMinus();
            this.ItemsDataGrid.DataSource = this.cartItems.ToList();
            this.ItemsDataGrid.Rows[0].Selected = false;

            UpdateTextbox(DeletedItem);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.MainFrom = new MainFrom();
            this.Hide();
            this.MainFrom.ShowDialog();
            this.Close();
        }
    }

}
