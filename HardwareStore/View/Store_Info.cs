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
            this.StoreNameTxtBox.text = NameAddress[0];
            this.StoreAddressTxtBox.text = NameAddress[1];
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void SaveBut_Click_1(object sender, EventArgs e)
        {
            string StoreName = this.StoreNameTxtBox.text;
            string StoreAddress = this.StoreAddressTxtBox.text;
            RegisterLoginInfoBLL.SaveData(StoreName, StoreAddress);
            //Update The TxtBoxes
            this.Close();// Hides the Form
        }
    }
}
