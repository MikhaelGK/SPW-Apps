using SPW.InputForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPW.UserInterface
{
    public partial class DetailEmployeeForm : UserControl
    {
        public DetailEmployeeForm()
        {
            InitializeComponent();
        }

        private new void Refresh()
        {
            var context = new db();
            var users = context.Employees.ToList();
            dgvEmployee.DataSource = users.Select(x => new
            {
                colID = x.EmployeeId,
                colName = x.Name,
                colUsername = x.Username,
                colEmail = x.Email,
                colRole = x.Role.Name
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var input = new InputEmployeeForm("");
            if (input.ShowDialog() == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void DetailEmployeeForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dgvEmployee.CurrentRow;
            if (selected == null)
            {
                return;
            }

            var context = new db();
            var id = selected.Cells[0].Value.ToString();
            var user = context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            context.Employees.Remove(user);
            context.SaveChanges();
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selected = dgvEmployee.CurrentRow;
            if (selected == null) return;

            var id = selected.Cells[0].Value.ToString();

            var input = new InputEmployeeForm(id);
            if (input.ShowDialog() == DialogResult.OK)
            {
                Refresh();
            }
        }
    }
}
