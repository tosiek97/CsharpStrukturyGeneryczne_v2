namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa<T>
    {
        private T[] bufor;
        private int poczatekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5)      //konstruktor domyślny - ctor +2xtab
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;
        }

        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;   //tutaj chodzi o to żeby nie przekroczyło to 5, tzn gdy osiągnie 5 to reszta z dzielenia 5/5 to 0 więc zacznie od początku

            if (koniecBufora == poczatekBufora)
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
        }

        public T Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }

        public bool JestPusty
        {
            get
            {
                return koniecBufora == poczatekBufora;
            }
        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == poczatekBufora;
            }
        }
    }
}
