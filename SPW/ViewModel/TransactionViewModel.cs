using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.ViewModel
{
    public class TransactionViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public string Type { get; set; }
        public int Subtotal { get; set; }
    }
}
