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
    public partial class MainFrom : Form
    {
        Store_Info Store_Info;
        RegisterForm RegisterForm;
        InvoiceForm InvoiceForm;
        NewItemForm NewItemForm;
        StoreItemsForm StoreItemsForm;
        SalesReportForm SalesReportForm;
        InvoiceFormL InvoiceFormL;


        public MainFrom()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void StoreInfoBut_Click(object sender, EventArgs e)
        {
            this.Store_Info = new Store_Info();
            Store_Info.ShowDialog();
        }

        private void NewEmployeeBut_Click(object sender, EventArgs e)
        {
            this.RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }

        private void NewInvoiceBut_Click(object sender, EventArgs e)
        {
            this.InvoiceFormL = new InvoiceFormL();
            this.InvoiceFormL.Show();
        }


        private void NewInvoiceBut_MouseLeave(object sender, EventArgs e)
        {
            this.NewInvoiceBut.Image = HardwareStore.Properties.Resources.Black1;
        }

        private void NewInvoiceBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.NewInvoiceBut.Image = HardwareStore.Properties.Resources.Black2;
        }

        private void DailySalesBut_MouseLeave(object sender, EventArgs e)
        {
            this.DailySalesBut.Image = HardwareStore.Properties.Resources.Daily1;
        }

        private void DailySalesBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.DailySalesBut.Image = HardwareStore.Properties.Resources.Daily2;
        }

        private void AddItemBut_MouseLeave(object sender, EventArgs e)
        {
            this.AddItemBut.Image = HardwareStore.Properties.Resources.Item;
        }

        private void AddItemBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.AddItemBut.Image = HardwareStore.Properties.Resources.Item2;
        }

        private void StoreInfoBut_MouseLeave(object sender, EventArgs e)
        {
            this.StoreInfoBut.Image = HardwareStore.Properties.Resources.StoreInfo1;
        }

        private void StoreInfoBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.StoreInfoBut.Image = HardwareStore.Properties.Resources.SoreInfo2;
        }

        private void NewEmployeeBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.NewEmployeeBut.Image = HardwareStore.Properties.Resources.Employee2;
        }

        private void NewEmployeeBut_MouseLeave(object sender, EventArgs e)
        {
            this.NewEmployeeBut.Image = HardwareStore.Properties.Resources.Employees1;
        }

        private void AddItemBut_Click(object sender, EventArgs e)
        {
            this.NewItemForm = new NewItemForm();
            this.NewItemForm.ShowDialog();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            this.StoreItemsPicBox.Image = HardwareStore.Properties.Resources.Selected;
        }

        private void StoreItemsPicBox_MouseLeave(object sender, EventArgs e)
        {
            this.StoreItemsPicBox.Image = HardwareStore.Properties.Resources.Not_Selected;
        }

        private void StoreItemsPicBox_Click(object sender, EventArgs e)
        {
            this.StoreItemsForm = new StoreItemsForm();
            this.StoreItemsForm.ShowDialog();
        }

        private void DailySalesBut_Click(object sender, EventArgs e)
        {
            this.SalesReportForm = new SalesReportForm();
            this.SalesReportForm.ShowDialog();
        }
    }
}
