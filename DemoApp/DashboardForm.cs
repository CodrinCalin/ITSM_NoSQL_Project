﻿using Logic;
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
                ProgressForSuperDeskEmployee();
            }
            else
            {
                role = "Regular Employee";
                ProgressForRegularEmployee();
            }

            labelWelcome.Text = $"Welcome back,\n{employee.FirstName} {employee.LastName}";
            labelRole.Text = $"Your role is: {role}";
           
        }

        private void ProgressForRegularEmployee()
        {

            ticketLogic = new TicketLogic(employee);
            tickets = ticketLogic.GetTickets();
            CountingTickets();
            SetPieChart();
        }

        private void ProgressForSuperDeskEmployee()
        {
            ticketLogic = new TicketLogic();
            tickets = ticketLogic.GetTickets();
            CountingTickets();
            SetPieChart();
        }

        private void SetPieChart()
        {
            chartPieIncidents.Series["IncidentsSeries"].Points.AddXY("Open", totalTicketsOpen);
            chartPieIncidents.Series["IncidentsSeries"].Points.AddXY("Resolved", totalTicketsResolved);
            chartPieIncidents.Series["IncidentsSeries"].Points.AddXY("Closed", totalTicketsClosed);
            chartPieIncidents.Series["IncidentsSeries"].Points.AddXY("Past Deadline", totalTicketsPastDeadline);
            labelTotalIncidents.Text = $"Total Incidents: {totalTickets}";
        }

        private void CountingTickets()
        {
            foreach (Ticket ticket in tickets)
            {
                totalTickets++;
                if (ticket.Status == TicketStatus.Open)
                {
                    totalTicketsOpen++;
                    if (ticket.Deadline < DateTime.Now)
                    {
                        totalTicketsPastDeadline++;
                    }
                }
                else if (ticket.Status == TicketStatus.Resolved)
                {
                    totalTicketsResolved++;
                }
                else if (ticket.Status == TicketStatus.Closed)
                {
                    totalTicketsClosed++;
                }
                
            }
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {

        }

        private void buttonIncidentManagement_Click(object sender, EventArgs e)
        {
            IncidentManagementForm incidentManagementForm = new IncidentManagementForm(employee);
            incidentManagementForm.Show();
            this.Hide();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(employee);
            userManagementForm.Show();
            this.Hide();
        }

        private void ChangeUI(IncidentManagementForm managementForm)
        {
           
        }
    }
}
