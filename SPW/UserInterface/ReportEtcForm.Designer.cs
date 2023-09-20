namespace SPW.UserInterface
{
    partial class ReportEtcForm
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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // iBtnPrint
            // 
            this.iBtnPrint.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.iBtnPrint.IconColor = System.Drawing.Color.Transparent;
            this.iBtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnPrint.IconSize = 24;
            this.iBtnPrint.Location = new System.Drawing.Point(671, 8);
            this.iBtnPrint.Name = "iBtnPrint";
            this.iBtnPrint.Size = new System.Drawing.Size(79, 21);
            this.iBtnPrint.TabIndex = 11;
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
            this.cBoxTrx.Location = new System.Drawing.Point(13, 9);
            this.cBoxTrx.Name = "cBoxTrx";
            this.cBoxTrx.Size = new System.Drawing.Size(121, 21);
            this.cBoxTrx.TabIndex = 10;
            this.cBoxTrx.SelectedIndexChanged += new System.EventHandler(this.cBoxTrx_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPrice});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(10, 50);
            this.dgv.Margin = new System.Windows.Forms.Padding(10);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(743, 438);
            this.dgv.TabIndex = 9;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "colId";
            this.colId.FillWeight = 38.07107F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "colName";
            this.colName.FillWeight = 130.9645F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "colPrice";
            this.colPrice.FillWeight = 130.9645F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // ReportEtcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.iBtnPrint);
            this.Controls.Add(this.cBoxTrx);
            this.Controls.Add(this.dgv);
            this.Name = "ReportEtcForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(763, 498);
            this.Load += new System.EventHandler(this.ReportEtcForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnPrint;
        private System.Windows.Forms.ComboBox cBoxTrx;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}
