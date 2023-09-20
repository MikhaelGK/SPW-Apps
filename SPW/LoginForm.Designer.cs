namespace SPW
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iBtnVisibility = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labValidPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labValidUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.iPicPassword = new FontAwesome.Sharp.IconPictureBox();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.iPicProfile = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPicPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPicProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 137);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "SPW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "SMK TUNAS HARAPAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iBtnVisibility
            // 
            this.iBtnVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.iBtnVisibility.ForeColor = System.Drawing.Color.Gainsboro;
            this.iBtnVisibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iBtnVisibility.IconColor = System.Drawing.Color.Gainsboro;
            this.iBtnVisibility.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnVisibility.IconSize = 28;
            this.iBtnVisibility.Location = new System.Drawing.Point(258, 276);
            this.iBtnVisibility.Name = "iBtnVisibility";
            this.iBtnVisibility.Size = new System.Drawing.Size(28, 28);
            this.iBtnVisibility.TabIndex = 22;
            this.iBtnVisibility.TabStop = false;
            this.iBtnVisibility.Click += new System.EventHandler(this.iBtnVisibility_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(36, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 18;
            // 
            // labValidPassword
            // 
            this.labValidPassword.BackColor = System.Drawing.Color.Transparent;
            this.labValidPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValidPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labValidPassword.Location = new System.Drawing.Point(67, 306);
            this.labValidPassword.Name = "labValidPassword";
            this.labValidPassword.Size = new System.Drawing.Size(213, 14);
            this.labValidPassword.TabIndex = 21;
            this.labValidPassword.Text = "Incorrect Password";
            this.labValidPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labValidPassword.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(36, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 15;
            // 
            // labValidUsername
            // 
            this.labValidUsername.BackColor = System.Drawing.Color.Transparent;
            this.labValidUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValidUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labValidUsername.Location = new System.Drawing.Point(67, 255);
            this.labValidUsername.Name = "labValidUsername";
            this.labValidUsername.Size = new System.Drawing.Size(213, 14);
            this.labValidUsername.TabIndex = 20;
            this.labValidUsername.Text = "Username not found";
            this.labValidUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labValidUsername.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Location = new System.Drawing.Point(116, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 35);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBoxPassword.Location = new System.Drawing.Point(70, 280);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(182, 19);
            this.tBoxPassword.TabIndex = 17;
            this.tBoxPassword.Text = "Password";
            this.tBoxPassword.Enter += new System.EventHandler(this.tBoxPassword_Enter);
            this.tBoxPassword.Leave += new System.EventHandler(this.tBoxPassword_Leave);
            // 
            // iPicPassword
            // 
            this.iPicPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.iPicPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.iPicPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iPicPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.iPicPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPicPassword.IconSize = 28;
            this.iPicPassword.Location = new System.Drawing.Point(36, 276);
            this.iPicPassword.Name = "iPicPassword";
            this.iPicPassword.Size = new System.Drawing.Size(28, 28);
            this.iPicPassword.TabIndex = 16;
            this.iPicPassword.TabStop = false;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBoxUsername.Location = new System.Drawing.Point(70, 229);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(216, 19);
            this.tBoxUsername.TabIndex = 14;
            this.tBoxUsername.Text = "Username";
            this.tBoxUsername.Enter += new System.EventHandler(this.tBoxUsername_Enter);
            this.tBoxUsername.Leave += new System.EventHandler(this.tBoxUsername_Leave);
            // 
            // iPicProfile
            // 
            this.iPicProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.iPicProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.iPicProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iPicProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.iPicProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPicProfile.IconSize = 28;
            this.iPicProfile.Location = new System.Drawing.Point(36, 228);
            this.iPicProfile.Name = "iPicProfile";
            this.iPicProfile.Size = new System.Drawing.Size(28, 28);
            this.iPicProfile.TabIndex = 13;
            this.iPicProfile.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(324, 461);
            this.Controls.Add(this.iBtnVisibility);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labValidPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labValidUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.iPicPassword);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.iPicProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPicPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPicProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iBtnVisibility;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labValidPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labValidUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tBoxPassword;
        private FontAwesome.Sharp.IconPictureBox iPicPassword;
        private System.Windows.Forms.TextBox tBoxUsername;
        private FontAwesome.Sharp.IconPictureBox iPicProfile;
    }
}