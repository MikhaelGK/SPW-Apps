using FontAwesome.Sharp;
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
    enum report { daily, monthly }

    public partial class ReportForm : UserControl
    {
        private IconButton currentButton;
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                // Button 
                currentButton = (IconButton)sender;
                currentButton.BackColor = ColorTranslator.FromHtml("#21314d");

                // Side Panel
                SidePanel.Location = new Point(currentButton.Location.X, 0);
                SidePanel.Visible = true;
                SidePanel.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = ColorTranslator.FromHtml("#131c2b");
                SidePanel.Visible = false;
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            currentButton = iBtnProduct;
            panelContent.Controls.Clear();
            var panel = new ReportProductForm();
            panelContent.Controls.Add(panel);
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);

            panelContent.Controls.Clear();
            var panel = new ReportProductForm();
            panelContent.Controls.Add(panel);
        }

        private void iBtnEtc_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);

            panelContent.Controls.Clear();
            var panel = new ReportEtcForm();
            panelContent.Controls.Add(panel);
        }
    }
}
