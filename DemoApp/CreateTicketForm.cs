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
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoApp
{
    public partial class CreateTicketForm : Form
    {
        private Employee employee;

        private TicketLogic ticketLogic;

        public event EventHandler TicketCreated;

        public CreateTicketForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            ticketLogic = new TicketLogic();

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

            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Set default values for hours and minutes
            numericUpDownHours.Value = currentTime.Hour;
            numericUpDownMinutes.Value = currentTime.Minute;
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

            string subject = subjectOfIncidentBox.Text.Trim();
            string type = typeOfIncidentBox.Text.Trim();
            string description = descriptionBox.Text.Trim();
            string userID = userIDBox.Text.Trim();  

            TicketPriority priority = (TicketPriority)Enum.Parse(typeof(TicketPriority), priorityBox.SelectedItem.ToString());
            string selectedDeadline = deadlineBox.SelectedItem.ToString();
            DateTime deadline = CalculateDeadline(reportedDateTime, selectedDeadline);

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(userID))
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                CreateTicket(reportedDateTime, subject, type, priority, deadline, description, userID);
        }

        private void CreateTicket(DateTime reportedDateTime, string subject, string type, TicketPriority priority, DateTime deadline, string description, string userID)
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
            ticket.EmployeeID = employee.Id;

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

