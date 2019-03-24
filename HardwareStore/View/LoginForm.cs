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
using HardwareStore.Database;
using HardwareStore.View;

namespace HardwareStore
{
    public partial class LoginForm : Form
    {
        RegisterForm RegisterForm;
        RegisterLoginInfoBLL registerLoginBLL;
        MainForm MainForm;
        Store_Info Store_Info;

        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = NameTxtBox;
            NameTxtBox.Focus();
            this.registerLoginBLL = new RegisterLoginInfoBLL();
        }

        private void NameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = PasswordTxtBox;
                PasswordTxtBox.Focus();
            }

            //focus the next textbox
        }

        private void PasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBut.PerformClick();
            }
            //presses the LoginBut button
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            
            if (this.registerLoginBLL.Login(this.NameTxtBox.Text,PasswordTxtBox.Text))
            {
                this.Hide(); //MAKE IT TO HIDE()
                MainForm = new MainForm(this.NameTxtBox.Text);
                MainForm.Show();
            }
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            this.RegisterForm = new RegisterForm();
            this.Hide();
            RegisterForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //closes all the processes in this form 
        }

        private void StoreInfoBut_Click(object sender, EventArgs e)
        {
            this.Store_Info = new Store_Info();
            this.Hide();
            Store_Info.Show();
        }
    }
}
