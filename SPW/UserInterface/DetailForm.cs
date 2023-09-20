using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPW.UserInterface
{
    public partial class DetailForm : UserControl
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        private void cBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDataGridView.Controls.Clear();
            var selectedIndex = cBoxType.SelectedIndex;
            if (selectedIndex == 0)
            {
                var detail = new DetailEmployeeForm();
                panelDataGridView.Controls.Add(detail);
            }
            else if (selectedIndex == 1)
            {
                var detail = new DetailStockForm();
                panelDataGridView.Controls.Add(detail);
            }
            else
            {
                var detail = new DetailTrxForm();
                panelDataGridView.Controls.Add(detail);
            }
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            cBoxType.SelectedIndex = 0;
        }
    }
}
