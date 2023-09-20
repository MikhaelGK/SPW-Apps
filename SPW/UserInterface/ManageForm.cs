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
    public partial class ManageForm : UserControl
    {
        private IconButton currentButton;

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                currentButton = (IconButton)sender;
                currentButton.BackColor = ColorTranslator.FromHtml("#21314d ");
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


        private void iBtnStock_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);

            panelManager.Controls.Clear();
            var panel = new ManageStockProductForm();
            panelManager.Controls.Add(panel);
        }

        private void iBtnDaily_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender);

            panelManager.Controls.Clear();
            var panel = new ManageDailyProductForm();
            panelManager.Controls.Add(panel);
        }
    }
}
