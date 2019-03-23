using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareStore.Database;

namespace HardwareStore.BusinessLogic
{
    class MainFormBLL
    {
        MainFormDB MainFormDB;

        public MainFormBLL()
        {
            this.MainFormDB = new MainFormDB();
        }

        public void NextItemProceed(int ItemBarcode, int ItemQuantity)
        {
            int InvoiceId = MainFormDB.GetInvoiceId() + 1;
            double ItemSinglePrice = MainFormDB.GetItemSinglePrice(ItemBarcode);
            double ItemTotal = ItemQuantity * ItemSinglePrice;
            string ItemName = MainFormDB.GetItemName(ItemBarcode);

            MainFormDB.UpdateQuantity(ItemQuantity, ItemName);
            MainFormDB.InserIntoInvoiceItems(ItemBarcode, ItemQuantity, ItemSinglePrice, ItemTotal, InvoiceId);

        }
    }
}
