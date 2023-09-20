using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPW.Snippet
{
    public static class SnippetGenerator
    {
        enum Master { Employee, Trx, Product }

        public static string GeneratorID(int length, int index)
        {
            var sb = new StringBuilder();

            if (index == ((int)Master.Employee)) sb.Insert(0, "E");
            else if (index == ((int)Master.Product)) sb.Insert(0, "P");
            else if (index == ((int)Master.Trx))
            {
                sb.AppendFormat(DateTime.Today.ToString("yyyy"));
                sb.AppendFormat(DateTime.Today.ToString("MM"));
            }

            var character = "1234567890";
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(character[random.Next(character.Length)]);
            }
            return sb.ToString();
        }
    }
}
