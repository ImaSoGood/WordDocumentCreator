using Konstructor.DocPatterns.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordTest.WordFunctions;
using Word = Microsoft.Office.Interop.Word;

namespace wordTest.DocPatterns
{
    public class MainContentManager
    {
        private DocumentContentManager contentManager;
        private MainPageText Text;
        private Word.Document doc;

        public MainContentManager(Word.Document doc)
        {
            contentManager = new DocumentContentManager(doc);
            this.doc = doc;
        }

        public MainContentManager(Word.Document doc, MainPageText MainText)
        {
            contentManager = new DocumentContentManager(doc);
            this.doc = doc;
            this.Text = MainText;
        }

        public void CreateMainPage(System.Windows.Forms.DataGridView TimeAndCapacity, System.Windows.Forms.DataGridView StudyPlan)
        {
            contentManager.AddNumberedPointWithMultipleLines("Актуальность: \n " + Text.actuality);
            contentManager.AddNumberedPointWithMultipleLines("Цель и задачи: \n " + Text.target);
            contentManager.AddNumberedPointWithMultipleLines("Предметные: \n " + Text.subjectTasks);
            contentManager.AddNumberedPointWithMultipleLines("Метапредметные: \n " + Text.metasubjectTasks);

            new TableCreator(doc).TimeAndCapacityProgram(TimeAndCapacity);

            contentManager.AddNumberedPointWithMultipleLines("Личностные: \n " + Text.personalTasks);
            contentManager.AddNumberedPointWithMultipleLines("Учебный план: \n ");

            new TableCreator(doc).Plan(StudyPlan);

            //new TableCreator(doc).CreateTableConstructor(3, 3, new string[,] { {"H1", "H2", "H3" }, {"rc1", "rc2", "rc3" }, { "Row2Col1", "Row2Col2", "Row2Col3" } });
            contentManager.InsertPageBreak();
        }
    }
}
