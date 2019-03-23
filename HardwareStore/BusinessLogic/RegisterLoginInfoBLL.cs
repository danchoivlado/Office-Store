using HardwareStore.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.View;

namespace HardwareStore.BusinessLogic
{
    class RegisterLoginInfoBLL
    {
        RegisterLoginInfoDB Base;

        public RegisterLoginInfoBLL()
        {
            this.Base = new RegisterLoginInfoDB();
        }

        public bool Login(string LoginName, string password)
        {
            if (Base.GetPasswordIfExists(LoginName) == password)
                return true;
            else
                return false;
        }

        public void Register(string FirstName, string LastName, string TownName, string Password)
        {
            int TownId = Base.GetTownsId(TownName);
            //gets the TownId
            Base.Register(FirstName, LastName, Password, TownId);
            //send info to DatabaseLayer
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
