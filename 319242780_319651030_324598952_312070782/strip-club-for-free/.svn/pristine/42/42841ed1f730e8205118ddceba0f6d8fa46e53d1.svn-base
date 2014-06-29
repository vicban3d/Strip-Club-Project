using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Business;
namespace ConnectingData
{
   
    public partial class F_BarmenWaiters : Form
    {
        List<String> shiftsDic = new List<String>();

        public F_BarmenWaiters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormController.F_barmenWaiters.Hide();
            Program.FormController.F_managers.Show();
        }
         

        private void button4_Click_1(object sender, EventArgs e)
        {
            double id;
            bool flag = Double.TryParse(textBox1.Text, out id);
            if (!(Regex.IsMatch(textBox2.Text, @"^[a-z A-Z]+$")) || !(Double.TryParse(textBox3.Text, out id)))
            {
                MessageBox.Show("Please Enter Only Characters");
                return;
            }
            if (flag)
            {
                bool succ = BusinessLayer.Update("Barmen_Waiters", string.Format("Full_Name = '{0}', Phone_Number = '{1}'", textBox2.Text, textBox3.Text), string.Format("ID = {0}", textBox1.Text));

                if (succ)
                {
                    MessageBox.Show(string.Format("Barmen_Waiters with ID {0} Updated", textBox1.Text));
                }
                else
                {
                    MessageBox.Show("No barmen/waiter with such ID");
                }
            }
            else
            {
                MessageBox.Show("Please enter only numbers");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double id;
            bool flag = Double.TryParse(textBox1.Text, out id);
            if (flag)
            {
                bool succ = BusinessLayer.Delete("Barmen_Waiters", string.Format("ID = {0}", textBox1.Text));
                if (succ)
                {
                    MessageBox.Show(string.Format("Barmen/Waiter with ID {0} was removed from the Data Base", textBox1.Text));
                }
                else
                {
                    MessageBox.Show("No barmen/waiter with such ID");
                }
            }
            else
            {
                MessageBox.Show("Please enter only numbers");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double id;
            bool flag = Double.TryParse(textBox1.Text, out id);
            if (!(Regex.IsMatch(textBox2.Text, @"^[a-z A-Z]+$")) || !(Double.TryParse(textBox3.Text, out id)))
            {
                MessageBox.Show("Please Enter Only Characters");
                return;
            }
            if (flag)
            {
                bool succ = BusinessLayer.Insert("Barmen_Waiters", "ID, Full_Name, Phone_Number", string.Format("{0}, '{1}', '{2}'", textBox1.Text, textBox2.Text, textBox3.Text));

                if (succ)
                {
                    MessageBox.Show(string.Format("Barman/Waiter with ID {0} Added", textBox1.Text));
                }
                else
                {
                    MessageBox.Show("Duplicate id");
                }
            }
            else
            {
                MessageBox.Show("Please enter only numbers");
            }
        }


         private void addShift_click(object sender, EventArgs e)
        {
            double id;
            bool flag = Double.TryParse(textBox1.Text, out id);
            DateTime date;
            bool flag2 = DateTime.TryParse(textBox4.Text, out date);
            if (flag && flag2)
            {
                shiftsDic.Add(textBox1.Text + " " + textBox4.Text);
                string shift = "" + textBox1.Text + " " + textBox4.Text;
                if (!shifts_box.Items.Contains(shift))
                {
                    shifts_box.Items.Add(shift);
                }
            }
            else { MessageBox.Show("Please enter only numbers and a valid date (dd/mm/yyyy)"); }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            shifts_box.Items.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shiftsDic.Count; i++)
            {
                bool succ = BusinessLayer.AssignShift(shiftsDic[i].Split()[0], shiftsDic[i].Split()[1]);
                if (!succ)
                {
                    MessageBox.Show("Barmen/Waiter " + shiftsDic[i].Split()[0] + " has has not been added.");
                }
                else
                {
                    sendMail(shiftsDic[i].Split()[1]);
                }
            }
            
            MessageBox.Show("Barmen/Waiters have been assigned.");

            shiftsDic = new List<string>();
            shifts_box.Items.Clear();
        }

        private void sendMail(string messageBody)
        {

            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFrom = "mazkira.noam@gmail.com";
            string password = "1a2b3c4d5f";
            string emailTo = "skykeeper@hotmail.co.il";
            //string emailTo = "gabi.giladov@gmail.com";
            string subject = "Shift Assigned";
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = messageBody;
                mail.IsBodyHtml = false;
                // Can be set to false, if you are sending pure text.
                SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
    }