using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareStore.Database;
using HardwareStore.Models;

namespace HardwareStore.BusinessLogic
{
    class InvoiceBLL
    {
        OfficeStoreContext officeStoreContext;
        public InvoiceBLL()
        {
            this.officeStoreContext =new OfficeStoreContext();
        }

        public string SaveInvoice(List<CartItem> cartItems, string CashAmount )
        {
            var Id = this.officeStoreContext.Invoice.Count() + 1;
            foreach (var item in cartItems)
            {
                InvoiceItems InvoiceItem = new InvoiceItems()
                {
                    ItemId = item.Barcode,
                    Quantity = item.Quantity,
                    SinglePrice = item.SinglePrice,
                    Total = item.Total,
                    InvoiceId = Id
                };
                this.officeStoreContext.InvoiceItems.Add(InvoiceItem);
            }
            Invoice invoice = new Invoice()
            {
                OrderNo = Id + 1000,
                Date = DateTime.Now.Date,
                Time = DateTime.Now.TimeOfDay,
                EmployeeId = this.officeStoreContext.LastLogin.Last().EmployeeId,
                Total = cartItems.Sum(a => a.Total),
                PaymentMethodId = 1,
                StoreInfoId = 1
            };


            this.officeStoreContext.Invoice.Add(invoice);
            this.officeStoreContext.SaveChanges();
            return (double.Parse(CashAmount) - invoice.Total).ToString();
        }
    }
}
