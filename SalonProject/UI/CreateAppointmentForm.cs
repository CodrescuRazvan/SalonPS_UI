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
    public partial class CreateAppointmentForm : Form
    {
        AppointmentService _appointmentService;
        public CreateAppointmentForm()
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _appointmentService.createAppointment(dateTimeTB.Text, clientNameTB.Text, phoneNoTB.Text, serviesTB.Text);
                MessageBox.Show("Query executed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void serviesTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
