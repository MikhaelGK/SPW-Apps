﻿namespace SPW.InputForm
{
    partial class InputTransactionProductForm
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
            this.s = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxPrice = new System.Windows.Forms.TextBox();
            this.tBoxQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxProductID = new System.Windows.Forms.TextBox();
            this.iBtnBrowse = new FontAwesome.Sharp.IconButton();
            this.labError = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.39535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.60465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.s, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBoxName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBoxPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBoxQty, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBoxProductID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iBtnBrowse, 2, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 187);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // s
            // 
            this.s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(3, 0);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.s.Size = new System.Drawing.Size(91, 46);
            this.s.TabIndex = 0;
            this.s.Text = "Product ID";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(91, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(91, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxName
            // 
            this.tBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxName.Location = new System.Drawing.Point(100, 56);
            this.tBoxName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tBoxName.Multiline = true;
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.ReadOnly = true;
            this.tBoxName.Size = new System.Drawing.Size(354, 22);
            this.tBoxName.TabIndex = 5;
            // 
            // tBoxPrice
            // 
            this.tBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPrice.Location = new System.Drawing.Point(100, 102);
            this.tBoxPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tBoxPrice.Multiline = true;
            this.tBoxPrice.Name = "tBoxPrice";
            this.tBoxPrice.ReadOnly = true;
            this.tBoxPrice.Size = new System.Drawing.Size(354, 22);
            this.tBoxPrice.TabIndex = 6;
            // 
            // tBoxQty
            // 
            this.tBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxQty.Location = new System.Drawing.Point(100, 148);
            this.tBoxQty.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tBoxQty.Multiline = true;
            this.tBoxQty.Name = "tBoxQty";
            this.tBoxQty.Size = new System.Drawing.Size(354, 24);
            this.tBoxQty.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(91, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxProductID
            // 
            this.tBoxProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxProductID.Location = new System.Drawing.Point(100, 10);
            this.tBoxProductID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tBoxProductID.Name = "tBoxProductID";
            this.tBoxProductID.ReadOnly = true;
            this.tBoxProductID.Size = new System.Drawing.Size(354, 23);
            this.tBoxProductID.TabIndex = 4;
            // 
            // iBtnBrowse
            // 
            this.iBtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnBrowse.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBtnBrowse.IconColor = System.Drawing.Color.Black;
            this.iBtnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBrowse.IconSize = 26;
            this.iBtnBrowse.Location = new System.Drawing.Point(460, 3);
            this.iBtnBrowse.Name = "iBtnBrowse";
            this.iBtnBrowse.Size = new System.Drawing.Size(54, 40);
            this.iBtnBrowse.TabIndex = 10;
            this.iBtnBrowse.UseVisualStyleBackColor = true;
            this.iBtnBrowse.Click += new System.EventHandler(this.iBtnBrowse_Click);
            // 
            // labError
            // 
            this.labError.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(10, 224);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(202, 29);
            this.labError.TabIndex = 11;
            this.labError.Text = "All field must be filled";
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(307, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(424, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InputTransactionProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 262);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputTransactionProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputTransactionProductForm";
            this.Load += new System.EventHandler(this.InputTransactionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxPrice;
        private System.Windows.Forms.TextBox tBoxQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxProductID;
        private FontAwesome.Sharp.IconButton iBtnBrowse;
        private System.Windows.Forms.Label labError;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}