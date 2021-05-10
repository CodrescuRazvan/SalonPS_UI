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
    public partial class CreateServiceForm : Form
    {
        ServicesService _service;
        public CreateServiceForm()
        {
            InitializeComponent();
            _service = new ServicesService();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _service.createServices(oldNameTB.Text, float.Parse(oldPriceTB.Text));
                MessageBox.Show("Query executed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(servicePriceTB.Text.Equals(""))
                    _service.updateServices(serviceNameTB.Text, 0.0f, oldNameTB.Text, 0.0f);
                else
                    _service.updateServices(serviceNameTB.Text, float.Parse(servicePriceTB.Text), oldNameTB.Text, 0.0f);
                MessageBox.Show("Query executed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _service.deleteServices(oldNameTB.Text);
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

        private void oldPriceTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
