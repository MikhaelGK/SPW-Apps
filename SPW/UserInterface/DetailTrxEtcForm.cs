using SPW.Snippet;
using SPW.ViewModel;
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
    public partial class DetailTrxEtcForm : UserControl
    {
        private readonly DateTime start;
        private readonly DateTime end;

        public DetailTrxEtcForm(DateTime start, DateTime end)
        {
            InitializeComponent();
            this.start = start;
            this.end = end;
        }

        private void LoadHeaderEtc()
        {
            var context = new db();
            var headerTrxes = context.DetailEtcTrxes
                .Where(x => x.HeaderTrx.Date >= start && x.HeaderTrx.Date <= end)
                .Select(x => new { x.TrxId, x.HeaderTrx.Date })
                .Distinct()
                .ToList();

            var headers = new List<HeaderTrxViewModel>();

            foreach (var i in headerTrxes)
            {
                var totalSellPrice = 0;
                var detailTrxes = context.DetailEtcTrxes
                    .Where(x => x.TrxId == i.TrxId)
                    .ToList();

                foreach (var d in detailTrxes)
                {
                    totalSellPrice += d.Price;
                }

                var header = new HeaderTrxViewModel()
                {
                    TrxID = i.TrxId,
                    Date = i.Date,
                    Price = totalSellPrice,
                };

                headers.Add(header);
            }

            var total = 0;
            foreach (var i in headers)
            {
                total += i.Price;
            }

            var addition = new HeaderTrxViewModel()
            {
                TrxID = "Total",
                Price = total
            };
            headers.Add(addition);

            dgvHeader.DataSource = headers.Select(x => new
            {
                colID = x.TrxID,
                colDate = x.Date,
                colTotalPrice = SnippetCurrency.ConvertCurrency(x.Price),
            }).ToList();
        }

        private void LoadDetailEtc(string trxId)
        {
            var context = new db();
            var detailTrxes = context.DetailEtcTrxes
                .Where(x => x.TrxId == trxId);

            var details = new List<DetailTrxViewModel>();

            foreach (var d in detailTrxes)
            {
                var subtotal = d.Price;

                var detail = new DetailTrxViewModel()
                {
                    Name = d.Info,
                    SellPrice = d.Price,
                    Subtotal = subtotal,
                    Type = d.Type.Name
                };
                details.Add(detail);
            }

            dgvDetail.DataSource = details.Select(x => new
            {
                colName = x.Name,
                colType = x.Type,
                colSellPrice = SnippetCurrency.ConvertCurrency(x.SellPrice),
                colSubtotal = SnippetCurrency.ConvertCurrency(x.Subtotal),
            }).ToList();
        }

        private void dgvHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvHeader.CurrentRow;
            if (selectedRow == null)
            {
                return;
            }

            var trxId = selectedRow.Cells[0].Value.ToString();
            LoadDetailEtc(trxId);
        }

        private void DetailTrxEtcForm_Load(object sender, EventArgs e)
        {
            LoadHeaderEtc();

        }
    }
}
