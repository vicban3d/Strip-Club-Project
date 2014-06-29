using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
namespace ConnectingData
{
    public partial class F_LoginMenu : Form
    {
        public F_LoginMenu()
        {
            InitializeComponent();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {

            string username = "";
            try
            {
                username = usr_nam_fld.Text;
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message + "\nParameter: UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usr_nam_fld.Text = "";
                this.pass_fld.Text = "";
                return;
            }
            try
            {
                DataTable dt = BusinessLayer.SearchUsername(username);
                string pass = pass_fld.Text;
                string realPass = dt.Rows[0]["Password"].ToString();

                if (pass.Equals(realPass))
                {
                    string userPermision = dt.Rows[0]["Permision"].ToString();
                    int permision = Convert.ToInt32(userPermision);

                    Program.FormController.F_mainMenu.Show();
                    Program.FormController.F_mainMenu.setPermission(permision);
                    Program.FormController.F_login.Hide(); 
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            catch (Exception ex)
           {
               MessageBox.Show(ex.Message+" This username is not in the Data Base");
                usr_nam_fld.Text = "";
                this.pass_fld.Text = "";
                return;
            }
            usr_nam_fld.Text = "";
            this.pass_fld.Text = "";
           
            
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            File_backup.backup();
            Program.FormController.closeAll();
            Application.Exit();
        }

    }
}
