using System;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;


namespace wordTest
{
    public class Constants
    {
        public Word.WdParagraphAlignment Left = Word.WdParagraphAlignment.wdAlignParagraphLeft;
        public Word.WdParagraphAlignment Right = Word.WdParagraphAlignment.wdAlignParagraphRight;
        public Word.WdParagraphAlignment Center = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        public Word.WdParagraphAlignment Justify = Word.WdParagraphAlignment.wdAlignParagraphJustify;

        public string[] TimeAndCapacityProgram = new string[] {"Период", "Продолжительность, занятия, ч", "Кол-во Занятий в неделю", "Кол-во часов в неделю", "Кол-во недель", "Кол-во часов в год, ч"};
        public string[] StudyPlan = new string[] {"№", "Наименование разделов и тем", "Всего часов", "Теор.", "Практ", "Формы контроля/аттестации"};

        public string FontTNR = "Times New Roman";
        public string FontCalibri = "Calibri";

        public Constants()
        {

        }
    }
}
