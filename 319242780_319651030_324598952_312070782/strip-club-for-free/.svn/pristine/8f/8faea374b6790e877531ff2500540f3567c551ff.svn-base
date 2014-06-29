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
    public partial class F_Apprentices : Form
    {
        public F_Apprentices()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
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
                bool succ = BusinessLayer.Update("Apprentices", string.Format("Full_Name = '{0}', Phone_Number = '{1}', Course = '{2}', Start_Date = '{3}', End_Date = '{4}'", textBox2.Text, textBox3.Text, comboBox1.Text, textBox5.Text, textBox6.Text), string.Format("ID = {0}", textBox1.Text));

                if (succ)
                {
                    MessageBox.Show(string.Format("Apprentice with ID {0} Updated", textBox1.Text));
                }
                else
                {
                    MessageBox.Show("No apprentice with such ID");
                }
            }
            else
            {
                MessageBox.Show("Please enter only numbers");
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            double id;
            bool flag = Double.TryParse(textBox1.Text, out id);
            if (flag)
            {
                bool succ = BusinessLayer.Delete("Apprentices", string.Format("ID = {0}", textBox1.Text));
                if (succ)
                {
                    MessageBox.Show(string.Format("Apprentice with ID {0} was removed from the Data Base", textBox1.Text));
                }
                else
                {
                    MessageBox.Show("No apprentice with such ID");
                }
            }
            else
            {
                MessageBox.Show("Please enter only numbers");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.FormController.F_courses.Hide();
            Program.FormController.F_managers.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
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
                bool succ = BusinessLayer.Insert("Apprentices", "ID, Full_Name, Phone_Number, Course, Start_Date, End_Date", string.Format("{0}, '{1}', '{2}', '{3}', '{4}', '{5}'", textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox5.Text, textBox6.Text));

                if (succ)
                {
                    MessageBox.Show(string.Format("Apprentice with ID {0} Added", textBox1.Text));

                    string message = "Apprentice details:\n";
                    string idnum = textBox2.Text;
                    string name = textBox1.Text;
                    string course = textBox5.Text;
                    message = "" + message + "  ID - " + idnum + "\n    Full Name - " + name + "\n  Course Number - " + course + ".\n";
                    sendMail(message);
                    MessageBox.Show("Message has been sent to the academy!");
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

        private void sendMail(string messageBody)
        {

            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFrom = "mazkira.noam@gmail.com";
            string password = "1a2b3c4d5f";
            string emailTo = "skykeeper@hotmail.co.il";
            //string emailTo = "gabi.giladov@gmail.com";
            string subject = "New Apprentice";
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
