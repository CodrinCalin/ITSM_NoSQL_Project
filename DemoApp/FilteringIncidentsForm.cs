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
    public partial class FilteringIncidentsForm : Form
    {
        TicketLogic ticketLogic;
        List<Ticket> tickets;
        public FilteringIncidentsForm()
        {
            try
            { 
                InitializeComponent();
                ticketLogic = new TicketLogic();
                tickets = ticketLogic.GetTickets();
                FillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(textBoxInput.Text.ToLower());
        }

        private void FillTable()
        {
            UpdateListView("");
        }

        private void UpdateListView(string searchText)
        {
            listViewIncidents.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                if (ticket.SubjectOfIncident.ToLower().Contains(searchText) ||
                    ticket.Description.ToLower().Contains(searchText) ||
                    ticket.TypeOfIncident.ToLower().Contains(searchText))
                {
                    ListViewItem li = new ListViewItem(ticket.DateAndTime.ToString("d"));
                    li.SubItems.Add(ticket.SubjectOfIncident);
                    li.SubItems.Add(ticket.Description);
                    li.SubItems.Add(ticket.Deadline.ToString("d"));
                    li.SubItems.Add(ticket.Priority.ToString());
                    li.SubItems.Add(ticket.Status.ToString());
                    li.SubItems.Add(ticket.TypeOfIncident);
                    li.Tag = ticket;
                    listViewIncidents.Items.Add(li);
                }
            }
        }

    }
}
