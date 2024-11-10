using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordTest.WordFunctions;
using Word = Microsoft.Office.Interop.Word;

namespace Konstructor.DocPatterns
{
    class Bibliography
    {
        private DocumentContentManager contentManager;
        private Word.Document doc;
        private List<string> bibliography = new List<string>();

        public Bibliography(Word.Document doc, string bibliographyList)
        {
            this.doc = doc;
            this.contentManager = new DocumentContentManager(this.doc);
            this.bibliography = getListByAlphabed(bibliographyList);
        }

        public Bibliography(string text)
        {
            bibliography = getListByAlphabed(text);
        }

        public List<string> getListByAlphabed(string text)
        {
            bibliography = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            bibliography.Sort();
            return bibliography;
        }

        public List<string> getBibliographyList()
        {
            return bibliography;
        }

        public void createBibliography()
        {
            contentManager.AddCenteredText("Список литературы", 14, false);
            contentManager.AddEmptyLines(1);

            for (int i = 0; i < bibliography.Capacity - 1; i++)
            {
                contentManager.AddNumberedPointWithMultipleLines(bibliography[i]);
            }
        }
    }
}
