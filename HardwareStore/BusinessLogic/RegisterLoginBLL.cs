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
    class RegisterLoginBLL
    {
        Base Base;

        public RegisterLoginBLL()
        {
            this.Base = new Base();
        }

        public bool Login(string LoginName)
        {
            if (Base.GetPasswordIfExists(LoginName) != String.Empty)
                return true;
            else
                return false;
        }

        public void Register(string FirstName,string LastName,string TownName,string Password)
        {
            int TownId = Base.GetTownsId(TownName);
            //gets the TownId
            Base.Register(FirstName, LastName, Password, TownId);
            //send info to DatabaseLayer
        }
    }
}
