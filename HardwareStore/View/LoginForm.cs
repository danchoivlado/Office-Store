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
using HardwareStore.BusinessLogic;
using HardwareStore.Database;
using HardwareStore.View;

namespace HardwareStore
{
    public partial class LoginForm : Form 
    {
        RegisterForm RegisterForm;
        RegisterLoginInfoBLL registerLoginBLL;
        MainFrom MainForm;


        public LoginForm()
        {
            InitializeComponent();
            this.registerLoginBLL = new RegisterLoginInfoBLL();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


        private void SignInBut_Click(object sender, EventArgs e)
        {
            if (this.registerLoginBLL.Login(this.NameTxtBox.text, this.PasswordTxtBox.text))
            {
                this.registerLoginBLL.SaveLogined(this.NameTxtBox.text);
                MainForm = new MainFrom();
                this.Hide();
                MainForm.ShowDialog();
                this.Close();
            }
        }

        private void SignUpBut_Click(object sender, EventArgs e)
        {
            this.RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }

        private void SignUpBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.SignUpBut.ForeColor = Color.MediumSeaGreen;
        }

        private void SignUpBut_MouseLeave(object sender, EventArgs e)
        {
            this.SignUpBut.ForeColor = Color.SeaGreen;
        }
    }
}
