using Microsoft.Office.Interop.Word;
using System;
using Word = Microsoft.Office.Interop.Word;

namespace wordTest.WordFunctions
{
    public class DocumentContentManager
    {
        public Word.Document doc;
        public Constants con = new Constants();
        private int currentListNumber = 1;

        public DocumentContentManager(Word.Document doc)
        {
            this.doc = doc;
        }

        private void getFont(Word.Range range, string fontName, float fontSize, bool bold, int italic, bool underline)
        {
            range.Font.Name = fontName;
            range.Font.Size = fontSize;
            range.Font.Bold = bold ? 1 : 0;
            range.Font.Italic = italic;
            range.Font.Underline = underline ? Word.WdUnderline.wdUnderlineSingle : Word.WdUnderline.wdUnderlineNone;
        }

        public void AddCenteredText(string text, int fontSize, bool bold)
        {
            Word.Paragraph paragraph = doc.Paragraphs.Add();
            getFont(paragraph.Range, con.FontTNR, fontSize, bold, 0, false);
            paragraph.Range.Text = text;
            paragraph.Range.ParagraphFormat.Alignment = con.Center;

            paragraph.Range.InsertParagraphAfter();
        }

        public void AddLeftRightAlignedText(string leftText, string rightText, int tabs)
        {
            Word.Paragraph paragraph = doc.Paragraphs.Add();
            getFont(paragraph.Range, con.FontTNR, 8, false, 0, false);
            paragraph.Range.Text = leftText;
            paragraph.Range.ParagraphFormat.Alignment = con.Left;

            paragraph.Range.InsertAfter(new string('\t', tabs));

            Word.Range rightRange = paragraph.Range;
            rightRange.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            rightRange.Text = rightText;

            paragraph.Range.InsertParagraphAfter();
        }

        public void AddLeftAlignedText(string text, int fontSize, bool bold)
        {
            Word.Paragraph paragraph = doc.Paragraphs.Add();
            SetFont(paragraph.Range, fontSize, bold);
            paragraph.Range.Text = text;
            paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            SetFirstLineIndent(paragraph, 28.35f);

            paragraph.Range.InsertParagraphAfter();
        }

        private void SetFont(Word.Range range, float fontSize, bool bold)
        {
            range.Font.Name = "Times New Roman";
            range.Font.Size = fontSize;
            range.Font.Bold = bold ? 1 : 0;
        }

        public void AddText(string text, Word.WdParagraphAlignment alignment, float fontSize)
        {
            Word.Paragraph paragraph = doc.Paragraphs.Add();
            getFont(paragraph.Range, con.FontTNR, fontSize, false, 0, false);
            paragraph.Range.Text = text;
            paragraph.Range.ParagraphFormat.Alignment = alignment;

            paragraph.Range.InsertParagraphAfter();
        }

        public void AddEmptyLines(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Word.Paragraph paragraph = doc.Paragraphs.Add();
                paragraph.Range.Text = "";
                paragraph.Range.InsertParagraphAfter();
            }
        }

        public void InsertPageBreak()
        {
            Word.Range range = doc.Range();
            range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            range.InsertBreak(Word.WdBreakType.wdPageBreak);
            doc.Content.InsertParagraphAfter();
        }

        private void SetFirstLineIndent(Word.Paragraph paragraph, float indent)
        {
            paragraph.Range.ParagraphFormat.FirstLineIndent = indent;
        }

        public void AddNumberedPointWithMultipleLines(string text)
        {
            Word.Paragraph paragraph = doc.Content.Paragraphs.Add();

            text = textToArray(text);
            paragraph.Range.Text = "";
            paragraph.Range.ListFormat.ApplyNumberDefault();
            paragraph.LeftIndent = 26.5f;

            paragraph.Range.ListFormat.ListTemplate.ListLevels[1].NumberFormat = currentListNumber.ToString();

            paragraph.Range.Text = text;
            paragraph.Range.ParagraphFormat.Alignment = con.Left;
            paragraph.Range.ParagraphFormat.FirstLineIndent = 15.0f;
            paragraph.Range.InsertParagraphAfter();

            currentListNumber++;
            paragraph.Range.ParagraphFormat.Reset();
        }



        public string textToArray(string inputText)
        {
            string[] lines = inputText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            string finaltext = "";
            for (int i = 0; i < lines.Length - 1; i++)
            {
                finaltext += lines[i] + "\v";
            }
            finaltext += lines[lines.Length - 1];

            return finaltext;
        }
    }
}
