using System;
using Word = Microsoft.Office.Interop.Word;

namespace wordTest
{
    public class WordListManager
    {
        private Word.Document document;

        public WordListManager(Word.Document doc)
        {
            document = doc;
        }

        // Метод для добавления основного пункта
        public void AddMainItem(string text)
        {
            AddItem(text, 0);
        }

        // Метод для добавления подпункта
        public void AddSubItem(string text)
        {
            AddItem(text, 1);
        }

        // Метод для добавления пункта с заданным уровнем
        public void AddItem(string text, int level)
        {
            Word.Paragraph paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = text;
            paragraph.Range.ListFormat.ApplyNumberDefault();

            // Установка уровня списка
            for (int i = 0; i < level; i++)
            {
                paragraph.Range.ListFormat.ListIndent();
            }

            paragraph.Range.InsertParagraphAfter();
        }

        public void ChangeItemLevel(Word.Paragraph para, int newLevel)
        {
            int currentLevel = para.Range.ListFormat.ListLevelNumber - 1; // Уровень начинается с 0

            if (currentLevel > newLevel)
            {
                for (int i = currentLevel; i > newLevel; i--)
                {
                    para.Range.ListFormat.ListOutdent();
                }
            }
            else if (currentLevel < newLevel)
            {
                for (int i = currentLevel; i < newLevel; i++)
                {
                    para.Range.ListFormat.ListIndent();
                }
            }
        }

        public void AddRegularText(string text, Word.WdParagraphAlignment alignment)
        {
            Word.Paragraph paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = text;
            paragraph.Range.ParagraphFormat.Alignment = alignment;
            paragraph.Range.InsertParagraphAfter();
        }
    }
}
