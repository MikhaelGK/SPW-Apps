using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.ViewModel
{
    public class ManageProductViewModel
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int Total { get; set; }
        public string Type { get; set; }
    }
}
