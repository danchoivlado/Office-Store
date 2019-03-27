using HardwareStore.Models;
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
        
        public void CreateItem(string Barcode,string ProductName,
            double OriginalPrice,double SalesPrice,int Quantity,bool IsChecked)
        {
            var Status = String.Empty;

            if (IsChecked is false)
                Status = "Factory New";
            else
                Status = "Second Hand";

            Items item = new Items()
            {
                Id = Barcode,
                ProductName = ProductName,
                OriginalPrice = OriginalPrice,
                SalesPrice = SalesPrice,
                Quantity = Quantity,
                Status = Status
            };

            this.officeStoreContext.Items.Add(item);
            this.officeStoreContext.SaveChanges();
        }
    }
}
