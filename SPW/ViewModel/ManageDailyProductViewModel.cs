using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.ViewModel
{
    public class ManageDailyProductViewModel
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public int Store { get; set; }
        public int Take { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int Total { get; set; }
    }
}
