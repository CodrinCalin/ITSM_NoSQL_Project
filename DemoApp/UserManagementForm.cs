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
        
        //      --------------------------------------------------
        //
        //  VEZI CA FIECARE EMPLOYEE SA AIBA USERNAME UNICAT
        //  SA FACI ENCRIPTIE CU BCRYPT LA PAROLA INAINTE SA ADAUGI IN BAZA DE DATE
        //
        //
        //
        //  ----------------------------------------------
        private void buttonIncidentManagement_Click(object sender, EventArgs e)
        {
            IncidentManagementForm incidentManagementForm = new IncidentManagementForm(employee);
            incidentManagementForm.Show();
            this.Hide();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(employee);
            dashboardForm.Show();
            this.Hide();
        }
    }
}
