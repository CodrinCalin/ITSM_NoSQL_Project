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
        private Employee loggedInEmployee;
        
        public IncidentManagementForm(Employee employee) //Employee loggedInEmployee
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            /*if (loggedInEmployee.IsSuperDesk)
            {
                ticketLogic = new TicketLogic();
                DisplayAllTickets();
            }
            else
            {
                ticketLogic = new TicketLogic(loggedInEmployee);
                DisplayTicketsForRegularEmployee();
            }*/
            ticketLogic = new TicketLogic();
            employeeLogic = new EmployeeLogic();
            DisplayAllTickets();

        }

        private void DisplayAllTickets()
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

                item.Tag = ticket;
                listViewTickets.Items.Add(item);
                id++;
            }
        }


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

                item.Tag = ticket;
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


        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketForm createTicketForm = new CreateTicketForm(loggedInEmployee);
            createTicketForm.ShowDialog();
        }

        // ------------- Related to the other forms -------------
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


        public void RefreshListView()
        {
            listViewTickets.Items.Clear();
            TicketLogic ticketLogic = new TicketLogic();
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

                item.Tag = ticket;
                listViewTickets.Items.Add(item);
                id++;
            }

            listViewTickets.Refresh();
        }

    }
}
