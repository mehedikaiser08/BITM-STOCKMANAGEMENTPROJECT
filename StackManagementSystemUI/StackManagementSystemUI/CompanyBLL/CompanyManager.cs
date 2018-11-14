using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.CompanyDAL;
using StackManagementSystemUI.CompanyModels;
using System.Data;

namespace StackManagementSystemUI.CompanyBLL
{
    public class CompanyManager
    {
        CompanyRipository comRipoObj = new CompanyRipository();
        public bool SaveCompInfo(Company comObj)
        {
            bool companyInfo = comRipoObj.SaveCompInfo(comObj);
            return companyInfo;
        }


        public DataTable CompanyDataTable()
        {
            DataTable DT = comRipoObj.CompanyDataTable();
            return DT;
        }
    }
}
