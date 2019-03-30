using HardwareStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.BusinessLogic
{
    class UpdateCreateSalesReportBLL
    {
        OfficeStoreContext officeStoreContext;

        public UpdateCreateSalesReportBLL()
        {
            this.officeStoreContext = new OfficeStoreContext();
        }

        public void CreateItem(Items item)
        {
            this.officeStoreContext.Items.Add(item);
            this.officeStoreContext.SaveChanges();
        }

        public void UpdateItem(Items Item1, string ItemId)
        {
            var Item2 = officeStoreContext.Items.FirstOrDefault(a => a.Id == ItemId);
            Item2.Id = Item1.Id;
            Item2.ProductName = Item1.ProductName;
            Item2.OriginalPrice = Item1.OriginalPrice;
            Item2.SalesPrice = Item1.SalesPrice;
            Item2.Quantity = Item1.Quantity;
            Item2.Status = Item1.Status;

            this.officeStoreContext.SaveChanges();
        }

        public bool IsItemExists(string Barcode)
        {
            var Item = this.officeStoreContext.Items.FirstOrDefault(a => a.Id == Barcode);
            if (Item == null)
            {
                return false;
            }
            return true;
        }

        public List<Items> GetAllInfo()
        {
            var list = this.officeStoreContext.Items.ToList();
            return list;
        }

        public List<DailySales> SalesReprotInfo()
        {
            List<DailySales> lis = new List<DailySales>();
            var l = DateTime.Now.Date;

            var Invoices = this.officeStoreContext.Invoice.Where(a => a.Date.ToString("d") == l.Date.ToString("d"));

            foreach (var Invoice in Invoices)
            {
                var InvoiceItems = this.officeStoreContext.InvoiceItems.Where(a => a.InvoiceId == Invoice.Id);

                foreach (var InvoiceItem in InvoiceItems)
                {
                    DailySales dailySales = new DailySales();

                    var Desciption = this.officeStoreContext.Items.First(a => a.Id == InvoiceItem.ItemId);

                    dailySales.ProductNumber = InvoiceItem.ItemId;
                    if (lis.Any(a => a.Description == Desciption.ProductName))
                    {
                        var item = lis.First(a => a.Description == Desciption.ProductName);

                        item.Quantity += InvoiceItem.Quantity;
                        item.SinglePrice = InvoiceItem.SinglePrice;
                        item.Total += InvoiceItem.Total;
                    }
                    else
                    {
                        dailySales.Description = Desciption.ProductName;
                        dailySales.Quantity = InvoiceItem.Quantity;
                        dailySales.SinglePrice = InvoiceItem.SinglePrice;
                        dailySales.Total = InvoiceItem.Total;
                        lis.Add(dailySales);
                    }
                }
            }
            return lis;
        }

        public string StatusText(bool IsChecked)
        {
            if (IsChecked)
            {
                return "Second Hand";
            }
            return "Factory New";
        }

        public bool IsChecked(string status)
        {
            if (status == "Second Hand")
            {
                return true;
            }
            return false;
        }

        public void Delete(string Id)
        {
            var item = this.officeStoreContext.Items.First(a => a.Id == Id);
            foreach (var item2 in this.officeStoreContext.InvoiceItems.Where(a => a.ItemId == item.Id))
            {
                this.officeStoreContext.InvoiceItems.Remove(item2);
            }
            this.officeStoreContext.Items.Remove(item);
            this.officeStoreContext.SaveChanges();
        }
    }
}
