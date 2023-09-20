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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            tBoxUsername.Clear();
            tBoxPassword.Clear();
        }

        private bool Validation()
        {
            #region Validation Filled Text Box

            if (String.IsNullOrWhiteSpace(tBoxUsername.Text) && String.IsNullOrWhiteSpace(tBoxPassword.Text))
            {
                labValidUsername.Text = "Username must be filled";
                labValidPassword.Text = "Password must be filled";
                labValidUsername.Visible = true;
                labValidPassword.Visible = true;
                return false;
            }

            if (String.IsNullOrWhiteSpace(tBoxUsername.Text))
            {
                labValidUsername.Text = "Username must be filled";
                labValidUsername.Visible = true;
                return false;
            }

            if (String.IsNullOrWhiteSpace(tBoxPassword.Text))
            {
                labValidPassword.Text = "Password must be filled";
                labValidPassword.Visible = true;
                return false;
            }
            labValidUsername.Visible = false;
            labValidPassword.Visible = false;

            #endregion

            #region Validation Username and Password

            var context = new db();
            var user = context.Employees.Where(x => x.Username == tBoxUsername.Text).FirstOrDefault();

            if (user == null)
            {
                ClearInput();
                labValidUsername.Text = "Username not found";
                labValidUsername.Visible = true;
                return false;
            }
            labValidUsername.Visible = false;
            if (user.Password != tBoxPassword.Text)
            {
                ClearInput();
                labValidPassword.Text = "Invalid Password";
                labValidPassword.Visible = true;
                return false;
            }
            labValidPassword.Visible = false;

            #endregion

            LoginViewModel.ID = user.EmployeeId;
            LoginViewModel.Name = user.Name;
            LoginViewModel.Username = user.Username;
            LoginViewModel.Email = user.Email;
            LoginViewModel.Password = user.Password;
            LoginViewModel.Role = user.Role.RoleId;

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var valid = Validation();


                tBoxUsername.Text = "Username";
                tBoxPassword.UseSystemPasswordChar = false;
                tBoxPassword.Text = "Password";

                if (!valid) return;

                var context = new db();
                var lastLoginDate = (DateTime)Properties.Settings.Default["Login"];
                if (lastLoginDate < DateTime.Today)
                {
                    var products = context.Products
                        .Where(x => x.Status.Name == "DAILY").ToList();
                    foreach (var item in products)
                    {
                        item.Stock = 0;
                        context.SaveChanges();
                    }

                    Properties.Settings.Default["Login"] = DateTime.Today;
                    Properties.Settings.Default.Save();
                }

                this.Hide();

                var main = new MainForm();

                main.FormClosed += delegate
                {
                    this.Show();
                };

                main.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region Focus UI

        private void tBoxUsername_Enter(object sender, EventArgs e)
        {
            tBoxUsername.Clear();
        }
        private void tBoxUsername_Leave(object sender, EventArgs e)
        {
            if (tBoxUsername.Text == "")
            {
                tBoxUsername.Text = "Username";
            }
        }
        private void tBoxPassword_Enter(object sender, EventArgs e)
        {
            tBoxPassword.Clear();
            tBoxPassword.UseSystemPasswordChar = true;
        }
        private void tBoxPassword_Leave(object sender, EventArgs e)
        {
            if (tBoxPassword.Text == "")
            {
                tBoxPassword.UseSystemPasswordChar = false;
                tBoxPassword.Text = "Password";
            }
        }

        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void iBtnVisibility_Click(object sender, EventArgs e)
        {
            if (tBoxPassword.UseSystemPasswordChar) iBtnVisibility.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
            else iBtnVisibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;

        }
    }
}
