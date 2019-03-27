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
    public partial class NewItemForm : Form
    {
        UpdateCreateSalesReportBLL updateCreateSalesReportBLL;
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            this.updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            string BarcodeText =this.BarcodeTxtBox.Text.Substring(2);

            this.updateCreateSalesReportBLL.CreateItem(BarcodeText, this.ProductNameTxtBox.Text,
                double.Parse(this.OriginalPriceTxtBox.Text), double.Parse(this.SalesPriceTxtBox.Text),
                int.Parse(this.QuantityTxtBox.Text),this.SecondHandCheckBox.Checked);

            ClearDataFromTxtBoxes();
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
            this.BarcodeTxtBox.Clear();
            this.ProductNameTxtBox.Clear();
            this.OriginalPriceTxtBox.Clear();
            this.SalesPriceTxtBox.Clear();
            this.QuantityTxtBox.Clear();
            this.SecondHandCheckBox.Checked = false;
        }
    }
}
