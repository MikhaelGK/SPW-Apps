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

namespace SPW.InputForm
{
    public partial class InputTransactionProductForm : Form
    {
        int maxQty = 0;
        TransactionViewModel viewmodel;

        public InputTransactionProductForm()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            #region Validate All Field

            if (tBoxProductID.Text == "" || tBoxQty.Text == "")
            {
                SnippetMbox.MboxError("All field must be filled", "Transaction");
                return false;
            }

            #endregion

            #region Validate Qty

            var validQty = true;
            foreach (var c in tBoxQty.Text)
            {
                if (char.IsLetter(c))
                {
                    validQty = false;
                }
            }
            if (!validQty)
            {
                SnippetMbox.MboxError("Stock must be numeric", "Transaction");
                return false;
            }

            #endregion

            return true;
        }

        private void InputTransactionForm_Load(object sender, EventArgs e)
        {
            labError.Visible = false;
        }

        private void iBtnBrowse_Click(object sender, EventArgs e)
        {
            var choose = new ChooseProductForm();
            if (choose.ShowDialog() == DialogResult.OK)
            {
                var context = new db();
                var prdtId = choose.GetProductId();
                var product = context.Products.FirstOrDefault(x => x.ProductId == prdtId);

                maxQty = product.Stock;
                tBoxProductID.Text = product.ProductId;
                tBoxName.Text = product.Name;
                tBoxPrice.Text = product.SellPrice.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = Validation();
            if (!valid) return;

            var context = new db();
            var price = Convert.ToInt32(tBoxPrice.Text);
            var qty = Convert.ToInt32(tBoxQty.Text);
            if (qty > maxQty)
            {
                SnippetMbox.MboxError("Qty exceed the stock", "Transaction");
                return;
            }

            viewmodel = new TransactionViewModel()
            {
                Name = tBoxName.Text,
                Price = price,
                Qty = qty,
                Subtotal = price * qty
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public TransactionViewModel GetTransaction()
        {
            return viewmodel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
