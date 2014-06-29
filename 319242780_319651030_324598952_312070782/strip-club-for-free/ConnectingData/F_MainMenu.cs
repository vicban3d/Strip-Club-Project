using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectingData
{
    public partial class F_MainMenu : Form
    {
        const int OWNER = 3;
        const int MANAGER = 2;
        const int EMPLOYEE = 1;

        private int permission;

        public F_MainMenu()
        {
            InitializeComponent();
        }

        public void setPermission(int permission)
        {
            this.permission = permission;
        }

        private void b_owners_Click(object sender, EventArgs e)
        {
            if (permission == OWNER)
            {
                Program.FormController.F_owners.Show();
                Program.FormController.F_mainMenu.Hide();
            }
            else
            {
                MessageBox.Show("Insufficient Permissions!");
            }
        }

        private void b_employees_Click(object sender, EventArgs e)
        {
            if (permission >= EMPLOYEE)
            {
                Program.FormController.F_employees.Show();
                Program.FormController.F_mainMenu.Hide();
            }
            else
            {
                MessageBox.Show("Insufficient Permissions!");
            }
        }

        private void b_managers_Click(object sender, EventArgs e)
        {
            if (permission >= MANAGER)
            {
                Program.FormController.F_managers.Show();
                Program.FormController.F_mainMenu.Hide();
            }
            else
            {
                MessageBox.Show("Insufficient Permissions!");
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Program.FormController.F_mainMenu.Hide();
            Program.FormController.F_login.Show();
        }
    }
}
