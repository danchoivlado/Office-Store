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
    public partial class MainForm : Form
    {
        TextBox TextBox;
        MainFormBLL MainFormBLL;
        string EmployeeName;
        //Keeps the last focused textbox

        public MainForm(string EmployeeName)
        {
            InitializeComponent();
            TextBox = BarcodeTxtBox;
            this.MainFormBLL = new MainFormBLL();
            this.EmployeeName = EmployeeName;
        }

        private void OneBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += OneBut.Text;  //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += OneBut.Text; //Adds the digit to textbox
            }

        }

        private void TwoBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += TwoBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += TwoBut.Text; //Adds the digit to textbox
            }
        }

        private void ThreeBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += ThreeBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += ThreeBut.Text; //Adds the digit to textbox
            }
        }

        private void FourBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += FourBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += FourBut.Text; //Adds the digit to textbox
            }
        }

        private void FiveBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += FiveBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += FiveBut.Text;//Adds the digit to textbox
            }
        }

        private void SixBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += SixBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += SixBut.Text; //Adds the digit to textbox
            }
        }

        private void SevenBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += SevenBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += SevenBut.Text; //Adds the digit to textbox
            }
        }

        private void EightBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += EightBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += EightBut.Text; //Adds the digit to textbox
            }
        }

        private void NineBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += NineBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += NineBut.Text; //Adds the digit to textbox
            }
        }

        private void DoubleZeroBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += DoubleZeroBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += DoubleZeroBut.Text; //Adds the digit to textbox
            }
        }

        private void ComaBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += ComaBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += ComaBut.Text; //Adds the digit to textbox
            }
        }

        private void ZeroBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Text += ZeroBut.Text; //Adds the digit to textbox
            }
            else
            {
                QuantityTxtBox.Text += ZeroBut.Text; //Adds the digit to textbox
            }
        }

        private void PlusBut_Click(object sender, EventArgs e)
        //Adds the one to quantitytxtBox
        {
            if (QuantityTxtBox.Text != String.Empty) 
                //checks if QuantityTxtBox is emppty
            {
                int EndValue = int.Parse(QuantityTxtBox.Text) + int.Parse(OneBut.Text);
                QuantityTxtBox.Text = EndValue.ToString();
            }
            else
            {
                QuantityTxtBox.Text = OneBut.Text;
            }
        }

        private void DeleteNumberBut_Click(object sender, EventArgs e)
        {
            if (TextBox == BarcodeTxtBox)
            {
                BarcodeTxtBox.Clear(); //clears the last focused textbox
            }
            else
            {
                QuantityTxtBox.Clear(); //clears the last focused textbox
            }
        }

        private void BarcodeTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox = BarcodeTxtBox;
            //changes the last focused box
        }
        private void QuantityTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox = QuantityTxtBox;
            //changes the last focused box
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //Closes the Form
        }

        private void BarcodeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = QuantityTxtBox;
                QuantityTxtBox.Focus();
            }

            //focus the next textbox
        }
        private void QuantityTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NextItemBut.PerformClick();
            }
            //presses the AddItemBut button
        }

        private void NextItemBut_Click(object sender, EventArgs e)
        {
            int ItemBarcode = int.Parse(this.BarcodeTxtBox.Text);
            int ItemQuantity = int.Parse(this.QuantityTxtBox.Text);

            MainFormBLL.NextItemProceed(ItemBarcode, ItemQuantity);

            this.BarcodeTxtBox.Clear();
            this.QuantityTxtBox.Clear();

            this.ActiveControl = QuantityTxtBox;
            BarcodeTxtBox.Focus();
        }

        private void EndTransactionBut_Click(object sender, EventArgs e)
        {
            MainFormBLL.EndTransactionProceed(this.EmployeeName);
        }

        private void ShowReceiptBut_Click(object sender, EventArgs e)
        {
            MainFormBLL.ShowInvoice(EmployeeName);
        }
    }
}
