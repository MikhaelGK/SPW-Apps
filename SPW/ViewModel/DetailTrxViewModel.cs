using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.ViewModel
{
    public class DetailTrxViewModel
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int Subtotal { get; set; }
        public int Profit { get; set; }
        public string Type { get; set; }
    }
}
