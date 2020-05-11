using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace TestList
{
    class Person
    {
        public string FIO { get; set; }
        public DateTime DataRogdenia { get; set; }
        public string MestoRogdenia { get; set; }
        public int NomPasporta { get; set; }
        
        public Person(string FIO, DateTime DataRogdenia, string MestoRogdenia, int NomPasporta)
        {
            this.FIO = FIO;
            this.DataRogdenia = DataRogdenia;
            this.MestoRogdenia = MestoRogdenia;
            this.NomPasporta = NomPasporta;
        }

        public override string ToString()
        {
            return FIO +" "+ DataRogdenia.ToString("D") + " "+ NomPasporta;
        }
    }
}
