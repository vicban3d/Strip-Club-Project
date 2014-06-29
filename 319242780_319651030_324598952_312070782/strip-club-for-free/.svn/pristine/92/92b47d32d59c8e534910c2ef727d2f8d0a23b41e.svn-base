using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectingData
{
    public partial class F_Report : Form
    {
        public F_Report(List<string> reports)
        {
            InitializeComponent();
            for (int i = 0; i < reports.Count; i++)
            {
                DG.Rows.Add(reports[i]);
            }
            DG.Show();
        }
    }
}
