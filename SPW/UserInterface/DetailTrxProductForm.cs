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
    public partial class DetailTrxProductForm : UserControl
    {
        private readonly DateTime start;
        private readonly DateTime end;

        public DetailTrxProductForm(DateTime start, DateTime end)
        {
            InitializeComponent();
            this.start = start;
            this.end = end;
        }

        private void LoadHeaderProducts()
        {
            var list = new List<HeaderTrxViewModel>();
            var context = new db();
            var headerTrxes = context.DetailProductTrxes
                .Where(x => x.HeaderTrx.Date >= start && x.HeaderTrx.Date <= end)
                .Select(x => new { x.TrxId, x.HeaderTrx.Date })
                .Distinct().ToList();

            foreach (var i in headerTrxes)
            {
                var trxes = context.DetailProductTrxes
                    .Where(x => x.TrxId == i.TrxId).ToList();
                var sellPrice = 0;
                var buyPrice = 0;

                foreach (var t in trxes)
                {
                    sellPrice += t.SellPrice * t.Qty;
                    buyPrice += t.BuyPrice * t.Qty;
                }

                var item = new HeaderTrxViewModel()
                {
                    TrxID = i.TrxId,
                    Date = i.Date,
                    Price = sellPrice,
                    Profit = sellPrice - buyPrice
                };
                list.Add(item);
            }

            list = list.OrderBy(x => x.Date).ToList();
            var profit = 0;
            var totalPrice = 0;

            foreach (var i in list)
            {
                profit += i.Profit;
                totalPrice += i.Price;
            }

            var addition = new HeaderTrxViewModel()
            {
                TrxID = "Total",
                Profit = profit,
                Price = totalPrice
            };

            list.Add(addition);

            dgvHeader.DataSource = list.Select(x => new
            {
                colID = x.TrxID,
                colDate = x.Date,
                colTotalPrice = SnippetCurrency.ConvertCurrency(x.Price),
                colTotalProfit = SnippetCurrency.ConvertCurrency(x.Profit)
            }).ToList();
        }

        //private void LoadHeaderProducts()
        //{
        //    var context = new db();
        //    var headerTrxes = context.DetailProductTrxes
        //        .Where(x => x.HeaderTrx.Date >= start && x.HeaderTrx.Date <= end)
        //        .Select(x => new {x.TrxId, x.HeaderTrx.Date})
        //        .Distinct()
        //        .ToList();

        //    var headers = new List<HeaderTrxViewModel>();

        //    foreach (var i in headerTrxes)
        //    {
        //        var totalSellPrice = 0;
        //        var totalProfit = 0;
        //        var detailTrxes = context.DetailProductTrxes
        //            .Where(x => x.TrxId == i.TrxId)
        //            .ToList();

        //        foreach (var d in detailTrxes)
        //        {
        //            totalSellPrice += d.SellPrice;
        //            totalProfit += d.SellPrice - d.BuyPrice;
        //        }

        //        var header = new HeaderTrxViewModel()
        //        {
        //            TrxID = i.TrxId,
        //            Date = i.Date,
        //            Price = totalSellPrice,
        //            Profit = totalProfit,
        //        };
        //        headers.Add(header);
        //    }

        //    var profit = 0;
        //    var sellPrice = 0;

        //    foreach (var i in headers)
        //    {
        //        profit += i.Profit;
        //        sellPrice += i.Price;
        //    }

        //    var addition = new HeaderTrxViewModel()
        //    {
        //        TrxID = "Total",
        //        Profit = profit,
        //        Price = sellPrice
        //    };

        //    headers.Add(addition);

        //    dgvHeader.DataSource = headers.Select(x => new
        //    {
        //        colID = x.TrxID,
        //        colDate = x.Date,
        //        colTotalPrice = SnippetCurrency.ConvertCurrency(x.Price),
        //        colTotalProfit = SnippetCurrency.ConvertCurrency(x.Profit)
        //    }).ToList();
        //}

        private void LoadDetailProducts(string trxId)
        {
            var context = new db();
            var detailTrxes = context.DetailProductTrxes
                .Where(x => x.TrxId == trxId);

            var details = new List<DetailTrxViewModel>();

            foreach (var d in detailTrxes)
            {
                var subtotal = d.Qty * d.SellPrice;
                var profit = subtotal - (d.Qty * d.BuyPrice);

                var detail = new DetailTrxViewModel()
                {
                    Name = d.Product.Name,
                    Qty = d.Qty,
                    BuyPrice = d.BuyPrice,
                    SellPrice = d.SellPrice,
                    Subtotal = subtotal,
                    Profit = profit
                };
                details.Add(detail);
            }

            dgvDetail.DataSource = details.Select(x => new
            {
                colName = x.Name,
                colQty = x.Qty,
                colBuy = SnippetCurrency.ConvertCurrency(x.BuyPrice),
                colSellPrice = SnippetCurrency.ConvertCurrency(x.SellPrice),
                colSubtotal = SnippetCurrency.ConvertCurrency(x.Subtotal),
                colProfit = SnippetCurrency.ConvertCurrency(x.Profit)
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
            LoadDetailProducts(trxId);
        }

        private void DetailTrxProductForm_Load(object sender, EventArgs e)
        {
            LoadHeaderProducts();
        }
    }
}
