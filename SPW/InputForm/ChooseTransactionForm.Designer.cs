namespace SPW.InputForm
{
    partial class ChooseTransactionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iBtnEtc = new FontAwesome.Sharp.IconButton();
            this.iBtnProduct = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.iBtnEtc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iBtnProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 226);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // iBtnEtc
            // 
            this.iBtnEtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnEtc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnEtc.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.iBtnEtc.IconColor = System.Drawing.Color.Black;
            this.iBtnEtc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEtc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnEtc.Location = new System.Drawing.Point(204, 3);
            this.iBtnEtc.Name = "iBtnEtc";
            this.iBtnEtc.Size = new System.Drawing.Size(196, 220);
            this.iBtnEtc.TabIndex = 1;
            this.iBtnEtc.Text = "Etc";
            this.iBtnEtc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnEtc.UseVisualStyleBackColor = true;
            this.iBtnEtc.Click += new System.EventHandler(this.iBtnEtc_Click);
            this.iBtnEtc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iBtnEtc_KeyDown);
            // 
            // iBtnProduct
            // 
            this.iBtnProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnProduct.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iBtnProduct.IconColor = System.Drawing.Color.Black;
            this.iBtnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnProduct.Location = new System.Drawing.Point(3, 3);
            this.iBtnProduct.Name = "iBtnProduct";
            this.iBtnProduct.Size = new System.Drawing.Size(195, 220);
            this.iBtnProduct.TabIndex = 0;
            this.iBtnProduct.Text = "Product";
            this.iBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnProduct.UseVisualStyleBackColor = true;
            this.iBtnProduct.Click += new System.EventHandler(this.iBtnProduct_Click);
            this.iBtnProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iBtnProduct_KeyDown);
            // 
            // ChooseTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseTransactionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iBtnEtc;
        private FontAwesome.Sharp.IconButton iBtnProduct;
    }
}