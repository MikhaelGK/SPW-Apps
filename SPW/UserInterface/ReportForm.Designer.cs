namespace SPW.UserInterface
{
    partial class ReportForm
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
            this.iBtnEtc = new FontAwesome.Sharp.IconButton();
            this.iBtnProduct = new FontAwesome.Sharp.IconButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.iBtnEtc);
            this.panel1.Controls.Add(this.iBtnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 48);
            this.panel1.TabIndex = 4;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.SidePanel.Location = new System.Drawing.Point(10, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(152, 10);
            this.SidePanel.TabIndex = 6;
            // 
            // iBtnEtc
            // 
            this.iBtnEtc.FlatAppearance.BorderSize = 0;
            this.iBtnEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnEtc.ForeColor = System.Drawing.Color.Gainsboro;
            this.iBtnEtc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnEtc.IconColor = System.Drawing.Color.Black;
            this.iBtnEtc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEtc.Location = new System.Drawing.Point(168, -1);
            this.iBtnEtc.Name = "iBtnEtc";
            this.iBtnEtc.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iBtnEtc.Size = new System.Drawing.Size(152, 48);
            this.iBtnEtc.TabIndex = 1;
            this.iBtnEtc.Text = "Etc";
            this.iBtnEtc.UseVisualStyleBackColor = true;
            this.iBtnEtc.Click += new System.EventHandler(this.iBtnEtc_Click);
            // 
            // iBtnProduct
            // 
            this.iBtnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(77)))));
            this.iBtnProduct.FlatAppearance.BorderSize = 0;
            this.iBtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.iBtnProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnProduct.IconColor = System.Drawing.Color.Black;
            this.iBtnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProduct.Location = new System.Drawing.Point(10, 0);
            this.iBtnProduct.Name = "iBtnProduct";
            this.iBtnProduct.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iBtnProduct.Size = new System.Drawing.Size(152, 46);
            this.iBtnProduct.TabIndex = 0;
            this.iBtnProduct.Text = "Product";
            this.iBtnProduct.UseVisualStyleBackColor = false;
            this.iBtnProduct.Click += new System.EventHandler(this.iBtnProduct_Click);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 48);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(763, 498);
            this.panelContent.TabIndex = 5;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "ReportForm";
            this.Size = new System.Drawing.Size(763, 546);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private FontAwesome.Sharp.IconButton iBtnEtc;
        private FontAwesome.Sharp.IconButton iBtnProduct;
        private System.Windows.Forms.Panel panelContent;
    }
}
