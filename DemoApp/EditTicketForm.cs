using Logic;
using Model;
using MongoDB.Bson;
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
    public partial class EditTicketForm : Form
    {
        Ticket ticket;
        TicketLogic ticketLogic;
        private IncidentManagementForm formWithListView;

        public EditTicketForm(Ticket ticket, IncidentManagementForm formWithListView)
        {
            try
            {
                InitializeComponent();
                this.ticket = ticket;
                this.formWithListView = formWithListView;
                ticketLogic = new TicketLogic();
                CustomDateTimePicker();
                FillForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateDataAndRefreshListView()
        {
            formWithListView.RefreshListView();
        }


        private void CustomDateTimePicker()
        {
            dateTimePickerCreation.Format = DateTimePickerFormat.Custom;
            dateTimePickerCreation.CustomFormat = "dd/MM/yyyy HH:mm";

            dateTimePickerDeadline.Format = DateTimePickerFormat.Custom;
            dateTimePickerDeadline.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void FillForm()
        {
            textBoxUserID.Text = ticket.UserID;
            textBoxType.Text = ticket.TypeOfIncident;
            richTextBoxSubject.Text = ticket.SubjectOfIncident;
            richTextBoxDescription.Text = ticket.Description;
            dateTimePickerCreation.Value = ticket.DateAndTime;
            dateTimePickerDeadline.Value = ticket.Deadline;
            comboBoxPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            comboBoxPriority.SelectedItem = ticket.Priority;
            comboBoxStatus.DataSource = Enum.GetValues(typeof(TicketStatus));
            comboBoxStatus.SelectedItem = ticket.Status;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Ticket updatedTicket = new Ticket()
            {
                UserID = textBoxUserID.Text,
                TypeOfIncident = textBoxType.Text,
                SubjectOfIncident = richTextBoxSubject.Text,
                Description = richTextBoxDescription.Text,
                DateAndTime = dateTimePickerCreation.Value,
                Deadline = dateTimePickerDeadline.Value,
                Priority = (TicketPriority)comboBoxPriority.SelectedItem,
                Status = (TicketStatus)comboBoxStatus.SelectedItem
            };

            ticketLogic.UpdateTicket(ticket.Id,updatedTicket);
            MessageBox.Show("Ticket updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateDataAndRefreshListView();
            this.Close();
        }

        private void buttonDeleteTicket_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                DeleteTicket();
                MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataAndRefreshListView();
                this.Close();
            }

        }

        private void DeleteTicket()
        {
           ticketLogic.DeleteTicket(ticket.Id);
        }

        
    }
}
