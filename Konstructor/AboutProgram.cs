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



        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start(site_str);
        }
    }
}
