using Logic;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoApp
{
    public partial class CreateTicketForm : Form
    {
        private Employee employee;

        private TicketLogic ticketLogic;

        private EmployeeLogic employeeLogic;

        public event EventHandler TicketCreated;

        public CreateTicketForm(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            ticketLogic = new TicketLogic();
            employeeLogic = new EmployeeLogic();

            loadUI();
        }

        private void loadUI()
        {
            // Set default values for deadline and priority
            deadlineBox.SelectedIndex = 0;
            priorityBox.SelectedIndex = 1;

            // Set limits for hours
            numericUpDownHours.Minimum = 0;
            numericUpDownHours.Maximum = 23;

            // Set limits for minutes
            numericUpDownMinutes.Minimum = 0;
            numericUpDownMinutes.Maximum = 59;

            DateTime currentTime = DateTime.Now;
            numericUpDownHours.Value = currentTime.Hour;
            numericUpDownMinutes.Value = currentTime.Minute;

            displayUsers();
        }

        private void displayUsers()
        {
            if (!employee.IsSuperDesk)
            {
                var comboBoxItem = new Tuple<string, Employee>(employee.FirstName, employee);
                employeeBox.Items.Add(comboBoxItem);
                employeeBox.DisplayMember = "Item1";
                employeeBox.SelectedItem = comboBoxItem;
                employeeBox.Enabled = false;
            }
            else
            {
                List<Employee> employees = employeeLogic.GetEmployees();
                foreach (Employee e in employees)
                {
                    var comboBoxItem = new Tuple<string, Employee>(e.FirstName, e);
                    employeeBox.Items.Add(comboBoxItem);
                }
                employeeBox.DisplayMember = "Item1";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            ProcessTicket();
        }

        private void ProcessTicket()
        {
            DateTime reportedDateTime = reportedDatePicker.Value.Date;
            int hours = Convert.ToInt32(numericUpDownHours.Value);
            int minutes = Convert.ToInt32(numericUpDownMinutes.Value);
            reportedDateTime = reportedDateTime.AddHours(hours);
            reportedDateTime = reportedDateTime.AddMinutes(minutes);

            TicketPriority priority = (TicketPriority)Enum.Parse(typeof(TicketPriority), priorityBox.SelectedItem.ToString());
            string selectedDeadline = deadlineBox.SelectedItem.ToString();
            DateTime deadline = CalculateDeadline(reportedDateTime, selectedDeadline);

            string subject = subjectOfIncidentBox.Text.Trim();
            string type = typeOfIncidentBox.Text.Trim();
            string description = descriptionBox.Text.Trim();
            string userID = userIDBox.Text.Trim();

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(userID) || employeeBox.SelectedItem == null)
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Console.WriteLine(employeeBox.SelectedItem.ToString());
                Employee selectedEmployee = (employeeBox.SelectedItem as Tuple<string, Employee>)?.Item2;
                CreateTicket(reportedDateTime, subject, type, priority, deadline, description, userID, selectedEmployee);
            }       
        }

        private void CreateTicket(DateTime reportedDateTime, string subject, string type, TicketPriority priority, DateTime deadline, string description, string userID, Employee e)
        {
            Ticket ticket = new Ticket();
            ticket.DateAndTime = reportedDateTime;
            ticket.SubjectOfIncident = subject;
            ticket.TypeOfIncident = type;
            ticket.UserID = userID;
            ticket.Priority = priority;
            ticket.Status = TicketStatus.Open;
            ticket.Deadline = deadline;
            ticket.Description = description;
            ticket.EmployeeID = e.Id;

            ticketLogic.CreateTicket(ticket);

            OnTicketCreated(EventArgs.Empty);

            this.Hide();
        }

        protected virtual void OnTicketCreated(EventArgs e)
        {
            TicketCreated?.Invoke(this, e);
        }

        private DateTime CalculateDeadline(DateTime reportedDateTime, string selectedDeadline)
        {
            int value = int.Parse(selectedDeadline.Split(' ')[0]);

            switch (selectedDeadline.Split(' ')[1])
            {
                case "days":
                    return reportedDateTime.AddDays(value).Date;
                case "months":
                    return reportedDateTime.AddMonths(value).Date;
            }
            return reportedDateTime;
        }
    }
}

