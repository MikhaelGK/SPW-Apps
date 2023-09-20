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
    public partial class DetailTrxForm : UserControl
    {
        DateTime start;
        DateTime end;
        int typeId;

        public DetailTrxForm()
        {
            InitializeComponent();
        }

        private void LoadDetailProduct()
        {
            panelDetail.Controls.Clear();
            var form = new DetailTrxProductForm(start, end);
            panelDetail.Controls.Add(form);
        }

        private void LoadDetailEtc()
        {
            panelDetail.Controls.Clear();
            var form = new DetailTrxEtcForm(start, end);
            panelDetail.Controls.Add(form);
        }

        private void DetailTrxForm_Load(object sender, EventArgs e)
        {
            start = Convert.ToDateTime(dtpStart.Value.ToString("yyyy-MM-dd"));
            end = Convert.ToDateTime(dtpEnd.Value.ToString("yyyy-MM-dd"));
            end = end.AddDays(1).AddSeconds(-1);
            cBoxType.SelectedIndex = 0;
            typeId = cBoxType.SelectedIndex;
            LoadDetailProduct();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            start = Convert.ToDateTime(dtpStart.Value.ToString("yyyy-MM-dd"));
            if (typeId == 0) LoadDetailProduct();
            else LoadDetailEtc();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            end = Convert.ToDateTime(dtpEnd.Value.ToString("yyyy-MM-dd"));
            end = end.AddDays(1).AddSeconds(-1);
            if (typeId == 0) LoadDetailProduct();
            else LoadDetailEtc();
        }

        private void cBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeId = cBoxType.SelectedIndex;
            if (typeId == 0) LoadDetailProduct();
            else LoadDetailEtc();
        }
    }
}
