using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.ViewModel
{
    public class HeaderTrxViewModel
    {
        public string TrxID { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int Profit { get; set; }
    }
}
