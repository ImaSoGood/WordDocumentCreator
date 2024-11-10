using Word = Microsoft.Office.Interop.Word;
using System;
using wordTest.WordFunctions;


namespace wordTest.DocPatterns
{
    public class TitlePageManager
    {
        private DocumentContentManager contentManager;
        private Constants con = new Constants();

        private string CreatorName;
        private string DevName;
        private string NameOO;
        private string FounderName;
        private string ProgramName;
        private string ProgramKnowledgeLevel;
        private string DevelopmentTimeY;
        private string DevelopmentTimeM;
        private string TownName;
        private string ProgramFocus;
        private string YearDeveloped;
        private string StudentsAge;

        public TitlePageManager(Word.Document doc, string CreatorName, string DevName, string NameOO, string FounderName, string ProgramName, string ProgramKnowledgeLevel, string DevelopmentTimeY,
            string DevelopmentTimeM, string TownName, string ProgramFocus, string YearDeveloped, string StudentsAge)
        {
            contentManager = new DocumentContentManager(doc);

            this.CreatorName = CreatorName;
            this.DevName = DevName;
            this.NameOO = NameOO;
            this.FounderName = FounderName;
            this.ProgramName = ProgramName;
            this.ProgramKnowledgeLevel = ProgramKnowledgeLevel;
            this.DevelopmentTimeY = DevelopmentTimeY;
            this.DevelopmentTimeM = DevelopmentTimeM;
            this.TownName = TownName;
            this.ProgramFocus = ProgramFocus;
            this.YearDeveloped = YearDeveloped;
            this.StudentsAge = StudentsAge;
        }

        public void CreateTitlePage()
        {
            contentManager.AddCenteredText("Министерство образования Сахалинской области", 14, false);
            contentManager.AddCenteredText("Государственное автономное учреждение", 14, false);
            contentManager.AddCenteredText("Региональный ресурсный центр дополнительного образования и воспитания", 14, false);

            contentManager.AddEmptyLines(1);

            contentManager.AddLeftRightAlignedText("Рассмотрено на заседании", "УТВЕРЖДАЮ", 7);
            contentManager.AddLeftRightAlignedText("Методического совета", "Директор ГАУ РРЦДОиВ", 7);
            contentManager.AddLeftRightAlignedText("Протокол от ___ *месяц* 2024 №__", "Приказ от ___ *месяц* 2024 №___-ОД", 6);
            contentManager.AddLeftRightAlignedText("", "______________/ " + FounderName + " /", 9);

            contentManager.AddEmptyLines(4);

            contentManager.AddCenteredText("Дополнительная общеразвивающая программа", 16, true);
            contentManager.AddCenteredText('"' + ProgramName + '"', 16, true);

            contentManager.AddEmptyLines(4);

            contentManager.AddLeftAlignedText("Направленность: " + ProgramFocus, 12, false);
            contentManager.AddLeftAlignedText("Уровень освоения: " + ProgramKnowledgeLevel, 12, false);
            contentManager.AddLeftAlignedText("Адресат программы: " + StudentsAge, 12, false);
            contentManager.AddLeftAlignedText("Срок реализации программы: " + DevelopmentTimeY + "лет, " + DevelopmentTimeM + "Месяцев", 12, false);

            contentManager.AddText("Автор-Разработчик: ", con.Right, 14);

            if (string.IsNullOrEmpty(CreatorName))
                contentManager.AddText("ИМЯ НЕ УКАЗАНО!" + ',', con.Right, 14);
            else
                contentManager.AddText(CreatorName + ',', con.Right, 14);

            contentManager.AddText("педагог дополнительного образования: ", con.Right, 14);
            contentManager.AddText("Иванов Иван Иванович", con.Right, 14);
            contentManager.AddText("Кто-то там...", con.Right, 14);

            contentManager.AddEmptyLines(1);

            contentManager.AddText(TownName, con.Center, 14);
            contentManager.AddText(YearDeveloped, con.Center, 14);


            contentManager.InsertPageBreak();
            
        }
    }
}
