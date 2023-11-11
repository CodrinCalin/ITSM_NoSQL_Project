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
    public partial class LoginForm : Form
    {
        Employee employee;
        LoginLogic loginLogic;

        public LoginForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           try
           {
                ValidateLogin();
           }
            catch(Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }

        private void ValidateLogin()
        {
            loginLogic = new LoginLogic();
            bool check = loginLogic.CheckForAccountInDatabase(textBoxUsername.Text, textBoxPassword.Text);

            if (!EmptyFields())
            { 
                if (check == true)
                {
                    employee = loginLogic.GetEmployee();
                    OpenDashboard();
                }
                else
                {
                    labelError.Text = "Incorrect password or username!";
                    labelError.Visible = true;
                }
            }
        }

        private bool EmptyFields()
        {
           if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
           {
               labelError.Text = "Please fill in all fields!";
               labelError.Visible = true;
               return true;
            }
           return false;
        }

        private void OpenDashboard()
        {
            DashboardForm dashboardForm = new DashboardForm(employee);
            dashboardForm.Show();
            this.Hide();
        }

        private void labelFogotLoginDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the Manager");
        }
    }
}
