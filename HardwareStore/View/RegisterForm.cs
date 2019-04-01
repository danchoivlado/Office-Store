using HardwareStore.BusinessLogic;
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

namespace HardwareStore.View
{
    public partial class RegisterForm : Form
    {
        RegisterLoginInfoBLL registerLoginBLL;
        private  const string AdminPassword = "3073";


        public RegisterForm()
        {
            InitializeComponent();
            this.ActiveControl = FirstNameTxtBox;
            FirstNameTxtBox.Focus();
            this.registerLoginBLL = new RegisterLoginInfoBLL();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AdminPasswordTxtBox._TextBox.PasswordChar = '*';
            this.PasswordTxtBox._TextBox.PasswordChar = '*';

        }

        private void SignUpBut_Click(object sender, EventArgs e)
        {
            if (AdminPasswordTxtBox.text == AdminPassword)
            {
                registerLoginBLL.Register(FirstNameTxtBox.text, LastNameTxtBox.text, TownTxtBox.text, PasswordTxtBox.text);
                //send the info to BusinessLogic
                this.Close();
            }
        }
    }
}
