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
    public partial class TransactionForm : UserControl
    {
        List<TransactionViewModel> trx = new List<TransactionViewModel>();
        string trxId;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            var total = 0;
            foreach (var i in trx)
            {
                total += i.Subtotal;
            }
            labTotal.Text = SnippetCurrency.ConvertCurrency(total);

            dgvManage.DataSource = trx.Select(x => new
            {
                colName = x.Name,
                colQty = x.Qty,
                colPrice = SnippetCurrency.ConvertCurrency(x.Price),
                colType = x.Type,
                colSubtotal = SnippetCurrency.ConvertCurrency(x.Subtotal)
            }).ToList();
        }

        private void AddProductTrx(TransactionViewModel trx)
        {
            var context = new db();
            var product = context.Products.Where(x => x.Name == trx.Name).FirstOrDefault();
            var detail = new DetailProductTrx()
            {
                TrxId = trxId,
                ProductId = product.ProductId,
                Qty = trx.Qty,
                BuyPrice = product.BuyPrice,
                SellPrice = product.SellPrice
            };
            context.DetailProductTrxes.Add(detail);

            product.Stock -= trx.Qty;

            context.SaveChanges();
        }

        private void AddEtceraTrx(TransactionViewModel trx)
        {
            var context = new db();
            var type = context.Types.Where(x => x.Name == trx.Type).FirstOrDefault();
            var detail = new DetailEtcTrx()
            {
                TrxId = trxId,
                Info = trx.Name,
                Price = trx.Price,
                TypeId = type.TypeId
            };
            context.DetailEtcTrxes.Add(detail);
            context.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var choose = new ChooseTransactionForm();
            if (choose.ShowDialog() == DialogResult.OK)
            {
                var viewmodel = choose.GetTransaction();

                foreach (var i in trx)
                {
                    if (i.Name == viewmodel.Name)
                    {
                        i.Qty += viewmodel.Qty;
                        i.Subtotal = i.Qty * i.Price;
                        LoadForm();
                        return;
                    }
                }

                trx.Add(viewmodel);
                LoadForm();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvManage.CurrentRow;
            if (selectedRow == null)
            {
                SnippetMbox.MboxError("There is no row selected", "Transaction");
                return;
            }

            var name = selectedRow.Cells[0].Value.ToString();
            var selectedTrx = trx.FirstOrDefault(x => x.Name == name);
            trx.Remove(selectedTrx);
            LoadForm();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            labTotal.Text = "Total";
            trxId = SnippetGenerator.GeneratorID(5, 1);
            var context = new db();
            var headerTrx = new HeaderTrx()
            {
                TrxId = trxId,
                Date = DateTime.Now,
            };
            context.HeaderTrxes.Add(headerTrx);
            context.SaveChanges();

            foreach (var i in trx)
            {
                if (i.Type == null) AddProductTrx(i);
                else AddEtceraTrx(i);
            }

            labTotal.Text = "Total";
            trx.Clear();
            dgvManage.DataSource = trx;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            labError.Visible = false;
        }
    }
}
