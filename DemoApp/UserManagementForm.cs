using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class UserManagementForm : Form
    {
        Employee employee;
        public UserManagementForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void buttonIncidentManagement_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(employee);
            dashboardForm.Show();
            this.Hide();
        }
    }
}
