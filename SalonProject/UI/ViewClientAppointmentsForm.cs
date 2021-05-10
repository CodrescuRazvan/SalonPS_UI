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
    public partial class ViewClientAppointmentsForm : Form
    {
        AppointmentService _appointment;
        public ViewClientAppointmentsForm()
        {
            InitializeComponent();
            _appointment = new AppointmentService();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Close();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> rez = _appointment.viewAppointmentClient(clientNameTB.Text);
                var message = String.Join(Environment.NewLine, rez);
                MessageBox.Show(message);
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

        private void clientNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
