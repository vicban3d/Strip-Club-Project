using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ConnectingData
{
    public partial class F_EmployeesMenu : Form
    {
        public F_EmployeesMenu()
        {
            InitializeComponent();           
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Program.FormController.F_updateStorage.Show();
            Program.FormController.F_employees.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormController.F_mainMenu.Show();
            Program.FormController.F_employees.Hide();
        }


        private void b_clients_Click(object sender, EventArgs e)
        {
            Program.FormController.F_clients.Show();
            Program.FormController.F_employees.Hide();
        }
      }
    } 
		