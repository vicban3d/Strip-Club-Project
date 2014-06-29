using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectingData
{
    public partial class F_ManageData : Form
    {
        public F_ManageData()
        {
            InitializeComponent();
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            File_backup.backup();
            MessageBox.Show("Backup succeed!");
        }

        private void rst_btn_Click(object sender, EventArgs e)
        {
            File_backup.restore();
            MessageBox.Show("Restore succeed!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormController.F_manageData.Hide();
            Program.FormController.F_owners.Show();
        }
    }
}
