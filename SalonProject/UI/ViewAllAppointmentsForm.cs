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
    public partial class ViewAllAppointmentsForm : Form
    {
        AppointmentService _appointment;
        public ViewAllAppointmentsForm()
        {
            InitializeComponent();
            _appointment = new AppointmentService();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> rez = _appointment.viewBetweenDates(firstDateTB.Text, secondDateTB.Text);
                var message = String.Join(Environment.NewLine, rez);
                MessageBox.Show(message);

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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
