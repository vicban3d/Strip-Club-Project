using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Business;

namespace ConnectingData
{
    public partial class F_UpdateStorage : Form
    {
        private DataTable storage;
        private Storage minStorage;

        public F_UpdateStorage()
        {
            InitializeComponent();
            minStorage = new Storage();

            storage = BusinessLayer.GetStorage();
            for (int i = 0; i < storage.Rows.Count; i++)
                this.product_comboBox.Items.Add(storage.Rows[i]["ProductName"].ToString());
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            storage = BusinessLayer.GetStorage();
            List<Product> toOrder = minStorage.checkQuantities(storage);
            if (toOrder.Count != 0)
            {
                string message = compose(toOrder);
                sendMail(message);
                MessageBox.Show("Storage Updated!");
            }
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(this.quantity_textBox.Text);
            string name = this.product_comboBox.Text;
            for (int i = 0; i < storage.Rows.Count; i++)
            {
                string productName = storage.Rows[i]["ProductName"].ToString();
                if (name.Equals(productName))
                {
                    int realQuantity = Convert.ToInt32(storage.Rows[i]["Quantity"].ToString());
                    if (realQuantity - quantity < 0)
                        MessageBox.Show("The is only " + realQuantity + " of this product");
                    else
                    {
                        int currentQuantity = realQuantity - quantity;
                        BusinessLayer.UpdateStorage(productName, currentQuantity);
                        MessageBox.Show("Changes submited");
                    }
                    storage = BusinessLayer.GetStorage();
                    product_comboBox.Text = "";
                    quantity_textBox.Text = "";
                    break;
                }
            }
        }

         private string compose(List<Product> toOrder)
        {
            string message = "Products to order:\n";
            for (int i = 0; i < toOrder.Count; i++)
            {
                string number = Convert.ToString(toOrder[i].getCatalogNum());
                string name = toOrder[i].getName();
                string quantity = Convert.ToString(toOrder[i].getQuantity());
                message = "" + message + number + "  " + name + "  " + quantity + " units.\n";
            }
            return message;
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
            string subject = "Storage";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormController.F_updateStorage.Hide();
            Program.FormController.F_employees.Show();
        }

    }
}
