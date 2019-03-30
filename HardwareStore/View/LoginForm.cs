﻿using System;
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
        Thread thread;


        public LoginForm()
        {
            InitializeComponent();
            this.registerLoginBLL = new RegisterLoginInfoBLL();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


        private void LoginBut_Click(object sender, EventArgs e)
        {

            if (this.registerLoginBLL.Login(this.NameTxtBox.Text, this.PasswordTxtBox.Text))
            {
                this.registerLoginBLL.SaveLogined(this.NameTxtBox.Text);
                MainForm = new MainFrom();
                this.Hide();
                MainForm.ShowDialog();
                this.Close();
            }
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            this.RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }

        //private void GenerateForm()
        //{
        //    this.Close();
        //    thread = new Thread(oppenedform);
        //    thread.SetApartmentState(ApartmentState.STA);
        //    thread.Start();
        //}

        //private void oppenedform()
        //{
        //    Application.Run(this.MainForm = new MainFrom());
        //}
    }
}
