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
        Logic.EmployeeLogic employeeLogic;
        public UserManagementForm(Employee employee)
        {
            InitializeComponent();
<<<<<<< Updated upstream
            this.employee = employee; 
=======
            this.employee = employee;
            employeeLogic = new Logic.EmployeeLogic();
            GetAllEmployees();
            passwordTxtBox.PasswordChar = '*';
>>>>>>> Stashed changes
        }

        public void GetAllEmployees()
        {
            List<Employee> employees = employeeLogic.GetEmployees();
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.PhoneNumber);
                item.SubItems.Add(employee.LocationBranch);
                item.SubItems.Add(employee.Username);
                listViewUsers.Items.Add(item);
            }
        }

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

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            SearchBtn.Visible = false;
            CreateNewUserPanel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CreateNewUserPanel.Visible = false;
            SearchBtn.Visible = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (AreRequiredFieldsFilled()) {
                Employee employee = new Employee();

                employee.FirstName = FirstNameTxtBox.Text;
                employee.LastName = LastNameTxtBox.Text;
                employee.Email = emailAddressTxtBox.Text;
                employee.PhoneNumber = phoneNumberTxtBox.Text;
                employee.IsSuperDesk = SuperDeskCheckBox.Checked;
                employee.LocationBranch = locationTxtBox.Text;
                employee.Password = BCrypt.Net.BCrypt.HashPassword(passwordTxtBox.Text);
                employee.Username = UsernameTxtBox.Text;

                employeeLogic.AddEmployee(employee);

                // Show confirmation message
                ShowConfirmationForm("Employee added successfully!");

                // Clear textboxes
                ClearTextBoxes();
            }
        }

        private bool AreRequiredFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(emailAddressTxtBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTxtBox.Text) ||
                string.IsNullOrWhiteSpace(locationTxtBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTxtBox.Text) ||
                string.IsNullOrWhiteSpace(UsernameTxtBox.Text))
            {
                MessageBox.Show("Please fill out all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ShowConfirmationForm(string message)
        {
            MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearTextBoxes()
        {
            FirstNameTxtBox.Text = string.Empty;
            LastNameTxtBox.Text = string.Empty;
            emailAddressTxtBox.Text = string.Empty;
            phoneNumberTxtBox.Text = string.Empty;
            SuperDeskCheckBox.Checked = false;
            locationTxtBox.Text = string.Empty;
            passwordTxtBox.Text = string.Empty;
            UsernameTxtBox.Text = string.Empty;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (filterByEmailTxtBox.Text == "")
            {
                GetAllEmployees();
            }
            else
            {
                // Clear existing items in the ListView
                listViewUsers.Items.Clear();

                // Query the database for employees with the specified email
                List<Employee> filteredEmployees = employeeLogic.GetEmployeeByEmail(filterByEmailTxtBox.Text);

                if (filteredEmployees.Count == 0)
                {
                    MessageBox.Show("No employees found with the specified email.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Display the filtered employees in the ListView
                foreach (Employee emp in filteredEmployees)
                {
                    ListViewItem item = new ListViewItem(emp.Id.ToString());
                    item.SubItems.Add(emp.Email);
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.PhoneNumber);
                    item.SubItems.Add(emp.IsSuperDesk.ToString());
                    item.SubItems.Add(emp.LocationBranch);
                    item.SubItems.Add(emp.Username);

                    listViewUsers.Items.Add(item);
                }
            }
        }
    }
}
