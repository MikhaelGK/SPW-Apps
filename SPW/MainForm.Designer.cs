namespace SPW
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.iBtnPrint = new FontAwesome.Sharp.IconButton();
            this.iBtnLogout = new FontAwesome.Sharp.IconButton();
            this.iBtnExit = new FontAwesome.Sharp.IconButton();
            this.iBtnReport = new FontAwesome.Sharp.IconButton();
            this.iBtnTransaction = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labUsername = new System.Windows.Forms.Label();
            this.iBtnProfile = new FontAwesome.Sharp.IconButton();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.iBtnProduct = new FontAwesome.Sharp.IconButton();
            this.panelFeature = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.iBtnPrint);
            this.panel4.Controls.Add(this.iBtnLogout);
            this.panel4.Controls.Add(this.iBtnExit);
            this.panel4.Controls.Add(this.iBtnReport);
            this.panel4.Controls.Add(this.iBtnTransaction);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.SidePanel);
            this.panel4.Controls.Add(this.iBtnProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 546);
            this.panel4.TabIndex = 12;
            // 
            // iBtnPrint
            // 
            this.iBtnPrint.FlatAppearance.BorderSize = 0;
            this.iBtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnPrint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnPrint.ForeColor = System.Drawing.Color.White;
            this.iBtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iBtnPrint.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnPrint.IconSize = 24;
            this.iBtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnPrint.Location = new System.Drawing.Point(0, 318);
            this.iBtnPrint.Name = "iBtnPrint";
            this.iBtnPrint.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnPrint.Size = new System.Drawing.Size(179, 53);
            this.iBtnPrint.TabIndex = 12;
            this.iBtnPrint.Text = "Print";
            this.iBtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnPrint.UseVisualStyleBackColor = true;
            this.iBtnPrint.Click += new System.EventHandler(this.iBtnRnP_Click);
            // 
            // iBtnLogout
            // 
            this.iBtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iBtnLogout.FlatAppearance.BorderSize = 0;
            this.iBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnLogout.ForeColor = System.Drawing.Color.White;
            this.iBtnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iBtnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnLogout.IconSize = 24;
            this.iBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnLogout.Location = new System.Drawing.Point(0, 450);
            this.iBtnLogout.Name = "iBtnLogout";
            this.iBtnLogout.Size = new System.Drawing.Size(182, 48);
            this.iBtnLogout.TabIndex = 11;
            this.iBtnLogout.Text = "Logout";
            this.iBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnLogout.UseVisualStyleBackColor = true;
            this.iBtnLogout.Click += new System.EventHandler(this.iBtnLogout_Click);
            // 
            // iBtnExit
            // 
            this.iBtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iBtnExit.FlatAppearance.BorderSize = 0;
            this.iBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnExit.ForeColor = System.Drawing.Color.White;
            this.iBtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iBtnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnExit.IconSize = 24;
            this.iBtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnExit.Location = new System.Drawing.Point(0, 498);
            this.iBtnExit.Name = "iBtnExit";
            this.iBtnExit.Size = new System.Drawing.Size(182, 48);
            this.iBtnExit.TabIndex = 10;
            this.iBtnExit.Text = "Exit";
            this.iBtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnExit.UseVisualStyleBackColor = true;
            this.iBtnExit.Click += new System.EventHandler(this.iBtnExit_Click);
            // 
            // iBtnReport
            // 
            this.iBtnReport.FlatAppearance.BorderSize = 0;
            this.iBtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnReport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnReport.ForeColor = System.Drawing.Color.White;
            this.iBtnReport.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.iBtnReport.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnReport.IconSize = 24;
            this.iBtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnReport.Location = new System.Drawing.Point(0, 377);
            this.iBtnReport.Name = "iBtnReport";
            this.iBtnReport.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnReport.Size = new System.Drawing.Size(179, 53);
            this.iBtnReport.TabIndex = 9;
            this.iBtnReport.Text = "Report";
            this.iBtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnReport.UseVisualStyleBackColor = true;
            this.iBtnReport.Click += new System.EventHandler(this.iBtnDetail_Click);
            // 
            // iBtnTransaction
            // 
            this.iBtnTransaction.FlatAppearance.BorderSize = 0;
            this.iBtnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnTransaction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnTransaction.ForeColor = System.Drawing.Color.White;
            this.iBtnTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.iBtnTransaction.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnTransaction.IconSize = 24;
            this.iBtnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnTransaction.Location = new System.Drawing.Point(0, 259);
            this.iBtnTransaction.Name = "iBtnTransaction";
            this.iBtnTransaction.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnTransaction.Size = new System.Drawing.Size(179, 53);
            this.iBtnTransaction.TabIndex = 8;
            this.iBtnTransaction.Text = "Transaction";
            this.iBtnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnTransaction.UseVisualStyleBackColor = true;
            this.iBtnTransaction.Click += new System.EventHandler(this.iBtnTransaction_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labUsername);
            this.panel5.Controls.Add(this.iBtnProfile);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 183);
            this.panel5.TabIndex = 4;
            // 
            // labUsername
            // 
            this.labUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.labUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.White;
            this.labUsername.Location = new System.Drawing.Point(0, 129);
            this.labUsername.Name = "labUsername";
            this.labUsername.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labUsername.Size = new System.Drawing.Size(182, 54);
            this.labUsername.TabIndex = 1;
            this.labUsername.Text = "Hi, Username";
            // 
            // iBtnProfile
            // 
            this.iBtnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtnProfile.FlatAppearance.BorderSize = 0;
            this.iBtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnProfile.ForeColor = System.Drawing.Color.White;
            this.iBtnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iBtnProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProfile.IconSize = 70;
            this.iBtnProfile.Location = new System.Drawing.Point(0, 0);
            this.iBtnProfile.Name = "iBtnProfile";
            this.iBtnProfile.Size = new System.Drawing.Size(182, 129);
            this.iBtnProfile.TabIndex = 0;
            this.iBtnProfile.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iBtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnProfile.UseVisualStyleBackColor = true;
            this.iBtnProfile.Click += new System.EventHandler(this.iBtnProfile_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(217)))), ((int)(((byte)(94)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 200);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 53);
            this.SidePanel.TabIndex = 3;
            // 
            // iBtnProduct
            // 
            this.iBtnProduct.FlatAppearance.BorderSize = 0;
            this.iBtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnProduct.ForeColor = System.Drawing.Color.White;
            this.iBtnProduct.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iBtnProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProduct.IconSize = 24;
            this.iBtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnProduct.Location = new System.Drawing.Point(3, 200);
            this.iBtnProduct.Name = "iBtnProduct";
            this.iBtnProduct.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnProduct.Size = new System.Drawing.Size(179, 53);
            this.iBtnProduct.TabIndex = 7;
            this.iBtnProduct.Text = "Product";
            this.iBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnProduct.UseVisualStyleBackColor = true;
            this.iBtnProduct.Click += new System.EventHandler(this.iBtnProduct_Click);
            // 
            // panelFeature
            // 
            this.panelFeature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.panelFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeature.Location = new System.Drawing.Point(182, 0);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(763, 546);
            this.panelFeature.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 546);
            this.Controls.Add(this.panelFeature);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iBtnPrint;
        private FontAwesome.Sharp.IconButton iBtnLogout;
        private FontAwesome.Sharp.IconButton iBtnExit;
        private FontAwesome.Sharp.IconButton iBtnReport;
        private FontAwesome.Sharp.IconButton iBtnTransaction;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labUsername;
        private FontAwesome.Sharp.IconButton iBtnProfile;
        private System.Windows.Forms.Panel SidePanel;
        private FontAwesome.Sharp.IconButton iBtnProduct;
        private System.Windows.Forms.Panel panelFeature;
    }
}