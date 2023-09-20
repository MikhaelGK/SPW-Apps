namespace SPW.UserInterface
{
    partial class ManageForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.iBtnStock = new FontAwesome.Sharp.IconButton();
            this.iBtnDaily = new FontAwesome.Sharp.IconButton();
            this.panelManager = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.iBtnStock);
            this.panel1.Controls.Add(this.iBtnDaily);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 53);
            this.panel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.SidePanel.Location = new System.Drawing.Point(13, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(152, 10);
            this.SidePanel.TabIndex = 21;
            this.SidePanel.Visible = false;
            // 
            // iBtnStock
            // 
            this.iBtnStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iBtnStock.FlatAppearance.BorderSize = 0;
            this.iBtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.iBtnStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnStock.IconColor = System.Drawing.Color.Black;
            this.iBtnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnStock.Location = new System.Drawing.Point(171, 0);
            this.iBtnStock.Name = "iBtnStock";
            this.iBtnStock.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iBtnStock.Size = new System.Drawing.Size(152, 50);
            this.iBtnStock.TabIndex = 1;
            this.iBtnStock.Text = "Simpan";
            this.iBtnStock.UseVisualStyleBackColor = true;
            this.iBtnStock.Click += new System.EventHandler(this.iBtnStock_Click);
            // 
            // iBtnDaily
            // 
            this.iBtnDaily.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iBtnDaily.FlatAppearance.BorderSize = 0;
            this.iBtnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDaily.ForeColor = System.Drawing.Color.Gainsboro;
            this.iBtnDaily.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnDaily.IconColor = System.Drawing.Color.Black;
            this.iBtnDaily.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDaily.Location = new System.Drawing.Point(13, 0);
            this.iBtnDaily.Name = "iBtnDaily";
            this.iBtnDaily.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iBtnDaily.Size = new System.Drawing.Size(152, 50);
            this.iBtnDaily.TabIndex = 0;
            this.iBtnDaily.Text = "Harian";
            this.iBtnDaily.UseVisualStyleBackColor = true;
            this.iBtnDaily.Click += new System.EventHandler(this.iBtnDaily_Click);
            // 
            // panelManager
            // 
            this.panelManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManager.Location = new System.Drawing.Point(0, 53);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(763, 493);
            this.panelManager.TabIndex = 2;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.panelManager);
            this.Controls.Add(this.panel1);
            this.Name = "ManageForm";
            this.Size = new System.Drawing.Size(763, 546);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private FontAwesome.Sharp.IconButton iBtnStock;
        private FontAwesome.Sharp.IconButton iBtnDaily;
        private System.Windows.Forms.Panel panelManager;
    }
}
