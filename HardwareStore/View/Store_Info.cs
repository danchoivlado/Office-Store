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

        public Store_Info()
        {
            InitializeComponent();
            this.RegisterLoginInfoBLL = new RegisterLoginInfoBLL();
            string[] NameAddress = RegisterLoginInfoBLL.GetNameAddressIfExists();
            this.StoreNameTxtBox.Text = NameAddress[0];
            this.StoreAddressTxtBox.Text = NameAddress[1];
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            string StoreName = this.StoreNameTxtBox.Text;
            string StoreAddress = this.StoreAddressTxtBox.Text;
            RegisterLoginInfoBLL.SaveData(StoreName, StoreAddress); 
            //Update The TxtBoxes
            this.Close();// Hides the Form
        }

       
    }
}
