using System.Collections.Generic;
using System.Linq;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public partial class Program
{

    public enum Priorytet
    {
        Niski,
        Sredni,
        Wysoki
    }
    public class Zadanie : Wpis
    {
        private StanZadania stan;
        private Priorytet priorytet;
        private DateTime termin;

        public Zadanie(StanZadania stan, Priorytet priorytet, DateTime termin
            ) : base(tytul, tresc)
        {
            this.stan = stan;
            this.priorytet = priorytet;
            this.termin = termin;
        }

        public override void Edytuj(string tytul, string tresc, Priorytet priorytet, DateTime termin)
        {
            base.Edytuj(tytul, tresc);
            this.priorytet = priorytet;
            this.termin = termin;
        }
        public void OznaczJakoWykonane()
        {
            stan = StanZadania.Wykonane;
        }
        public void ZmienStan(StanZadania stan)
        {
            this.stan = stan;
        }
        public void StanWykonane()
        {
            stan = StanZadania.Wykonane;
        }

        public void StanAktywne()
        {
            stan = StanZadania.Aktywne;
        }

        public void StanZalegle()
        {
            stan = StanZadania.Zalegle;
        }
        public bool SprawdzCzyZalegle()
        {
            if (stan == StanZadania.Wykonane)
                return false;

            return DateTime.Now > termin;
        }
        public override string WypiszInformacje()
        {
            return $"[ZADANIE] {tytu³} | {priorytet} | Termin: {termin:d} | Stan: {stan.GetType().Name}";
        }
    }
    public class MenedzerZadan
    {

        private static MenedzerZadan instancja;
        private FabrykaZadan fabryka;
        private List<Zadanie> zadania;
       
        private MenedzerZadan()
        {
            fabryka = new FabrykaZadan();
            zadania = new List<Zadanie>();
        }
        public static MenedzerZadan GetterInstancji()
        {
            if (instancja == null)
            {
                instancja = new MenedzerZadan();
            }
            return instancja;
        }
        public void UtworzZadaniePrzezFabryke(string tytul,string tresc,Priorytet priorytet,DateTime termin,List<Tag> tagi)
        {
            // Wywo³ujemy fabrykê, tworzymy Zadanie
            var zadanie = (Zadanie)fabryka.UtwórzWpis(tytu³, treœæ, priorytet, termin, tagi);

            // Dodajemy do listy mened¿era
            zadania.Add(zadanie);
        }
        public void UsunZadanie(Zadanie zadanie)
        {
            zadania.Remove(zadanie);
        }
        public void WypiszZadanie()
        {
            foreach (var z in zadania)
            {
                Console.WriteLine(z.WypiszInformacje());
            }
        }
        public List<Zadanie> SzukajZadan(string fraza)
        {
            List<Zadanie> wynik = new List<Zadanie>();

            foreach (var z in zadania)
            {
                // zak³adamy, ¿e Wpis ma dostêp do tytu³u (getter)
                if (z.WypiszInformacje().Contains(fraza))
                {
                    wynik.Add(z);
                }
            }

            return wynik;
        }
        public void OznaczZadaniaJakoWykonane(List<Zadanie> lista)
        {
            foreach (var z in lista)
            {
                z.OznaczJakoWykonane();
            }
        }
        public List<Zadanie> WybierzZalegle()
        {
            List<Zadanie> zalegle = new List<Zadanie>();

            foreach (var z in zadania)
            {
                if (z.SprawdzCzyZalegle())
                    zalegle.Add(z);
            }

            return zalegle;
        }
    }
    public class FabrykaZadan : FabrykaWpisow
    {
        // Konstruktor
        public FabrykaZadan() : base()
        {
        }

        // Nadpisanie metody fabrykuj¹cej wpis
        public override Wpis UtworzWpis(string tytul, string tresc, List<Tag> tagi)
        {
            // Domyœlne wartoœci priorytetu i terminu, mo¿na póŸniej rozszerzyæ parametry
            Priorytet domyslnyPriorytet = Priorytet.Normalny;
            DateTime domyslnyTermin = DateTime.Now.AddDays(7); // np. tydzieñ od dziœ

            return new Zadanie(tytul, tresc, domyslnyPriorytet, domyslnyTermin, tagi);
        }

       
    }
} 