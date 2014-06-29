using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectingData
{
    public partial class F_ManagersMenu : Form
    {
        public F_ManagersMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormController.F_managers.Hide();
            Program.FormController.F_mainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.FormController.F_dancers.Show();
            Program.FormController.F_managers.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.FormController.F_courses.Show();
            Program.FormController.F_managers.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.FormController.F_barmenWaiters.Show();
            Program.FormController.F_managers.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.FormController.F_security.Show();
            Program.FormController.F_managers.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.FormController.F_orders.Show();
            Program.FormController.F_managers.Hide();
        }
    }
}
