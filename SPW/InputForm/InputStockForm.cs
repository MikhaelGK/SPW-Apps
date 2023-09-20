using SPW.Snippet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPW.InputForm
{
    public partial class InputStockForm : Form
    {
        string prdtId;
        bool isFound;

        public InputStockForm(string prdtId)
        {
            InitializeComponent();
            this.prdtId = prdtId;
        }

        private bool Validation()
        {
            #region Validate All Field

            if (tBoxStock.Text == "")
            {
                SnippetMbox.MboxWarning("All field must be filled", "Stock");
                return false;
            }

            #endregion

            #region Validate Stock

            var validStock = true;
            foreach (var c in tBoxStock.Text)
            {
                if (char.IsLetter(c))
                {
                    validStock = false;
                }
            }
            if (!validStock)
            {
                SnippetMbox.MboxError("Stock must be numeric", "Stock");
                return false;
            }

            #endregion

            labError.Visible = false;
            return true;
        }

        private bool FindData(DateTime date)
        {
            var context = new db();
            var stock = context.DetailStocks
                .Where(x => x.ProductId == prdtId && x.Date == date).ToList();
            if (stock.Count == 0) return false;

            return true;
        }

        private void InputStockForm_Load(object sender, EventArgs e)
        {
            tBoxProductID.Text = prdtId;
            var date = DateTime.Now;
            isFound = FindData(date);
            if (isFound)
            {
                var context = new db();
                var stock = context.DetailStocks
                    .FirstOrDefault(x => x.ProductId == prdtId && x.Date == date);
                tBoxStock.Text = stock.Stock.ToString();
            }

            ActiveControl = tBoxStock;
            tBoxStock.Focus();
            labError.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = Validation();
            if (!valid) return;

            var context = new db();
            if (isFound)
            {
                #region Update stock

                var date = DateTime.Now;
                var stock = context.DetailStocks.FirstOrDefault(x => x.ProductId == prdtId && x.Date == date);
                stock.Stock += Convert.ToInt32(tBoxStock.Text);
                stock.Product.Stock += Convert.ToInt32(tBoxStock.Text);

                #endregion
            }
            else
            {
                #region Add new stock

                var stock = new DetailStock()
                {
                    ProductId = prdtId,
                    Date = DateTime.Now,
                    Stock = Convert.ToInt32(tBoxStock.Text)
                };
                context.DetailStocks.Add(stock);

                var product = context.Products.Where(x => x.ProductId == prdtId).FirstOrDefault();
                product.Stock += Convert.ToInt32(tBoxStock.Text);

                #endregion
            }
            context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
