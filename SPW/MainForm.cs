using FontAwesome.Sharp;
using SPW.UserInterface;
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

namespace SPW
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                // Button
                currentButton = (IconButton)sender;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.BackColor = ColorTranslator.FromHtml("#3d4654");

                // Side Panel
                SidePanel.Location = new Point(0, currentButton.Location.Y);
                SidePanel.Visible = true;
                SidePanel.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                // Button
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.BackColor = ColorTranslator.FromHtml("#232830");

                // Side Panel
                SidePanel.Visible = false;
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            SidePanel.Visible = false;
            iBtnReport.Visible = true;

            var home = new HomeForm();
            panelFeature.Controls.Add(home);

            var role = LoginViewModel.Role;
            if (role == 3)
            {
                iBtnReport.Visible = false;
                iBtnTransaction.Visible = false;
                iBtnPrint.Visible = false;
            }

            var username = LoginViewModel.Username;
            labUsername.Text = "Hi, " + username;
        }

        private void iBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iBtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            panelFeature.Controls.Clear();
            DisableButton();
            ActivateButton(sender);

            var manage = new ManageForm();
            panelFeature.Controls.Add(manage);
        }

        private void iBtnTransaction_Click(object sender, EventArgs e)
        {
            panelFeature.Controls.Clear();
            DisableButton();
            ActivateButton(sender);

            var trx = new TransactionForm();
            panelFeature.Controls.Add(trx);
        }

        private void iBtnRnP_Click(object sender, EventArgs e)
        {
            panelFeature.Controls.Clear();
            DisableButton();
            ActivateButton(sender);

            var report = new ReportForm();
            panelFeature.Controls.Add(report);
        }

        private void iBtnDetail_Click(object sender, EventArgs e)
        {
            panelFeature.Controls.Clear();
            DisableButton();
            ActivateButton(sender);

            var detail = new DetailForm();
            panelFeature.Controls.Add(detail);
        }

        private void iBtnProfile_Click(object sender, EventArgs e)
        {
            panelFeature.Controls.Clear();
            DisableButton();
            currentButton = null;
            var home = new HomeForm();
            panelFeature.Controls.Add(home);
        }
    }
}
