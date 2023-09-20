using SPW.Snippet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPW.InputForm
{
    public partial class InputEmployeeForm : Form
    {
        string employeeId;

        public InputEmployeeForm(string id)
        {
            InitializeComponent();
            this.employeeId = id;
        }

        #region Validation

        private Regex PasswordValidation()
        {
            var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            return new Regex(pattern);
        }

        private bool Validation()
        {
            #region Validate All Field

            if (tBoxName.Text == "" || tBoxUsername.Text == "" || tBoxEmail.Text == "" || tBoxPassword.Text == "")
            {
                SnippetMbox.MboxWarning("All field must be filled", "Employee");
                return false;
            }

            #endregion

            #region Validate Email

            try
            {
                var m = new MailAddress(tBoxEmail.Text);
            }
            catch (Exception ex)
            {
                SnippetMbox.MboxError("Invalid Format Email", "Employee");
                return false;
            }

            #endregion

            #region Validate Password

            var validatePassword = PasswordValidation();
            if (validatePassword.IsMatch(tBoxPassword.Text) != true)
            {
                SnippetMbox.MboxError("Password must be atleast 8 character and contains uppercase, lowercase, number, and not use symbol", "Employee");
                return false;
            }

            #endregion

            return true;
        }

        #endregion

        private void Add()
        {
            var context = new db();

            var userdb = context.Employees.Where(x => x.Email == tBoxEmail.Text).FirstOrDefault();
            if (userdb != null)
            {
                SnippetMbox.MboxError("Email exist", "Employee");
                return;
            }

            var role = context.Roles.Where(x => x.Name == cBoxRole.Text).FirstOrDefault();
            var user = new Employee()
            {
                Name = tBoxName.Text,
                Username = tBoxUsername.Text,
                Email = tBoxEmail.Text,
                Password = tBoxPassword.Text,
                RoleId = role.RoleId
            };
            context.Employees.Add(user);
            context.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private new void Update()
        {
            var context = new db();
            var role = context.Roles.Where(x => x.Name == cBoxRole.Text).FirstOrDefault();
            var user = context.Employees.Where(x => x.Email == tBoxEmail.Text).FirstOrDefault();
            user.Name = tBoxName.Text;
            user.Username = tBoxUsername.Text;
            user.Email = tBoxEmail.Text;
            user.Password = tBoxPassword.Text;
            user.RoleId = role.RoleId;
            context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InputEmployeeForm_Load(object sender, EventArgs e)
        {
            cBoxRole.SelectedIndex = 0;
            labError.Visible = false;

            if (employeeId != "")
            {
                var context = new db();
                var user = context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
                tBoxName.Text = user.Name;
                tBoxUsername.Text = user.Username;
                tBoxEmail.Text = user.Email;
                tBoxPassword.Text = user.Password;
                cBoxRole.Text = user.Role.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = Validation();
            if (!valid) return;

            if (employeeId == "") Add();
            else Update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
