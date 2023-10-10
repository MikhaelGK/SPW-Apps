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
    public partial class DetailStockForm : UserControl
    {
        DateTime start;
        DateTime end;
        string prdtName;

        public DetailStockForm()
        {
            InitializeComponent();
        }

        private int CountingHistoryStore()
        {
            var context = new db();
            var storeOrder = context.DetailStocks.Where(x => x.Date < start && x.Product.Name == prdtName).ToList();
            var takeOrder = context.DetailProductTrxes.Where(x => x.HeaderTrx.Date < start && x.Product.Name == prdtName).ToList();
            var total = 0;

            if (storeOrder.Count != 0)
            {
                total = storeOrder.Sum(x => x.Stock) - takeOrder.Sum(x => x.Qty);
            }


            //if (storeBefore.Count != 0)
            //{


            //    var storeFirstDate = storeBefore[0].Date;
            //    var diff = start.Subtract(storeFirstDate).TotalDays;

            //    for (int i = 0; i < takeBefore.Count; i++)
            //    {
            //        var date = storeFirstDate.AddDays(i);
            //        var rdDate = date.Date;
            //        var ruDate = rdDate.AddDays(1).AddSeconds(-1);
            //        var stock = storeBefore.Where(x => x.Date > rdDate && x.Date < ruDate).Sum(x => x.Stock);
            //        var qty = takeBefore.Where(x => x.HeaderTrx.Date >= date).Sum(x => x.Qty);
            //        total += stock - qty;
            //    }
            //}

            return total;
        }

        private List<DetailStockViewModel> CountingProductDaily()
        {
            var context = new db();
            var details = new List<DetailStockViewModel>();
            var firstDate = context.DetailStocks.Where(x => x.Product.Name == prdtName).Select(x => x.Date).FirstOrDefault();
            var diff = Math.Ceiling(end.Subtract(start).TotalDays);

            for (int i = 0; i < diff; i++)
            {
                var rangeDate = start.AddDays(i);
                if (rangeDate < firstDate.Date) continue;

                var store = LoadStore(rangeDate);

                var take = LoadTakes(rangeDate);

                var rest = store - take;

                var detail = new DetailStockViewModel()
                {
                    Name = prdtName,
                    Date = Convert.ToDateTime(rangeDate.ToString("yyyy-MM-dd")),
                    Store = store,
                    Take = take,
                    Rest = rest
                };
                details.Add(detail);
            }

            return details;
        }

        private List<DetailStockViewModel> CountingProductStock()
        {
            var context = new db();
            var firstDate = context.DetailStocks.Where(x => x.Product.Name == prdtName).Select(x => x.Date).FirstOrDefault();
            var details = new List<DetailStockViewModel>();

            var diff = Math.Ceiling(end.Subtract(start).TotalDays);
            var rest = 0;
            var stockBefore = CountingHistoryStore();


            // Get Store, Take, Rest data
            // depend on every date
            // between start date and end date
            for (int i = 0; i < diff; i++)
            {
                var date = start.AddDays(i);

                if (date < firstDate.Date) continue;

                var store = LoadStore(date);
                var take = LoadTakes(date);

                if (i == 0) store += stockBefore;


                //if (date.ToString("yyyy-MM-dd") == "2023-08-11")
                //{
                //    SnippetMbox.MboxInformation(stockBefore.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(store.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(take.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(rest.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(date.ToString("yyyy/MM/dd"), "Checking");
                //}

                //if (date.ToString("yyyy-MM-dd") == "2023-08-10")
                //{
                //    SnippetMbox.MboxInformation(stockBefore.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(store.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(take.ToString(), "Checking");
                //    SnippetMbox.MboxInformation(rest.ToString(), "Checking");
                //}

                if (rest != 0) store += rest;

                rest = store - take;


                var detail = new DetailStockViewModel()
                {
                    Name = prdtName,
                    Date = Convert.ToDateTime(date.ToString("yyyy-MM-dd")),
                    Store = store,
                    Take = take,
                    Rest = rest
                };
                details.Add(detail);
            }

            return details;
        }

        private int LoadStore(DateTime date)
        {
            var details = new List<StockViewModel>();
            var context = new db();

            // Get all date of all details in the range
            var stocks = context.DetailStocks
                .Where(x => x.Product.Name == prdtName &&
                    x.Date >= start && x.Date <= end).ToList();

            foreach (var stock in stocks)
            {
                // Fill the stock data to view model
                var stockVM = new StockViewModel()
                {
                    Name = stock.Product.Name,
                    Date = stock.Date,
                    Stock = stock.Stock
                };
                details.Add(stockVM);
            }
            return details.Where(x => x.Date.Date == date).Sum(x => x.Stock);
        }

        private int LoadTakes(DateTime date)
        {
            var details = new List<StockViewModel>();
            var context = new db();

            // Get all transaction qty
            var takes = context.DetailProductTrxes
                .Where(x => x.HeaderTrx.Date >= start && x.HeaderTrx.Date <= end && x.Product.Name == prdtName)
                .ToList();

            foreach (var t in takes)
            {
                // Fill all qty data to view model
                var detail = new StockViewModel()
                {
                    Name = t.Product.Name,
                    Date = t.HeaderTrx.Date,
                    Stock = t.Qty
                };
                details.Add(detail);
            }
            return details.Where(x => x.Date.Date == date).Sum(x => x.Stock);
        }

        private void DataLoaded()
        {
            var context = new db();
            var type = context.Products
                .Where(x => x.Name == prdtName)
                .Select(x => x.StatusId).FirstOrDefault();
            var details = new List<DetailStockViewModel>();

            if (type == 1) details = CountingProductDaily();
            if (type == 2) details = CountingProductStock();

            dgvStock.DataSource = details.Select(x => new
            {
                colName = x.Name,
                colDate = x.Date.ToString("dddd, dd MMMM yyyy"),
                colStore = x.Store,
                colTake = x.Take,
                colRest = x.Rest
            }).ToList();
        }

        private void DetailStockForm_Load(object sender, EventArgs e)
        {
            start = Convert.ToDateTime(dtpStart.Value.ToString("yyyy-MM-dd"));
            end = Convert.ToDateTime(dtpEnd.Value.ToString("yyyy-MM-dd"));
            end = end.AddDays(1).AddSeconds(-1);

            var context = new db();
            var products = context.Products.Select(x => x.Name).Distinct().ToList();
            foreach (var p in products)
            {
                cBoxProduct.Items.Add(p);
            }
            cBoxProduct.SelectedIndex = 0;
            prdtName = cBoxProduct.Text;
            DataLoaded();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            start = Convert.ToDateTime(dtpStart.Value.ToString("yyyy-MM-dd"));
            DataLoaded();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            end = Convert.ToDateTime(dtpEnd.Value.ToString("yyyy-MM-dd"));
            DataLoaded();
        }

        private void cBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            prdtName = cBoxProduct.Text;
            DataLoaded();
        }
    }
}
