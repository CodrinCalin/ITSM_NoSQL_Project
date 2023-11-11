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
    public partial class TransferTicket : Form
    {
        EmployeeLogic employeeLogic = new EmployeeLogic();
        Ticket ticket;
        public TransferTicket(Ticket selectedticket)
        {
            InitializeComponent();
            this.ticket = selectedticket;
            SelectedTicketIDLbl.Text = ticket.Id.ToString();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            string username = TransferToEmployeeIDTxtBox.Text;
            Employee transferToEmployee = employeeLogic.GetEmployeeByUsername(username);

            Employee transferFromEmployee = employeeLogic.GetEmployeeById(ticket.EmployeeID);

            ticket.EmployeeID = transferToEmployee.Id;

            MessageBox.Show("Ticket " + ticket.Id + " has been transferred from " + transferFromEmployee.FirstName + " " + transferFromEmployee.LastName + " to " + transferToEmployee.FirstName + " " + transferToEmployee.LastName + ".");

        }
    }
}
