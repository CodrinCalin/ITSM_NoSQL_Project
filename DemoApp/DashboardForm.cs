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
        public DashboardForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            LoadLabels();
        }


        private void LoadLabels()
        {
            string role;

            if (employee.IsSuperDesk)
            {
                role = "Super Desk Employee";
            }
            else
            {
                role = "Regular Employee";
            }

            labelWelcome.Text = $"Welcome back,\n{employee.FirstName} {employee.LastName}";
            labelRole.Text = $"Your role is: {role}";
            ProgressBarsForRegularEmployee();
        }

        private void ProgressBarsForRegularEmployee()
        {
            int totalTickets = 0;
            int totalTicketsOpen = 0;
            int totalTicketsResolved = 0;
            int totalTicketsClosed = 0;
            int totalTicketsPastDeadline = 0;


            TicketLogic ticketLogic = new TicketLogic(employee);
            List<Ticket> tickets = ticketLogic.GetTickets();
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


            progressBarOpen.Minimum = 0;
            progressBarOpen.Maximum = totalTickets;
            progressBarOpen.Value = totalTicketsOpen;

        }

        private void ProgressBarsForSuperDeskEmployee()
        {

        }


    }
}
