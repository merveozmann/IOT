using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace translete
{
    public class Translate
    {
        public string code;
        public string lang;
        public string[] text;
        public Translate(string c, string l, string[] t)
        {
            code = c;
            lang = l;
            text = t;
        }
        // bir tane Translate classı oluştur.code(string), lang(string) ve text(string array) değerlerini tutsun
    }
}
