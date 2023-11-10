using DAL;
using Logic;
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
    public partial class IncidentManagementForm : Form
    {
        private TicketLogic ticketLogic;
        private EmployeeLogic employeeLogic;
        private Employee employee;
        public IncidentManagementForm(Employee employee) 
        {
            InitializeComponent();

            this.employee = employee;
            employeeLogic = new EmployeeLogic();

            if (employee.IsSuperDesk)
                ticketLogic = new TicketLogic();
            else
                ticketLogic = new TicketLogic(employee);

            UpdateUI();
        }

        private void UpdateUI()
        {
            if (employee.IsSuperDesk)
            {
                DisplayTicketsForSuperDesk();
                buttonCreateTicket.Hide();

            }
            else
            {
                DisplayTicketsForRegularEmployee();
                buttonCreateTicket.Show();
            }
        }

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketForm createTicketForm = new CreateTicketForm();
            createTicketForm.Show();
        }


        #region regular employee
        private void DisplayTicketsForRegularEmployee()
        {
            listViewTickets.Items.Clear();
            CreateColumnsForRegularEmployee();

            List<Ticket> tickets = ticketLogic.GetTickets();

            int id = 1;
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(ticket.SubjectOfIncident);
                item.SubItems.Add(ticket.TypeOfIncident);
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(ticket.Description);
                item.SubItems.Add(ticket.DateAndTime.ToString("dd/MM/yy HH:mm"));
                item.SubItems.Add(ticket.Deadline.ToString("dd/MM/yy HH:mm"));
                item.SubItems.Add(ticket.Status.ToString());

                item.Tag = item;
                listViewTickets.Items.Add(item);
                id++;
            }
        }

        private void CreateColumnsForRegularEmployee()
        {
            listViewTickets.Columns.Add("ID", 30);
            listViewTickets.Columns.Add("Subject", 120);
            listViewTickets.Columns.Add("Type", 100);
            listViewTickets.Columns.Add("Priority", 80);
            listViewTickets.Columns.Add("Description", 200);
            listViewTickets.Columns.Add("Date and Time", 120);
            listViewTickets.Columns.Add("Deadline", 120);
            listViewTickets.Columns.Add("Status", 80);
        }
        #endregion

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(employee);
            dashboardForm.Show();
            this.Hide();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(employee);
            userManagementForm.Show();
            this.Hide();
        }

        #region super desk
        private void DisplayTicketsForSuperDesk()
        {
            listViewTickets.Items.Clear();
            CreateColumnsForSuperDesk();

            List<Ticket> tickets = ticketLogic.GetTickets();

            int id = 1;
            foreach (Ticket ticket in tickets)
            {
                Employee employee = employeeLogic.GetEmployeeById(ticket.EmployeeID);

                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(ticket.SubjectOfIncident);
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(ticket.DateAndTime.ToString("dd/MM/yy HH:mm"));
                item.SubItems.Add(ticket.Deadline.ToString("dd/MM/yy HH:mm"));
                item.SubItems.Add(ticket.Status.ToString());

                item.Tag = item;
                listViewTickets.Items.Add(item);
                id++;
            }
        }

        private void CreateColumnsForSuperDesk()
        {
            listViewTickets.Columns.Add("ID", 30);
            listViewTickets.Columns.Add("Name", 100);
            listViewTickets.Columns.Add("Subject", 120);
            listViewTickets.Columns.Add("Priority", 80);
            listViewTickets.Columns.Add("Date and Time", 120);
            listViewTickets.Columns.Add("Deadline", 120);
            listViewTickets.Columns.Add("Status", 80);
        }

        #endregion
    }
}
