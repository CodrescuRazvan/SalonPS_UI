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
    public partial class CreateEmployeeForm : Form
    {
        UserService _user;
        public CreateEmployeeForm()
        {
            InitializeComponent();
            _user = new UserService();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _user.createEmployee(nameTB.Text, usernameTB.Text, passwordTB.Text);
                MessageBox.Show("Query executed!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Close();
        }
    }
}
