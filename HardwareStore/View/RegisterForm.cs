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
    public partial class RegisterForm : Form
    {
        LoginForm LoginForm;
        RegisterLoginInfoBLL registerLoginBLL;
        private  const string AdminPassword = "3073";
        public RegisterForm()
        {
            InitializeComponent();
            this.ActiveControl = FirstNameTxtBox;
            FirstNameTxtBox.Focus();
            this.registerLoginBLL = new RegisterLoginInfoBLL();
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            if (AdminPasswordTxtBox.Text == AdminPassword)
            {
                registerLoginBLL.Register(FirstNameTxtBox.Text,LastNameTxtBox.Text,TownTxtBox.Text,PasswordTxtBox.Text);
                //send the info to BusinessLogic
                this.Hide();
                this.LoginForm = new LoginForm();
                LoginForm.Show();
            }
        }

        private void FirstNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = LastNameTxtBox;
                LastNameTxtBox.Focus();
            }
            //focus the next textbox
        }

        private void LastNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = TownTxtBox;
                TownTxtBox.Focus();
            }
            //focus the next textbox
        }

        private void PasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = AdminPasswordTxtBox;
                AdminPasswordTxtBox.Focus();
            }
            //focus the next textbox
        }

        private void TownTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = PasswordTxtBox;
                PasswordTxtBox.Focus();
            }
            //focus the next textbox
        }

        private void AdminPasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterBut.PerformClick();
            }
            //focus the next textbox
        }
    }
}
