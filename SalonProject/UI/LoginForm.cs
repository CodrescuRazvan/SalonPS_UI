using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonProject.Model;
using SalonProject.Service;

namespace SalonProject.UI
{
    public partial class LoginForm : Form
    {
        UserService _user;
        public LoginForm()
        {
            InitializeComponent();
            _user = new UserService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _user.login(usernameTB.Text, passwordTB.Text);
                if (user.getRole().Trim().Equals("employee"))
                {
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                    this.Hide();
                }
                else if (user.getRole().Trim().Equals("admin"))
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
