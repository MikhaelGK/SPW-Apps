using SPW.InputForm;
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
    public partial class ManageDailyProductForm : UserControl
    {
        List<ManageDailyProductViewModel> manage = new List<ManageDailyProductViewModel>();
        DateTime today = DateTime.Now.Date;

        public ManageDailyProductForm()
        {
            InitializeComponent();
        }

        private List<int> LoadStores(Product product)
        {
            var context = new db();
            var stores = new List<int>();
            var store = context.DetailStocks
                .Where(x => x.ProductId == product.ProductId).ToList();
            foreach (var s in store)
            {
                if (s.Date.Date == today) stores.Add(s.Stock);
            }
            return stores;
        }

        private List<int> CountingTake(Product products)
        {
            var context = new db();
            var takes = new List<int>();
            var take = 0;
            var details = context.DetailProductTrxes
                .Where(x => x.ProductId == products.ProductId)
                .ToList();
            foreach (var d in details)
            {
                if (d.HeaderTrx.Date.Date == today)
                {
                    take += d.Qty;
                    takes.Add(take);
                }
            }
            return takes;
        }

        private void RefreshForm()
        {
            manage.Clear();
            var context = new db();
            var products = context.Products.Where(x => x.StatusId == 1).ToList();

            var stores = new List<int>();
            var takes = new List<int>();

            for (int i = 0; i < products.Count; i++)
            {
                stores = LoadStores(products[i]);
                takes = CountingTake(products[i]);

                var store = stores.Count == 0 ? 0 : stores.Sum();
                var take = takes.Count == 0 ? 0 : takes.Sum();
                var product = new ManageDailyProductViewModel()
                {
                    ProductID = products[i].ProductId,
                    Name = products[i].Name,
                    BuyPrice = products[i].BuyPrice,
                    SellPrice = products[i].SellPrice,
                    Store = store,
                    Take = take,
                    Total = take * products[i].BuyPrice
                };
                manage.Add(product);
            }



            var total = 0;
            foreach (var i in manage)
            {
                total += i.Total;
            }

            var addition = new ManageDailyProductViewModel()
            {
                ProductID = "Total",
                Total = total
            };
            manage.Add(addition);

            dgvManage.DataSource = manage.Select(x => new
            {
                colID = x.ProductID,
                colName = x.Name,
                colStr = x.Store,
                colTke = x.Take,
                colBuy = SnippetCurrency.ConvertCurrency(x.BuyPrice),
                colPrice = SnippetCurrency.ConvertCurrency(x.SellPrice),
                colPay = SnippetCurrency.ConvertCurrency(x.Total)
            }).ToList();
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var context = new db();

            dgvManage.DataSource = manage
                .Where(x => x.ProductID.Contains(tBoxSearch.Text) || x.Name.Contains(tBoxSearch.Text))
                .Select(x => new
                {
                    colID = x.ProductID,
                    colName = x.Name,
                    colStr = x.Store,
                    colTke = x.Take,
                    colBuy = SnippetCurrency.ConvertCurrency(x.BuyPrice),
                    colPrice = SnippetCurrency.ConvertCurrency(x.SellPrice),
                    colPay = SnippetCurrency.ConvertCurrency(x.Total)
                }).ToList();
        }

        private void ManageProductForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            labError.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var input = new InputProductForm("Add", "", 1);

            if (input.ShowDialog() == DialogResult.OK)
            {
                RefreshForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvManage.CurrentRow;
            if (selectedRow == null)
            {
                labError.Visible = true;
                return;
            }
            labError.Visible = false;
            var productId = selectedRow.Cells[0].Value.ToString();

            var input = new InputProductForm("Update", productId, 1);

            if (input.ShowDialog() == DialogResult.OK)
            {
                RefreshForm();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvManage.CurrentRow;
            if (selectedRow == null)
            {
                labError.Visible = true;
                return;
            }
            labError.Visible = false;

            var prdtId = selectedRow.Cells[0].Value.ToString();
            var add = new InputStockForm(prdtId);

            if (add.ShowDialog() == DialogResult.OK)
            {
                RefreshForm();
            }
        }
    }
}
