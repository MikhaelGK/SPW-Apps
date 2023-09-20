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
    public partial class InputTransactionEtceraForm : Form
    {
        TransactionViewModel viewmodel;

        public InputTransactionEtceraForm()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            #region Validate All Field

            if (tBoxName.Text == "" || tBoxPrice.Text == "" || tBoxQty.Text == "" || cBoxType.Text == "")
            {
                SnippetMbox.MboxWarning("All field must be filled", "Transaction");
                return false;
            }

            #endregion

            #region Validate Qty

            var validQty = true;
            foreach (var c in tBoxQty.Text)
            {
                if (!char.IsDigit(c))
                {
                    validQty = false;
                }
            }
            if (!validQty)
            {
                SnippetMbox.MboxError("Qty must be numeric", "Transaction");
                return false;
            }

            #endregion

            #region Validate Price

            var validPrice = true;
            foreach (var c in tBoxPrice.Text)
            {
                if (!char.IsDigit(c))
                {
                    validPrice = false;
                }
            }
            if (!validPrice)
            {
                SnippetMbox.MboxError("Price must be numeric", "Transaction");
                return false;
            }

            #endregion

            labError.Visible = false;
            return true;
        }

        private void InputTransactionForm_Load(object sender, EventArgs e)
        {
            labError.Visible = false;

            var context = new db();
            var outlays = context.Types.ToList();

            foreach (var i in outlays)
            {
                if (i.Name == "Product") continue;

                cBoxType.Items.Add(i.Name);
            }

            cBoxType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = Validation();
            if (!valid) return;

            var price = Convert.ToInt32(tBoxPrice.Text);
            var qty = Convert.ToInt32(tBoxQty.Text);
            var typeName = cBoxType.Text;

            var context = new db();
            var type = context.Types.FirstOrDefault(x => x.Name == typeName);
            if (type.CashFlow == "OUT") price *= -1;

            viewmodel = new TransactionViewModel()
            {
                Name = tBoxName.Text,
                Price = price,
                Qty = qty,
                Type = type.Name,
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
