using System;
using System.Drawing;
using System.Windows.Forms;
using wordTest.DocPatterns;
using wordTest.WordFunctions;
using Word = Microsoft.Office.Interop.Word;
using Konstructor.DocPatterns.MainPage;
using Konstructor.DocPatterns;
using Konstructor.Constants;
using wordTest;

namespace Konstructor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch
            {
                InitializeComponent();

                ButtonBack.BringToFront();
                ButtonNext.BringToFront();

                UpdateButtonState();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(0)).Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(2)).Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(1)).Show();
        }


        private void button33_Click_1(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(3)).Show();
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

        private void button27_Click(object sender, EventArgs e)
        {
            new TasksShowcase().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
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
            
        }

        /*
         * 
         *                                                          Начало
         *                                                  Рабочего пространства
         *                                                 
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
                PersonalTasks.Text, SubjectTasks.Text, "plannedResMetasubjects", "plannedResSubjects", "plannedResPersonal", ProgramKnowledgeLevel.Text, ProgramFocus.Text, MarkedMaterialsText.Text, 
                MethodologMeterialsText.Text, MethodsTechText.Text, BriefContentText.Text));
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

        private void TablePlanQ_Click(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(4)).Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProgramFocus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Constant con = new Constant();

            clearListboc();
            LabelAttestation.Text = con.testingDictionary[ProgramFocus.SelectedIndex][0];
            CheckListBoxAttestation.Items.AddRange(con.fillCheckbox(ProgramFocus.SelectedIndex));
        }

        private void clearListboc() 
        {
            CheckListBoxAttestation.Items.Clear();
            LabelAttestation.Text = String.Empty;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void MethodologMeterialsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonMarkedMaterialsInf_Click(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(0, false)).Show();
        }

        private void MethodologMaterialsButton_Click(object sender, EventArgs e)
        {
            new FormExplanation(new ExplanatoryForms(1, false)).Show();
        }

        /*
         * 
         * ================================================================================================
         * ================================================================================================
         */

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            TabControl currentTabControl = GetCurrentTabControl();

            if (currentTabControl != null && currentTabControl.SelectedIndex > 0)
            {
                // Переход на предыдущую вкладку
                currentTabControl.SelectedIndex--;
            }

            UpdateButtonState();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            TabControl currentTabControl = GetCurrentTabControl();

            if (currentTabControl != null && currentTabControl.SelectedIndex < currentTabControl.TabCount - 1)
            {
                // Переход на следующую вкладку
                currentTabControl.SelectedIndex++;
            }

            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            showAsFirst();

            TabControl currentTabControl = GetCurrentTabControl();

            if (currentTabControl != null)
            {
                ButtonBack.Enabled = currentTabControl.SelectedIndex > 0;
                ButtonNext.Enabled = currentTabControl.SelectedIndex < currentTabControl.TabCount - 1;
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновляем состояние кнопок при изменении вкладки
            UpdateButtonState();
        }

        private TabControl GetCurrentTabControl()
        {
            if (tabControl2.SelectedTab != null && tabControl2.SelectedTab.Controls.Contains(tabControl3))
            {
                return tabControl3;
            }
            else if (tabControl2.SelectedTab != null && tabControl2.SelectedTab.Controls.Contains(tabControl4))
            {
                return tabControl4;
            }
            else
            {
                return tabControl2;
            }
        }

        private void showAsFirst() 
        {
            ButtonBack.BringToFront();
            ButtonNext.BringToFront();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}