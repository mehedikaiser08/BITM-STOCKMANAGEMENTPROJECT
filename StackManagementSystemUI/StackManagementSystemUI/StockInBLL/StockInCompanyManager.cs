using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInDAL;
using StackManagementSystemUI.StockInModels;
using System.Data;

namespace StackManagementSystemUI.StackInBLL
{
    public class StackInCompanyManager
    {
        StockInCompanyRepository companyRepository = new StockInCompanyRepository();
        public DataTable GetCompanyNames()
        {
           
            DataTable dt = companyRepository.GetCompanyNames();
            return dt;
        }
    }
}
