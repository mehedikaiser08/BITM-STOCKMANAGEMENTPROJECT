﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManagementSystemUI.StcOutModels
{
    public class StockOutItem
    {
        public string Company { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public int ReorderLabel { get; set; }
        public int AvailableQuantity { get; set; }
        public int StockOutQuantity { get; set; }
        public int Id { get; set; }
        public DateTime SellDate { get; set; }
    }
}
