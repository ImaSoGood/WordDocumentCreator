using System;
using System.Drawing;
using System.Windows.Forms;
using wordTest.DocPatterns;
using wordTest.WordFunctions;
using Word = Microsoft.Office.Interop.Word;
using Konstructor.DocPatterns.MainPage;
using Konstructor.DocPatterns;

namespace Konstructor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            try
            {
                throw new NotImplementedException();
            }
            catch
            {
                InitializeComponent();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }


        private void button33_Click_1(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        //Кнопки перемещения
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage4"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage3"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedTab = tabControl3.TabPages["TabPage14"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedTab = tabControl3.TabPages["TabPage13"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedTab = tabControl3.TabPages["TabPage16"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedTab = tabControl3.TabPages["TabPage14"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedTab = tabControl3.TabPages["TabPage12"];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedTab = tabControl3.TabPages["TabPage16"];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage6"];
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage7"];
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage5"];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage8"];
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage7"];
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage9"];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage8"];
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage10"];
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage9"];
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage11"];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabControl4.TabPages["TabPage10"];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage18"];
        }

        private void button28_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage19"];
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage18"];
        }

        private void новыйПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Титульник
            CreatorName.Text = "";
            DeveloperPosition.Text = "";
            NameOO.Text = "";
            FounderName.Text = "";
            TownName.Text = "";
            //textBox7.Text = "";
            DevelopmentTimeY.Text = "";
            YearDeveloped.Text = "";
            StudentsAge.Text = "";
            DevelopmentTimeM.Text = "";
            ProgramName.Text = "";
            ProgramFocus.Text = "";
            ProgramKnowledgeLevel.Text = "";

            //Записка 2  раздел
            //Подпункт 2

            //Подпункт 2
            Actuality.Text = "";
            ProgramSpecs.Text = "";
            Newie.Text = "";
            Target.Text = "";

            //Подпункт 3
            PersonalTasks.Text = "";
            SubjectTasks.Text = "";
            MetasubjectTasks.Text = "";
            TimeAndCapacityTable.Rows.Clear();
            StudyPlan.Rows.Clear();
            //comboBox3.Text = "";

            //Подпункт 4
            richTextBox7.Text = "";

            //Записка 3  раздел
            //Подпункт 1
            dataGridView4.Rows.Clear();
            //dataGridView5.Rows.Clear();

            //Подпункт 2
            richTextBox8.Text = "";
            //dataGridView6.Rows.Clear();

            //Подпункт 3



            //Подпункт 4


            //Подпункт 5


            //Подпункт 6

        }

        /*
         * 
         *                                                          Начало
         *                                                  Рабочего пространства
         *                                                 Namespace starts with...
         * 
         */

        private void button29_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["TabPage6"];

            Word.Application wordApp = new Word.Application();
            Word.Document document = wordApp.Documents.Add();

            TitlePageManager titlePageManager = new TitlePageManager(document, CreatorName.Text, CreatorName.Text, NameOO.Text, FounderName.Text, ProgramName.Text, ProgramKnowledgeLevel.Text, DevelopmentTimeY.Text,
                DevelopmentTimeM.Text, TownName.Text, ProgramFocus.Text, YearDeveloped.Text, StudentsAge.Text);
            titlePageManager.CreateTitlePage();

            MainContentManager mainContentManager = new MainContentManager(document, new MainPageText(Actuality.Text, Newie.Text, ProgramSpecs.Text, Target.Text, MetasubjectTasks.Text,
                PersonalTasks.Text, SubjectTasks.Text, "plannedResMetasubjects", "plannedResSubjects", "plannedResPersonal", ProgramKnowledgeLevel.Text, ProgramFocus.Text));
            mainContentManager.CreateMainPage(TimeAndCapacityTable, StudyPlan);

            string text = BibliographyText.Text;
            new Bibliography(document, BibliographyText.Text).createBibliography();

            wordApp.Visible = true;
            wordApp.WindowState = Word.WdWindowState.wdWindowStateNormal;
        }

        private void openListForm(RichTextBox richTextBox)
        {
            ListForm listForm = new ListForm(richTextBox);
            listForm.DataRecieved += RecieveData;
            listForm.ShowDialog();
        }

        private void RecieveData(string text, RichTextBox richTextBox)
        {
            richTextBox.Text = text;
        }

        private void SubjectTasks_Click(object sender, EventArgs e)
        {
            openListForm(SubjectTasks);
        }

        private void MetasubjectTasks_Click(object sender, EventArgs e)
        {
            openListForm(MetasubjectTasks);
        }

        private void PersonalTasks_Click(object sender, EventArgs e)
        {
            openListForm(PersonalTasks);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutProgram().ShowDialog();
        }

        /*private void оПрограммеToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            this.ShowDialog(aboutProgram);
        }*/
    }
}






