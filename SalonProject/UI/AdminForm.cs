using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonProject.Service;

namespace SalonProject.UI
{
    public partial class AdminForm : Form
    {
        ServicesService _service;
        public AdminForm()
        {
            InitializeComponent();
            _service = new ServicesService();
        }

        private void createEmployeeBtn_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm create = new CreateEmployeeForm();
            create.Show();
            this.Close();
        }

        private void createServiceBtn_Click(object sender, EventArgs e)
        {
            CreateServiceForm create = new CreateServiceForm();
            create.Show();
            this.Close();
        }

        private void viewClientAppointmentBtn_Click(object sender, EventArgs e)
        {
            ViewClientAppointmentsForm view = new ViewClientAppointmentsForm();
            view.Show();
            this.Close();
        }

        private void viewBetweenDatesBtn_Click(object sender, EventArgs e)
        {
            ViewAllAppointmentsForm view = new ViewAllAppointmentsForm();
            view.Show();
            this.Close();
        }

        private void viewServiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> rez = _service.viewServices();
                var message = String.Join(Environment.NewLine, rez);
                MessageBox.Show(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
