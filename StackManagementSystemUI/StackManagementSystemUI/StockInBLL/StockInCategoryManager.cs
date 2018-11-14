using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInDAL;
using System.Data;


namespace StackManagementSystemUI.StockInBLL
{
   public class StockInCategoryManager
    {
       StockInCategoryRepository categoryRepository = new StockInCategoryRepository();

       public DataTable GetCategoryNames(string selectedCompany)
       {
         
           DataTable dt = categoryRepository.GetCategoryNames(selectedCompany);
           return dt;
       }
    }
}
