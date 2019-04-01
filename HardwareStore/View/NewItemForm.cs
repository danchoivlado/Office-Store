using HardwareStore.BusinessLogic;
using HardwareStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStore.View
{
    public partial class NewItemForm : Form
    {
        UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
        private string FirsBarcode;
        Items Item;
        StoreItemsForm StoreItemsForm;

        public NewItemForm()
        {
            InitializeComponent();
            this.Item = new Items();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public NewItemForm(Items Item)
        {
            InitializeComponent();
            PasteItemInfo(Item);
            this.FirsBarcode = Item.Id;
            this.Item = new Items();
            this.Item = Item;
            this.BarcodeTxtBox.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void CreateBut_Click_1(object sender, EventArgs e)
        {

            string BarcodeText = this.BarcodeTxtBox.Text;

            if (!this.updateCreateSalesReportBLL.IsItemExists(Item.Id))
            {
                this.updateCreateSalesReportBLL.CreateItem(this.ToClass());
                ClearDataFromTxtBoxes();
            }
            else
            {
                this.updateCreateSalesReportBLL.UpdateItem(ToClass(), Item.Id);
                GenerateForm();
            }
        }

        private void GenerateForm()
        {
            this.StoreItemsForm = new StoreItemsForm();
            this.Hide();
            this.StoreItemsForm.ShowDialog();
            this.Close();
        }

       

        private void BarcodeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = ProductNameTxtBox;
                ProductNameTxtBox.Focus();
            }

        }

       

        private void ClearDataFromTxtBoxes()
        {
            this.BarcodeTxtBox.ResetText();
            this.ProductNameTxtBox.ResetText();
            this.OriginalPriceTxtBox.ResetText();
            this.SalesPriceTxtBox.ResetText();
            this.QuantityTxtBox.ResetText();
            this.SecondHandCheckBox.Checked = false;
        }

        private void PasteItemInfo(Items Item)
        {
            this.BarcodeTxtBox.Text = Item.Id;
            this.ProductNameTxtBox.Text = Item.ProductName;
            this.OriginalPriceTxtBox.Text = Item.OriginalPrice.ToString();
            this.SalesPriceTxtBox.Text = Item.SalesPrice.ToString();
            this.QuantityTxtBox.Text = Item.Quantity.ToString();
            this.SecondHandCheckBox.Checked = this.updateCreateSalesReportBLL.IsChecked(Item.Status);
            this.CreateBut.Text = "Save";
            
        }

        private Items ToClass()
        {
            Items item = new Items()
            {
                Id = this.BarcodeTxtBox.Text,
                ProductName = this.ProductNameTxtBox.Text,
                OriginalPrice = double.Parse(this.OriginalPriceTxtBox.Text),
                SalesPrice = double.Parse(this.SalesPriceTxtBox.Text),
                Quantity = int.Parse(this.QuantityTxtBox.Text),
                Status = this.updateCreateSalesReportBLL.StatusText(this.SecondHandCheckBox.Checked)
            };
            return item;
        }

    }
}
