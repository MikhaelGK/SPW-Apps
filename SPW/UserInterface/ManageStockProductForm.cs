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
    public partial class ManageStockProductForm : UserControl
    {
        List<ManageProductViewModel> manage = new List<ManageProductViewModel>();
        public ManageStockProductForm()
        {
            InitializeComponent();
        }

        private void RefreshForm()
        {
            manage.Clear();
            var context = new db();
            var products = context.Products.Where(x => x.StatusId == 2).ToList();
            for (int i = 0; i < products.Count; i++)
            {
                var product = new ManageProductViewModel()
                {
                    ProductID = products[i].ProductId,
                    Name = products[i].Name,
                    Stock = products[i].Stock,
                    BuyPrice = products[i].BuyPrice,
                    SellPrice = products[i].SellPrice,
                    Total = products[i].SellPrice * products[i].Stock
                };
                manage.Add(product);
            }

            var total = 0;
            foreach (var i in manage)
            {
                total += i.Total;
            }

            var addition = new ManageProductViewModel()
            {
                ProductID = "Total",
                Total = total
            };
            manage.Add(addition);

            dgvManage.DataSource = manage.Select(x => new
            {
                colID = x.ProductID,
                colName = x.Name,
                colStock = x.Stock,
                colBuyPrice = SnippetCurrency.ConvertCurrency(x.BuyPrice),
                colPrice = SnippetCurrency.ConvertCurrency(x.SellPrice),
                colPay = SnippetCurrency.ConvertCurrency(x.Total)
            }).ToList();
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvManage.DataSource = manage
                .Where(x => x.ProductID.Contains(tBoxSearch.Text) || x.Name.Contains(tBoxSearch.Text))
                .Select(x => new
                {
                    colID = x.ProductID,
                    colName = x.Name,
                    colStock = x.Stock,
                    colBuyPrice = SnippetCurrency.ConvertCurrency(x.BuyPrice),
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
            var input = new InputProductForm("Add", "", 2);

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

            var input = new InputProductForm("Update", productId, 2);

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
