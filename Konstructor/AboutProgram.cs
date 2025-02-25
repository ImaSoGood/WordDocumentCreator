using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstructor
{
    public partial class AboutProgram : Form
    {
        const string site_str = "https://rrcdoiv.sakhalin.gov.ru/";

        public AboutProgram()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(site_str);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Note.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Note.Visible = false;
        }
    }
}
