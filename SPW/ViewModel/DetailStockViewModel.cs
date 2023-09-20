using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.ViewModel
{
    public class DetailStockViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Store { get; set; }
        public int Take { get; set; }
        public int Rest { get; set; }
    }
}
