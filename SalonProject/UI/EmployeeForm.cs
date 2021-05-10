using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonProject.UI
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void createAppointmentBtn_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm create = new CreateAppointmentForm();
            create.Show();
            this.Close();
        }

        private void viewAppointmentBtn_Click(object sender, EventArgs e)
        {
            ViewAppointmentForm view = new ViewAppointmentForm();
            view.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
