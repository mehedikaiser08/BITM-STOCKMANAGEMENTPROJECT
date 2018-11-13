using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.LoginModels;
using StackManagementSystemUI.LoginDAL;

namespace StackManagementSystemUI.LoginBLL
{
    public class AccessManager
    {
        public bool AccessInfo(Access accessObj)
        {
            AccessRipository accRipoObj = new AccessRipository();
            bool login = accRipoObj.AccessInfo(accessObj);
            return login;
        }
    }
}
