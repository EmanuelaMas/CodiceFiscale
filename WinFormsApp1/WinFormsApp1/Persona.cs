﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DataNascita { get; set; }
        public string Sesso { get; set; }
        public Persona() { }

    }
}
