using HardwareStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.BusinessLogic
{
    public class CartItem
    {
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public double Total { get; set; }
       // public int InvoiceId { get; set; }
        OfficeStoreContext officestoreContext;

        public CartItem()
        {

        }
        public CartItem(string Barcode, string Quantity)
        {
            this.officestoreContext = new OfficeStoreContext();
            var Item = this.officestoreContext.Items.First(a => a.Id == Barcode);

            this.Barcode = Barcode;
            this.Quantity = int.Parse(Quantity);
            this.SinglePrice = Item.SalesPrice;
            this.Total = this.Quantity*this.SinglePrice;
            //this.InvoiceId = InvoiceId;
        }

        public void QuantityMinus()
        {
            this.Quantity--;
            this.Total = this.Quantity * this.SinglePrice;
        }
    }
}
