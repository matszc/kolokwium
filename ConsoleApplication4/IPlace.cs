using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    interface IPlace
    {
        void DodajKierownika(string imie, DateTime dataZatrudnienia, double pensja);
        void DodajPracownika(string imie, DateTime dataZatrudnienia, double pensja);
        void OdwrocKolejnosc();
        void Sortuj();
        void UsunPracownika(int numer);
    }
}
