using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManagementSystemUI.ItemModels
{
    public class Item
    {
        public string Category { get; set; }
        public string CompanyName { get; set; }
        public string ItemName { get; set; }
        public int ReorderLabel { get; set; }
        public int AvaialableQuantity { get; set; }
    }
}
