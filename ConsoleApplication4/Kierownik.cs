using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Kierownik:Pracownik
    {

        public Kierownik(string imie, DateTime dataZatrudnienia, double pensja)
            : base(imie,dataZatrudnienia,pensja)
        {
        }
        override public double Dodatek (int nadgodziny)
        {
            return base.Dodatek(nadgodziny) * 400;
        }
        public override string ToString(int nadgodziny)
        {
            return "*Kierownik* " + base.ToString(nadgodziny);
        }

    }
}
