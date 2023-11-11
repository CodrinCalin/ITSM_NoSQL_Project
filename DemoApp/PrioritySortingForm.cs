using Logic;
using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class PrioritySortingForm : Form
    {
        private List<Ticket> tickets;
        private TicketLogic ticketLogic;
        public PrioritySortingForm(Employee employee)
        {
            InitializeComponent();

            ticketLogic = new TicketLogic();

            if (employee.IsSuperDesk)
                ticketLogic = new TicketLogic();
            else
                ticketLogic = new TicketLogic(employee);

            CreateColumns();

            comboBoxPriority.SelectedIndex = 0;
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
            listViewTickets.Columns.Add("Subject", 120);
            listViewTickets.Columns.Add("Priority", 80);
            listViewTickets.Columns.Add("Date and Time", 120);
            listViewTickets.Columns.Add("Deadline", 90);
            listViewTickets.Columns.Add("Status", 80);
        }

        public void RefreshListView()
        {
            listViewTickets.Items.Clear();

            int id = 1;
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(id.ToString());

                item.SubItems.Add(ticket.SubjectOfIncident);
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(setTimeZone(ticket.DateAndTime).ToString("dd/MM/yy HH:mm"));
                item.SubItems.Add(setTimeZone(ticket.Deadline).ToString("dd/MM/yy"));
                item.SubItems.Add(ticket.Status.ToString());

                item.Tag = ticket;
                listViewTickets.Items.Add(item);
            }
            listViewTickets.Refresh();
        }

        private void ComboBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPriority.SelectedIndex)
            {
                case 0:
                    tickets = ticketLogic.GetTicketsBySortOrder(MySortOrder.Ascending);
                    break;
                case 1:
                    tickets = ticketLogic.GetTicketsBySortOrder(MySortOrder.Descending);
                    break;
                default:
                    HandlePrioritySelection();
                    break;
            }
            RefreshListView();
        }

        private void HandlePrioritySelection()
        {
            string selectedPriority = comboBoxPriority.SelectedItem.ToString();

            if (Enum.TryParse<TicketPriority>(selectedPriority, out var parsedPriority))
                tickets = ticketLogic.GetTicketsByPriority(parsedPriority);
            else
                MessageBox.Show("Invalid priority selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
