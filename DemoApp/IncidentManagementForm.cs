using DAL;
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
            CreateColumns();

            RefreshListView();
        }

        private TimeZoneInfo nlTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");

        private DateTime setTimeZone(DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, nlTimeZone);
        }

        private void CreateColumns()
        {
            listViewTickets.Columns.Clear();

            listViewTickets.Columns.Add("ID", 30);
            if (employee.IsSuperDesk)
                listViewTickets.Columns.Add("Name", 100);
            listViewTickets.Columns.Add("Subject", 120);
            listViewTickets.Columns.Add("Priority", 80);
            listViewTickets.Columns.Add("Description", 200);
            listViewTickets.Columns.Add("Date and Time", 120);
            listViewTickets.Columns.Add("Deadline", 90);
            listViewTickets.Columns.Add("Status", 80);
        }

        public void RefreshListView()
        {
            listViewTickets.Items.Clear();

            TicketLogic ticketLogic;
            if (employee.IsSuperDesk)
                ticketLogic = new TicketLogic();
            else
                ticketLogic = new TicketLogic(employee);
            List<Ticket> tickets = ticketLogic.GetTickets();

            int id = 1;

            foreach (Ticket ticket in tickets)
            {
                displayTicket(ticket, id++);
            }
            listViewTickets.Refresh();
        }

        private ListViewItem displayTicket(Ticket ticket, int id)
        {
            ListViewItem item = new ListViewItem(id.ToString());

            if (employee.IsSuperDesk)
            {
                Employee e = employeeLogic.GetEmployeeById(ticket.EmployeeID);
                item.SubItems.Add(e.FirstName);
            }
            item.SubItems.Add(ticket.SubjectOfIncident);
            item.SubItems.Add(ticket.Priority.ToString());
            item.SubItems.Add(ticket.Description);
            item.SubItems.Add(setTimeZone(ticket.DateAndTime).ToString("dd/MM/yy HH:mm"));
            item.SubItems.Add(setTimeZone(ticket.Deadline).ToString("dd/MM/yy"));
            item.SubItems.Add(ticket.Status.ToString());

            item.Tag = ticket;
            listViewTickets.Items.Add(item);

            return item;
        }

        // ------------- Related to the other forms -------------
        private void createTicketForm_TicketCreated(object sender, EventArgs e)
        {
            RefreshListView();
        }
  
        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketForm createTicketForm = new CreateTicketForm(employee);
            createTicketForm.TicketCreated += createTicketForm_TicketCreated;
            createTicketForm.ShowDialog();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            new FilteringIncidentsForm().ShowDialog();
        }

        private void buttonCloseTicket_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedTicketItem = listViewTickets.SelectedItems[0];
                Ticket selectedTicket = (Ticket)selectedTicketItem.Tag;
                ticketLogic.CloseTicket(selectedTicket.Id);
                RefreshListView();
            }
            else
            {
                MessageBox.Show("Please select a ticket to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedTicketItem = listViewTickets.SelectedItems[0];
                Ticket selectedTicket = (Ticket)selectedTicketItem.Tag;
                new EditTicketForm(selectedTicket,this).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a ticket to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void buttonEscalate_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedTicketItem = listViewTickets.SelectedItems[0];
                Ticket selectedTicket = (Ticket)selectedTicketItem.Tag;
                ticketLogic.EscaladeTicket(selectedTicket.Id);
                RefreshListView();
            }
            else
            {
                MessageBox.Show("Please select a ticket to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            PrioritySortingForm prioritySortingForm = new PrioritySortingForm(employee);
            prioritySortingForm.ShowDialog();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(employee);
            userManagementForm.Show();
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
