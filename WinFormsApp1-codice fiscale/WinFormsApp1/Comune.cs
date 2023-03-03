using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Comune
    {
        public string Nome { get; set; }
        public string Codice { get; set;}

        public Comune(string nome, string codice)
        {
            Nome = nome;
            Codice = codice;
        }
    }
}
