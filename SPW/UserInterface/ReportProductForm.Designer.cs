namespace SPW.UserInterface
{
    partial class ReportProductForm
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
            this.iBtnPrint = new FontAwesome.Sharp.IconButton();
            this.cBoxTrx = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnPrint
            // 
            this.iBtnPrint.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.iBtnPrint.IconColor = System.Drawing.Color.Transparent;
            this.iBtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnPrint.IconSize = 24;
            this.iBtnPrint.Location = new System.Drawing.Point(674, 8);
            this.iBtnPrint.Name = "iBtnPrint";
            this.iBtnPrint.Size = new System.Drawing.Size(79, 21);
            this.iBtnPrint.TabIndex = 8;
            this.iBtnPrint.Text = "Print";
            this.iBtnPrint.UseVisualStyleBackColor = true;
            this.iBtnPrint.Click += new System.EventHandler(this.iBtnPrint_Click);
            // 
            // cBoxTrx
            // 
            this.cBoxTrx.FormattingEnabled = true;
            this.cBoxTrx.Items.AddRange(new object[] {
            "Day",
            "Month"});
            this.cBoxTrx.Location = new System.Drawing.Point(13, 8);
            this.cBoxTrx.Name = "cBoxTrx";
            this.cBoxTrx.Size = new System.Drawing.Size(121, 21);
            this.cBoxTrx.TabIndex = 7;
            this.cBoxTrx.SelectedIndexChanged += new System.EventHandler(this.cBoxTrx_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colQty,
            this.colBuy,
            this.colSell,
            this.colSubtotal,
            this.colProfit});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(10, 50);
            this.dgv.Margin = new System.Windows.Forms.Padding(10);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(743, 438);
            this.dgv.TabIndex = 6;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "colID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "colName";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "colQty";
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            // 
            // colBuy
            // 
            this.colBuy.DataPropertyName = "colBuy";
            this.colBuy.HeaderText = "Buy Price";
            this.colBuy.MinimumWidth = 6;
            this.colBuy.Name = "colBuy";
            // 
            // colSell
            // 
            this.colSell.DataPropertyName = "colSell";
            this.colSell.HeaderText = "Sell Price";
            this.colSell.MinimumWidth = 6;
            this.colSell.Name = "colSell";
            // 
            // colSubtotal
            // 
            this.colSubtotal.DataPropertyName = "colSubtotal";
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            // 
            // colProfit
            // 
            this.colProfit.DataPropertyName = "colProfit";
            this.colProfit.HeaderText = "Profit";
            this.colProfit.MinimumWidth = 6;
            this.colProfit.Name = "colProfit";
            // 
            // ReportProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.iBtnPrint);
            this.Controls.Add(this.cBoxTrx);
            this.Controls.Add(this.dgv);
            this.Name = "ReportProductForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(763, 498);
            this.Load += new System.EventHandler(this.ReportProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnPrint;
        private System.Windows.Forms.ComboBox cBoxTrx;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfit;
    }
}
