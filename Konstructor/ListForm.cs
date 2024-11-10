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
    public partial class ListForm : Form
    {
        private string formatedText = String.Empty;
        public event Action<string, RichTextBox> DataRecieved;
        private RichTextBox richTextBox;

        public ListForm(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.formatedText = richTextBox.Text;
            this.richTextBox = richTextBox;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {            
            DataRecieved?.Invoke(richTextBox1.Text, richTextBox);
            this.Close();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = formatedText;
        }

        private void ChangeToList_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = FormatText(richTextBox1.Text);
        }

        private string FormatText(string text)
        {
            string[] lines = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"\t— {lines[i].Trim()}";
            }

            return string.Join(Environment.NewLine, lines);
        }
    }
}
