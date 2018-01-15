using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Pracownik:IComparable<Pracownik>
    {
        private DateTime dataZatrudnienia;
        private string imie;
        private double pensja;
        private int staz;

        public Pracownik(string imie, DateTime dataZaturdnienia, double pensja)
        {
            this.imie = imie;
            this.dataZatrudnienia = dataZaturdnienia;
            this.pensja = pensja;
            int rok;
            rok = dataZatrudnienia.Year - DateTime.Now.Year;
            this.staz = rok;
        }
        virtual public double Dodatek(int nadgodziny)
        {
            return nadgodziny * 40 + staz * 100;
        }
        virtual public string ToString (int nadgodziny)
        {
            double dodatek = Dodatek(nadgodziny);
            double wyplata = dodatek + pensja;
            return "Pracownik " + imie + ", staz: " + staz + ", pensja z dodatkiem: " + wyplata;
        }
        public int CompareTo(Pracownik other)
        {
            if (other.staz > this.staz)
                return 1;
            else if (other.staz == this.staz)
                return 0;
            else
                return -1;
        }
    }
}
