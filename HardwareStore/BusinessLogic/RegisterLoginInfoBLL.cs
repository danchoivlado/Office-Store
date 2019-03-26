using HardwareStore.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.View;
using HardwareStore.Models;

namespace HardwareStore.BusinessLogic
{
    class RegisterLoginInfoBLL
    {
        RegisterLoginInfoDB Base;
        officestoreContext officestoreContext;

        public RegisterLoginInfoBLL()
        {
            this.Base = new RegisterLoginInfoDB();
            this.officestoreContext = new officestoreContext();
        }

        public bool Login(string LoginName, string password)
        {
            using (officestoreContext = new officestoreContext())
            {
                var HasEmployeeWithName = officestoreContext.Employees.FirstOrDefault(a => a.FirstName == LoginName && a.Password == password);
                if (HasEmployeeWithName != null)
                {
                    return true;
                }
            }
            return false;
        }

        public void Register(string FirstName, string LastName, string TownName, string Password)
        {
            var Town = this.officestoreContext.Towns.FirstOrDefault(a => a.Name == TownName);
            if (Town == null)
            {
                Town = new Towns()
                {
                    Name = TownName
                };
                this.officestoreContext.Towns.Add(Town);
            }
            Employees employee = new Employees()
            {
                FirstName = FirstName,
                LastName = LastName,
                TownId = Town.Id,
                Password = Password,
                DutyId = 1
            };

            this.officestoreContext.Employees.Add(employee);
            this.officestoreContext.SaveChanges();
        }

        public string[] GetNameAddressIfExists()
        {
            string NameAddress = Base.GetNameAddressIfExist();
            //gets the Name and Address from DB
            return NameAddress.Split(';').ToArray();
            //Splits and returns to BLL
        }

        public void SaveData(string StoreName, string StoreAddress)
        {
            this.Base.SaveInfo(StoreName, StoreAddress);
        }


    }
}
