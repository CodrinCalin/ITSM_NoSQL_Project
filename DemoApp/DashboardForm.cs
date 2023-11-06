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
    public partial class DashboardForm : Form
    {
        Employee employee;
        int totalTickets = 0;
        int totalTicketsOpen = 0;
        int totalTicketsResolved = 0;
        int totalTicketsClosed = 0;
        int totalTicketsPastDeadline = 0;
        TicketLogic ticketLogic;
        List<Ticket> tickets;

        public DashboardForm(Employee employee)
        {
            try
            {
                InitializeComponent();
                this.employee = employee;
                LoadLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadLabels()
        {
            string role;

            if (employee.IsSuperDesk)
            {
                role = "Super Desk Employee";
                ProgressBarsForSuperDeskEmployee();
            }
            else
            {
                role = "Regular Employee";
                ProgressBarsForRegularEmployee();
            }

            labelWelcome.Text = $"Welcome back,\n{employee.FirstName} {employee.LastName}";
            labelRole.Text = $"Your role is: {role}";
           
        }

        private void ProgressBarsForRegularEmployee()
        {

            ticketLogic = new TicketLogic(employee);
            tickets = ticketLogic.GetTickets();
            CountingTickets();
            SetBarsOfProgress();
        }

        private void ProgressBarsForSuperDeskEmployee()
        {
            ticketLogic = new TicketLogic();
            tickets = ticketLogic.GetTickets();
            CountingTickets();
            SetBarsOfProgress();
        }

        private void SetBarsOfProgress()
        {
            progressBarOpen.Minimum = 0;
            progressBarOpen.Maximum = totalTickets;
            progressBarOpen.Value = totalTicketsOpen;
            labelOpenProgress.Text = $"{totalTicketsOpen}/{totalTickets}";

            progressBarResolved.Minimum = 0;
            progressBarResolved.Maximum = totalTickets;
            progressBarResolved.Value = totalTicketsResolved;
            labelResolvedProgress.Text = $"{totalTicketsResolved}/{totalTickets}";

            progressBarClosed.Minimum = 0;
            progressBarClosed.Maximum = totalTickets;
            progressBarClosed.Value = totalTicketsClosed;
            labelClosedProgress.Text = $"{totalTicketsClosed}/{totalTickets}";

            progressBarPastDeadline.Minimum = 0;
            progressBarPastDeadline.Maximum = totalTickets;
            progressBarPastDeadline.Value = totalTicketsPastDeadline;
            labelPastDeadlineProgress.Text = $"{totalTicketsPastDeadline}/{totalTickets}";
        }

        private void CountingTickets()
        {
            foreach (Ticket ticket in tickets)
            {
                totalTickets++;
                if (ticket.Status == TicketStatus.Open)
                {
                    totalTicketsOpen++;
                }
                else if (ticket.Status == TicketStatus.Resolved)
                {
                    totalTicketsResolved++;
                }
                else if (ticket.Status == TicketStatus.Closed)
                {
                    totalTicketsClosed++;
                }
                else if (ticket.Deadline > DateTime.Now)
                {
                    totalTicketsPastDeadline++;
                }
            }
        }


    }
}
