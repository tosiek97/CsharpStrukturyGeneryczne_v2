using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Pracownik[] pracownicy = new Pracownik[]            //tablica
            ////{
            ////    new Pracownik{Imie = "Marcin", Nazwisko="Nowak"},
            ////    new Pracownik{Imie = "Jan", Nazwisko="Nowak"},
            ////    new Pracownik{Imie = "Tomek", Nazwisko="Nowak"},
            ////};

            //List<Pracownik> pracownicy = new List<Pracownik>        //lista
            //{
            //    new Pracownik{Imie = "Marcin", Nazwisko="Nowak"},
            //    new Pracownik{Imie = "Jan", Nazwisko="Nowak"},
            //    new Pracownik{Imie = "Tomek", Nazwisko="Nowak"},
            //};

            //pracownicy.Add(new Pracownik { Imie = "Ania", Nazwisko = "Kos" });      //tojest funkcja listy, tablica jej nie ma

            //foreach (var pracownik in pracownicy)
            //{
            //    Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            //}

            ////for (int i = 0; i < pracownicy.Length; i++)
            ////{
            ////    Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            ////}

            ////Array.Resize(ref pracownicy, 10);
            ////pracownicy[9] = new Pracownik { Imie = "Anatol", Nazwisko = "Koszyk" };

            //for (int i = 0; i < pracownicy.Count; i++)
            //{
            //    Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            //}

            ////sprawdzamy tutaj jak lista zwieksza objętość
            //var liczby = new List<int>();
            //var pojemnosc = -1;

            //while (true)
            //{
            //    if (liczby.Capacity != pojemnosc)
            //    {
            //        pojemnosc = liczby.Capacity;
            //        Console.WriteLine(pojemnosc);
            //    }
            //    liczby.Add(1);
            //}               //pojemnosc jest zwiekszana dwukrotnie. jeżeli nie podajemy poczatkowej pojemnosci to wynosi ona 2, 4, 8, 16, 32 etc

            Queue<Pracownik> kolejka = new Queue<Pracownik>();      //kolejka, kazde dodanie nowego elemetnu do kolejki dodaje je na koniec kolejki
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Kowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Zajac" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
