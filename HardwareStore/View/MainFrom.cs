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


        public MainFrom()
        {
            InitializeComponent();
        }

        private void StoreInfoBut_Click(object sender, EventArgs e)
        {
            this.Store_Info = new Store_Info();
            Store_Info.Show();
            this.Dispose();
        }

        private void NewEmployeeBut_Click(object sender, EventArgs e)
        {
            this.RegisterForm = new RegisterForm();
            RegisterForm.Show();
            this.Dispose();
        }

        private void NewInvoiceBut_Click(object sender, EventArgs e)
        {
            this.InvoiceForm = new InvoiceForm();
            this.InvoiceForm.Show();
            this.Dispose();
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
    }
}
