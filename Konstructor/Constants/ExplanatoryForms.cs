using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordTest;

namespace Konstructor.Constants
{
    public class ExplanatoryForms
    {
        Constant con = new Constant();
        private string header, text;

        public ExplanatoryForms(int number) 
        {
            header = con.header[number];
            text = con.text[number];
        }

        public ExplanatoryForms(int num, bool checker)
        {
            header = con.evaluationMaterialsHeaders[num];
            text = con.evaluationMaterialsText[num];
        }

        public string getHeader() 
        {
            return header;
        }

        public string getText() 
        {
            return text;
        }
    }
}
