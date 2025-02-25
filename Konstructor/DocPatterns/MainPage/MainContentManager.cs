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
            contentManager.AddCenteredText("Комплекс основных характеристик", 14, true);

            contentManager.AddNumberedPointWithMultipleLines
                (
                    "Пояснительнпя записка \n " + Text.actuality + "\n" +
                    "Далее: И что то еще можно написать..." + "\n" +
                    "Направленность: " + Text.programFocus + "\n" +
                    "Уровень освоения: " + Text.knowledgeLvl
                );

            contentManager.AddNumberedPointWithMultipleLines
                (
                    "Формы обучения \n" + "Пока не придумано)" 
                );

            contentManager.AddNumberedPointWithMultipleLines
                (
                    "Цель и задачи программы \n " + Text.target + "\n" + 
                    "Предметные: \n" + Text.subjectTasks + "\n" +
                    "Метапредметные: \n" + Text.metasubjectTasks + "\n" +
                    "Личностные: \n " + Text.personalTasks
                );

            new TableCreator(doc).TimeAndCapacityProgram(TimeAndCapacity);
            contentManager.AddNumberedPointWithMultipleLines("Учебный план: ");

            new TableCreator(doc).Plan(StudyPlan);
            contentManager.InsertPageBreak();
        }
    }
}
