using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.LoginModels;
using StackManagementSystemUI.LoginDAL;


namespace StackManagementSystemUI.LoginBLL
{
    public class AccountManager
    {
        public bool AccountInfo(Account accounObj)
        {
            AccountRipository accountRipoObj = new AccountRipository();
            bool accountInfo = accountRipoObj.AccountInfo(accounObj);
            return accountInfo;
        }
    }
}
