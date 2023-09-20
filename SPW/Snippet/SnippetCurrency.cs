using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.Snippet
{
    public static class SnippetCurrency
    {
        public static string ConvertCurrency(int number)
        {
            var culture = new CultureInfo("id-ID");
            culture.NumberFormat.CurrencyDecimalSeparator = ",";
            culture.NumberFormat.CurrencyGroupSeparator = ".";
            culture.NumberFormat.CurrencySymbol = "Rp.";
            return number.ToString("C", culture);
        }
    }
}
