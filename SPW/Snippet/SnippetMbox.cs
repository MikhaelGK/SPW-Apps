using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPW.Snippet
{
    public static class SnippetMbox
    {
        public static void MboxError(string msg, string tle)
        {
            MessageBox.Show(msg, tle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MboxWarning(string msg, string tle)
        {
            MessageBox.Show(msg, tle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MboxInformation(string msg, string tle)
        {
            MessageBox.Show(msg, tle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MboxExclamation(string msg, string tle)
        {
            MessageBox.Show(msg, tle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MboxStop(string msg, string tle)
        {
            MessageBox.Show(msg, tle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
