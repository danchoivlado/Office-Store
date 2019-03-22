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

namespace HardwareStore.View
{
    public partial class Store_Info : Form
    {
        RegisterLoginInfoBLL RegisterLoginInfoBLL;
        LoginForm LoginForm;

        public Store_Info()
        {
            InitializeComponent();
            this.RegisterLoginInfoBLL = new RegisterLoginInfoBLL();//creates new form
            string[] NameAddress = RegisterLoginInfoBLL.GetNameAddressIfExists();
            //gets the Name and Address from DB
            this.StoreNameTxtBox.Text = NameAddress[0];
            this.StoreAddressTxtBox.Text = NameAddress[1];
        }

        private void StoreNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = StoreAddressTxtBox;
                StoreAddressTxtBox.Focus();
            }
        }

        private void StoreAddressTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveBut.PerformClick();
            }
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            string StoreName = this.StoreNameTxtBox.Text;
            string StoreAddress = this.StoreAddressTxtBox.Text;
            RegisterLoginInfoBLL.SaveData(StoreName, StoreAddress); 
            //Update The TxtBoxes
            this.Hide();// Hides the Form
            this.LoginForm = new LoginForm();
            this.LoginForm.Show();
        }

        private void Store_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
