using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManagementSystemUI.StockInModels
{
    public class StockIn
    {
        public string ItemName { get; set; }
        public int stockInQuantity { get; set; }
        public int previousQuntity { get; set; }
    }
}
