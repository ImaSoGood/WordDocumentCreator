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
        private string header, text;

        public ExplanatoryForms(int number) 
        {
            Constant con = new Constant();
            header = con.header[number];
            text = con.text[number];
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
