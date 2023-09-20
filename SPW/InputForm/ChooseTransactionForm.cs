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
    public partial class ChooseTransactionForm : Form
    {
        TransactionViewModel viewmodel;

        public ChooseTransactionForm()
        {
            InitializeComponent();
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            var inputProduct = new InputTransactionProductForm();
            if (inputProduct.ShowDialog() == DialogResult.OK)
            {
                viewmodel = inputProduct.GetTransaction();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void iBtnEtc_Click(object sender, EventArgs e)
        {
            var inputEtcera = new InputTransactionEtceraForm();
            if (inputEtcera.ShowDialog() == DialogResult.OK)
            {
                viewmodel = inputEtcera.GetTransaction();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public TransactionViewModel GetTransaction()
        {
            return viewmodel;
        }

        private void iBtnProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void iBtnEtc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
