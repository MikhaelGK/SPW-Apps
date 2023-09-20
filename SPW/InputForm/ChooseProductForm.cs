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
    public partial class ChooseProductForm : Form
    {
        List<ManageProductViewModel> manage = new List<ManageProductViewModel>();
        string prdtId;

        public ChooseProductForm()
        {
            InitializeComponent();
        }

        private void RefreshForm()
        {
            manage.Clear();
            var context = new db();
            var products = context.Products.ToList();
            for (int i = 0; i < products.Count; i++)
            {
                var product = new ManageProductViewModel()
                {
                    ProductID = products[i].ProductId,
                    Name = products[i].Name,
                    Stock = products[i].Stock,
                    BuyPrice = products[i].BuyPrice,
                    SellPrice = products[i].SellPrice
                };
                manage.Add(product);
            }

            dgvManage.DataSource = manage.Select(x => new
            {
                colID = x.ProductID,
                colName = x.Name,
                colStock = x.Stock,
                colPrice = x.SellPrice
            }).ToList();
        }

        private void iBtnClear_Click(object sender, EventArgs e)
        {
            tBoxSearch.Clear();
        }

        private void ChooseProductForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
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
                    colPrice = x.SellPrice
                }).ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvManage.CurrentRow;
            if (selectedRow == null) return;


            var stock = Convert.ToInt32(selectedRow.Cells[3].Value);
            if (stock == 0)
            {
                SnippetMbox.MboxError("Cannot add transaction because stock is 0", "Transaction");
                return;
            }


            prdtId = selectedRow.Cells[1].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string GetProductId()
        {
            return prdtId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
