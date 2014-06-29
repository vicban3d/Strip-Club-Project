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
    public partial class F_Orders : Form
    {
        public F_Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dates.Items.Clear();
            Program.FormController.F_orders.Hide();
            Program.FormController.F_managers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            double cost;
            string data = textBox1.Text;
            bool flag1 = Int32.TryParse(textBox2.Text, out id);
            bool flag2 = Double.TryParse(textBox3.Text, out cost);
            if (flag1 && flag2)
            {
                bool succ = BusinessLayer.AddOrder(data, id, cost);
                if (succ)
                {
                    MessageBox.Show(string.Format("Order has been added"));
                }
                else
                {
                    MessageBox.Show("This Order is already present");
                }
            }
            else
            {
                MessageBox.Show("Please enter only numbers and a valid date (dd/mm/yyyy)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dates.Items.Clear();
            DataTable dt = BusinessLayer.getDates();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Dates.Items.Add(DateTime.Parse(dt.Rows[i]["ODate"].ToString()).Date);
            }
        }
    }
}
