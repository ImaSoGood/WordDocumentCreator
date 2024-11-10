using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using wordTest.WordFunctions;
using wordTest;

namespace Konstructor.DocPatterns.MainPage
{
    class TableCreator
    {
        Word.Document doc;
        DocumentContentManager contentManager;
        Constants con = new Constants();

        public TableCreator(Word.Document doc)
        {
            this.doc = doc;
            this.contentManager = new DocumentContentManager(doc);
        }

        public void CreateTableConstructor(int rows, int columns, string[,] data)
        {
            // Добавляем таблицу в документ
            Word.Range range = doc.Content.Paragraphs.Add().Range;
            Word.Table table = doc.Tables.Add(range, rows, columns);

            // Применение стилей к таблице (например, границы)
            table.Borders.Enable = 1;  // Включить границы для таблицы

            // Заполнение таблицы данными
            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= columns; col++)
                {
                    table.Cell(row, col).Range.Text = data[row - 1, col - 1];
                }
            }

            // Пример форматирования таблицы
            table.Rows.HeightRule = Word.WdRowHeightRule.wdRowHeightAtLeast;
            table.Rows.Height = doc.Application.CentimetersToPoints(0.8f);
            table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            table.Range.Font.Size = 10;
            table.Range.Font.Name = "Times New Roman";

            // Вставить параграф после таблицы
            table.Range.InsertParagraphAfter();
        }

        public void TimeAndCapacityProgram(System.Windows.Forms.DataGridView data)
        {
            Word.Paragraph tempParagraph = doc.Content.Paragraphs.Add();
            tempParagraph.Range.ListFormat.ApplyNumberDefault();
            tempParagraph.Range.Text = "";  // Временный текст
            tempParagraph.Range.InsertParagraphAfter();

            string[,] tableData = getDataFromTable(data, con.TimeAndCapacityProgram);

            CreateTableConstructor(data.Rows.Count, data.Columns.Count, tableData);

            // Удаляем временный пункт
            tempParagraph.Range.ListFormat.RemoveNumbers();
            tempParagraph.Range.Text = "";
            tempParagraph.Range.Delete();
        }

        public void Plan(System.Windows.Forms.DataGridView data)
        {
            Word.Paragraph tempParagraph = doc.Content.Paragraphs.Add();
            tempParagraph.Range.ListFormat.ApplyNumberDefault();
            tempParagraph.Range.Text = "";  // Временный текст
            tempParagraph.Range.InsertParagraphAfter();

            string[,] tableData = getDataFromTable(data, con.StudyPlan);

            CreateTableConstructor(data.Rows.Count, data.Columns.Count, tableData);

            // Удаляем временный пункт
            tempParagraph.Range.ListFormat.RemoveNumbers();
            tempParagraph.Range.Text = "";
            tempParagraph.Range.Delete();
        }

        private string[,] getDataFromTable(System.Windows.Forms.DataGridView d, string[] headers)
        {
            int rowCount = d.Rows.Count;
            int colCount = d.Columns.Count;

            string[,] tableData = new string[rowCount, colCount];

            for (int i = 0; i <= colCount - 1; i++)
                tableData[0, i] = headers[i];

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    tableData[i + 1, j] = d.Rows[i].Cells[j].Value.ToString();
                }
            }

            return tableData;
        }
    }
}
