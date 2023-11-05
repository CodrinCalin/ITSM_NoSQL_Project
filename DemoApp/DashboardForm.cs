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
        }

    }
}
