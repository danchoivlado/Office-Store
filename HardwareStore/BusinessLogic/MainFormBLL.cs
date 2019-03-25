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

        public void EndTransactionProceed(string EmployeeName)
        {
            int InvoiceNumber = MainFormDB.GetInvoiceId() + 1;
            string Date = DateTime.Now.ToString("yyyy-MM-dd");
            string Time = DateTime.Now.ToShortTimeString();
            int EmployeeId = MainFormDB.GetEmployeeId(EmployeeName);
            double Total = MainFormDB.GetTotal(MainFormDB.GetInvoiceId() + 1);

            MainFormDB.InsertInvoice(InvoiceNumber, Date, Time, EmployeeId, Total);
        }

        public void ShowInvoice(string EmployeeName)
        {
            string[] NameAddress = MainFormDB.GetNameAddressIfExist().Split(';');
            int OrderNumber = MainFormDB.GetInvoiceId();
            string[] Date = MainFormDB.GetDate(OrderNumber).Split(' ');
            string Time = MainFormDB.GetTime(OrderNumber).Substring(0, 5);
            int CountOfInvoiceItems = MainFormDB.GetCountOfItems(OrderNumber);
            List<string[]> InvoiceItems = MainFormDB.InvoiceItems(OrderNumber);
            string Total = $"{MainFormDB.GetTotal(OrderNumber):f2}";

            StringBuilder InvoiceText = new StringBuilder();
            InvoiceText.AppendLine($"{NameAddress[0]}"); //todo make space and center the tittle
            InvoiceText.AppendLine(NameAddress[1]);
            InvoiceText.AppendLine();
            InvoiceText.AppendLine($@"Сметка\номер:         {OrderNumber} от {Date[0]}   {Time}");
            InvoiceText.AppendLine($@"Касиер:  {EmployeeName}");
            InvoiceText.AppendLine($"{new string('-', 44)}");
            InvoiceText.AppendLine($"|    наименование    |кол.|ед.цена|стойност|");
            InvoiceText.AppendLine($"{new string('-', 44)}");
            foreach (var Item in InvoiceItems)
            {
                InvoiceText.AppendLine(GenerateItems(Item));
            }
            InvoiceText.AppendLine($"{new string('-', 44)}");
            InvoiceText.AppendLine($"Стойност на сметката:{new string(' ',23-Total.Length)}{Total}");


            System.IO.File.WriteAllText(@"C:\Users\C#\Desktop\notepad.txt", InvoiceText.ToString());
            System.Diagnostics.Process.Start(@"C:\Users\C#\Desktop\notepad.txt");
        }

        private static string GenerateItems(string[] Item)
        {
            return $" {Item[0]}{Spaces(Item[0], 22)}{Item[1]}{Spaces(Item[1], 5)}{Item[2]}{Spaces(Item[2], 8)}{Item[3]} ";
        }

        private static string Spaces(string Item, int TotalSpaces)
        {
            return new string(' ', TotalSpaces - Item.Length);
        }
    }
}
