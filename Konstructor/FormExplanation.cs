using Konstructor.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstructor
{
    public partial class FormExplanation : Form
    {
        ExplanatoryForms explanationForm;

        public FormExplanation(ExplanatoryForms explanationForm)
        {
            InitializeComponent();
            this.explanationForm = explanationForm;
        }

        private void ExplanationForm_Load(object sender, EventArgs e)
        {
            this.Text = explanationForm.getHeader();
            this.TextField.Text = explanationForm.getText();
        }
    }
}
