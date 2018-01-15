using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class ListaPlac:IPlace
    {
        private List<Pracownik> pracownicy= new List<Pracownik>();

        public void DodajPracownika(string imie, DateTime dataZatrudnienia, double pensja)
        {
            pracownicy.Reverse();
            pracownicy.Add(new Pracownik(imie, dataZatrudnienia, pensja));
            pracownicy.Reverse();
        }
        public void DoajKierownika(string imie, DateTime dataZatrudnienia,double pensja)
        {
            pracownicy.Add(new Kierownik(imie, dataZatrudnienia, pensja));
        }
        public string ToString(int nadgodziny)
        {
            string lancuch = "";

            foreach(Pracownik obecny in pracownicy)
            {
                lancuch += obecny.ToString(nadgodziny);
                lancuch += "\n";
            }
            return lancuch;
        }
        public void UsunPracownika(int numer)
        {
            pracownicy.RemoveAt(numer);
        }
        public void Sortuj()
        {
            pracownicy.Sort();
        }
        public void OdwrocKolejnosc()
        {
            pracownicy.Sort();
            pracownicy.Reverse();
        }


        public void DodajKierownika(string imie, DateTime dataZatrudnienia, double pensja)
        {
            throw new NotImplementedException();
        }
    }
}
