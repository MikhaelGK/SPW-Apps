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
    public partial class InputProductForm : Form
    {
        string prdtId;
        string operation;
        int statusId;

        public InputProductForm(string operation, string prdtId, int statusId)
        {
            InitializeComponent();
            this.operation = operation;
            this.prdtId = prdtId;
            this.statusId = statusId;
        }

        private bool Validation()
        {
            #region Validate All Field

            if (String.IsNullOrWhiteSpace(tBoxName.Text) || String.IsNullOrWhiteSpace(tBoxBuyPrice.Text)
                || String.IsNullOrWhiteSpace(tBoxSellPrice.Text))
            {
                SnippetMbox.MboxWarning("All field must be filled", "Product");
                return false;
            }

            #endregion

            #region Validate Buy Price Numeric

            var buyPrice = tBoxBuyPrice.Text;
            var validBuyPrice = true;
            foreach (var c in buyPrice)
            {
                if (char.IsLetter(c))
                {
                    validBuyPrice = false;
                }
            }
            if (!validBuyPrice)
            {
                SnippetMbox.MboxError("Buy Price field must be numeric", "Product");
                return false;
            }

            #endregion

            #region Validate Sell Price Numeric

            var sellPrice = tBoxSellPrice.Text;
            var validSellPrice = true;
            foreach (var c in sellPrice)
            {
                if (char.IsLetter(c))
                {
                    validSellPrice = false;
                }
            }
            if (!validSellPrice)
            {
                SnippetMbox.MboxError("Sell Price field must be numeric", "Product");
                return false;
            }

            #endregion

            labError.Visible = false;
            return true;
        }

        private void Add()
        {
            var context = new db();
            var status = context.Status
                .FirstOrDefault(x => x.StatusId == statusId);
            var product = new Product()
            {
                ProductId = tBoxProductID.Text,
                Name = tBoxName.Text,
                BuyPrice = Convert.ToInt32(tBoxBuyPrice.Text),
                SellPrice = Convert.ToInt32(tBoxSellPrice.Text),
                Stock = 0,
                StatusId = status.StatusId
            };
            context.Products.Add(product);
            context.SaveChanges();
        }

        private new void Update()
        {
            var context = new db();
            var product = context.Products.Where(x => x.ProductId == prdtId).FirstOrDefault();
            product.Name = tBoxName.Text;
            product.BuyPrice = Convert.ToInt32(tBoxBuyPrice.Text);
            product.SellPrice = Convert.ToInt32(tBoxSellPrice.Text);
            context.SaveChanges();
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

            if (operation == "Add") Add();
            if (operation == "Update") Update();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InputProductForm_Load(object sender, EventArgs e)
        {
            labError.Visible = false;
            ActiveControl = tBoxName;
            tBoxName.Focus();
            if (operation == "Add")
            {
                tBoxProductID.Text = SnippetGenerator.GeneratorID(5, 2);
            }

            if (operation == "Update")
            {
                var context = new db();
                var product = context.Products.FirstOrDefault(x => x.ProductId == prdtId);
                tBoxProductID.Text = product.ProductId;
                tBoxName.Text = product.Name;
                tBoxBuyPrice.Text = product.BuyPrice.ToString();
                tBoxSellPrice.Text = product.SellPrice.ToString();
            }
        }
    }
}
