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
    public partial class CreateTicketForm : Form
    {
        public CreateTicketForm(Employee employee)
        {
            InitializeComponent();
            deadlineBox.SelectedIndex = 0;
            priorityBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            CreateTicket();
            this.Hide();
        }

        private void CreateTicket()
        {
            string subject = subjectOfIncidentBox.Text.Trim();
            string type = typeOfIncidentBox.Text.Trim();
            string description = descriptionBox.Text.Trim();





            TicketPriority priority = (TicketPriority)Enum.Parse(typeof(TicketPriority), priorityBox.SelectedItem.ToString());
            DateTime deadline = DateTime.Parse(deadlineBox.SelectedItem.ToString()); 
        }

    }
}
