using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcja = 0;
            Console.WriteLine("Co chcesz zrobic ?");
            Console.WriteLine("1 - dodaj pracownika");
            Console.WriteLine("2 - dodaj kierownika");
            Console.WriteLine("3 - Odwroc kolejnosc na liscie");
            Console.WriteLine("4 - pokaz liste");
            Console.WriteLine("5 - usun pracownika");
            Console.WriteLine("6 - sortuj liste");
            Console.WriteLine("7 - wyczysc okno");
            Console.WriteLine("8 - wyjdz z aplikacji");


            opcja = Convert.ToInt32(Console.ReadLine());

            while (opcja != 8)
            {
                ListaPlac lista = new ListaPlac();
                switch (opcja)
                {
                    case 1:
                        try
                        {
                            string imie;
                            DateTime dataZatrudnienia;
                            double pensja;
                            Console.WriteLine("Podaj imie");
                            imie = Console.ReadLine();
                            Console.WriteLine("Podaj pensje");
                            pensja = Convert.ToDouble(Console.ReadLine());
                            dataZatrudnienia = DateTime.Now;

                            lista.DodajPracownika(imie,dataZatrudnienia,pensja);
                        }
                        catch
                        {
                            Console.WriteLine("Nie mozna dodac pracownika");
                        }
                        break;
                    case 2:
                        try
                        {
                            string imie;
                            DateTime dataZatrudnienia;
                            double pensja;
                            Console.WriteLine("Podaj imie");
                            imie = Console.ReadLine();
                            Console.WriteLine("Podaj pensje");
                            pensja = Convert.ToDouble(Console.ReadLine());
                            dataZatrudnienia = DateTime.Now;

                            lista.DodajKierownika(imie, dataZatrudnienia, pensja);
                        }
                        catch
                        {
                            Console.WriteLine("Nie udalo sie dodaj kierownika");
                        }
                        break;
                    case 3:
                        try
                        {
                            lista.OdwrocKolejnosc();
                        }
                        catch
                        {
                            Console.WriteLine("Nie udalo sie odwrocic listy");
                        }
                        break;
                    case 4:
                        int nadgodziny=-1;
                        Console.WriteLine("Podaj liczbe nadgodzin(0-40)");
                        try
                        {
                            nadgodziny = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Podano zle informacje");
                        }
                        if (nadgodziny > 40 || nadgodziny < 0)
                            Console.WriteLine("Podano zle informacje");
                        else
                            Console.WriteLine(lista.ToString(nadgodziny));
                        break;
                    case 5:
                        int numer;
                        Console.WriteLine("Podaj numer pracownika ktorego chcesz usunac");
                        try
                        {
                            numer = Convert.ToInt32(Console.ReadLine());
                            lista.UsunPracownika(numer);
                        }
                        catch
                        {
                            Console.WriteLine("Nie udalo sie usunac pracownika");
                        }
                        break;
                    case 6:
                        try
                        {
                            lista.Sortuj();
                        }
                        catch
                        {
                            Console.WriteLine("Nie udal sie posortowac listy");
                        }
                       break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Co chcesz zrobic ?");
                        Console.WriteLine("1 - dodaj pracownika");
                        Console.WriteLine("2 - dodaj kierownika");
                        Console.WriteLine("3 - Odwroc kolejnosc na liscie");
                        Console.WriteLine("4 - pokaz liste");
                        Console.WriteLine("5 - usun pracownika");
                        Console.WriteLine("6 - sortuj liste");
                       Console.WriteLine("7 - wyczysc okno");
                       Console.WriteLine("8 - wyjdz z aplikacji");
                        break;
                    default:
                        Console.WriteLine("Wybrales zla opcje");
                        break;

                }
                opcja = Convert.ToInt32(Console.ReadLine());
            }


        }
        }
    }
