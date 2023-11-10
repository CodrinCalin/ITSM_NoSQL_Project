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
    public partial class PrioritySortingForm : Form
    {
        private List<Ticket> tickets;
        public PrioritySortingForm(List<Ticket> tickets)
        {
            InitializeComponent();
            this.tickets = tickets;
        }
    }
}
