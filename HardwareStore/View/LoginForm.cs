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
        RegisterLoginBLL registerLoginBLL;

        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = NameTxtBox;
            NameTxtBox.Focus();
            this.registerLoginBLL = new RegisterLoginBLL();
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
            //focus the next textbox
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            
            if (this.registerLoginBLL.Login(this.NameTxtBox.Text))
            {
                this.Close(); //MAKE IT TO HIDE()
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
    }
}
