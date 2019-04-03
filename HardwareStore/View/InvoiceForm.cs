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
       //this should be not here
        List<CartItem> cartItems;
        InvoiceBLL InvoiceBLL;
        public InvoiceForm(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;
            this.TotalTxtBox.Text = $"{cartItems.Sum(a => a.Total):f2}";
            this.InvoiceBLL = new InvoiceBLL();
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
           
            this.ChangeTxtBox.Text = $"{this.InvoiceBLL.SaveInvoice(this.cartItems,this.CashAmount.Text):f2}";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllHundred_Click(object sender, EventArgs e)
        {
            CashAmount.Text =(int.Parse(CashAmount.Text )+100).ToString();
        }

        private void AllFifty_Click(object sender, EventArgs e)
        {
            CashAmount.Text = (int.Parse(CashAmount.Text )+ 50).ToString();

        }

        private void AllTwenty_Click(object sender, EventArgs e)
        {
            CashAmount.Text = (int.Parse(CashAmount.Text) + 20).ToString();

        }

        private void AllTen_Click(object sender, EventArgs e)
        {
            CashAmount.Text = (int.Parse(CashAmount.Text) + 10).ToString();

        }

        private void AllFive_Click(object sender, EventArgs e)
        {
            CashAmount.Text = (int.Parse(CashAmount.Text) + 5).ToString();

        }

       
    }
}
