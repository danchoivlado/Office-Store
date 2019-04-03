using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.BusinessLogic;
using HardwareStore.Models;

namespace HardwareStore.View
{
    public partial class InvoiceForm : Form
    {
        OfficeStoreContext officeStoreContext;//this should be not here
        List<CartItem> cartItems;

        public InvoiceForm(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;
            this.ChangeTxtBox.ReadOnly = true;
            this.officeStoreContext = new OfficeStoreContext();
        }

        private void OneBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += OneBut.Text;  //Adds the digit to textbox
        }

        private void TwoBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += TwoBut.Text; //Adds the digit to textbox
        }

        private void ThreeBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += ThreeBut.Text; //Adds the digit to textbox
        }

        private void FourBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += FourBut.Text; //Adds the digit to textbox
        }

        private void FiveBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += FiveBut.Text; //Adds the digit to textbox
        }

        private void SixBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += SixBut.Text; //Adds the digit to textbox
        }

        private void SevenBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += SevenBut.Text; //Adds the digit to textbox
        }

        private void EightBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += EightBut.Text; //Adds the digit to textbox
        }

        private void NineBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += NineBut.Text; //Adds the digit to textbox
        }

        private void DoubleZeroBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += DoubleZeroBut.Text; //Adds the digit to textbox
        }

        private void ComaBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += ComaBut.Text; //Adds the digit to textbox
        }

        private void ZeroBut_Click(object sender, EventArgs e)
        {
            CashAmount.Text += ZeroBut.Text; //Adds the digit to textbox
        }

        private void EndTransactionBut_Click(object sender, EventArgs e)
        {
            var Id = this.officeStoreContext.Invoice.Count()+1;
            foreach (var item in this.cartItems)
            {
                InvoiceItems InvoiceItem = new InvoiceItems()
                {
                    ItemId = item.Barcode,
                    Quantity = item.Quantity,
                    SinglePrice = item.SinglePrice,
                    Total = item.Total,
                    InvoiceId = Id
                };
                this.officeStoreContext.InvoiceItems.Add(InvoiceItem);
            }
            Invoice invoice = new Invoice()
            {
                OrderNo = Id + 1000,
                Date = DateTime.Now.Date,
                Time = DateTime.Now.TimeOfDay,
                EmployeeId = this.officeStoreContext.LastLogin.Last().EmployeeId,
                Total = this.cartItems.Sum(a => a.Total),
                PaymentMethodId = 1,
                StoreInfoId = 1
            };


            this.officeStoreContext.Invoice.Add(invoice);
            this.officeStoreContext.SaveChanges();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

    }
}
