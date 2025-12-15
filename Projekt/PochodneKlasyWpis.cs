using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public partial class Program
{
    // Interfejs klasy Wpis
    public interface IWpis
    {
        // Funkcja wypisująca informacje o danym Wpisie (Notatce lub Zadaniu).
        // Treść funkcji i wyniku zależy od klas pochodnych.
        protected abstract string WypiszInformacje();
    }

    // Klasa abstrakcyjna Wpis - służy tylko do bycia bazą pod inne klasy
    protected abstract class Wpis : IWpis
    {
        // Pola klasy Wpis
        // id danego wpisu (generowane przy konstrukcji przez klasy pochodne Notatka i Zadanie, zapisywane w menedżerach)
        private int id;
        private string tytul;  // tytuł danego wpisu
        private string tresc;  // treść danego wpisu
        private DateTime dataUtworzenia;  // data utworzenia wpisu
        private DateTime dataModyfikacji;  // data ostatniej edycji wpisu
        // UWAGA - klasa 'Tag' jeszcze nie istnieje!
        //private List<Tag> tagi;  // lista tagów przypisanych do danego wpisu


        // Konstruktor
        protected Wpis(string tytul, string tresc) : base()
        {
            this.tytul = tytul;  // Podany tytuł
            this.tresc = tresc;  // Podana treść
            dataUtworzenia = DateTime.Now;  // Czas utworzenia
        }

        // Zmienia dane wpisu na te podane w parametrach metody
        protected void Edytuj(string tytul, string tresc)
        {
            this.tytul = tytul;
            this.tresc = tresc;
        }

        // UWAGA - klasa 'Tag' jeszcze nie istnieje!
        // Dodaje podany jako parametr 'tag' do Listy tagów 'tagi'
        //protected void DodajTag(Tag tag)
        //{
        //    tagi.Add(tag);
        //}

        // UWAGA - klasa 'Tag' jeszcze nie istnieje!
        // Usuwa podany jako parametr 'tag' z Listy tagów 'tagi'
        //protected void UsunTag(Tag tag)
        //{
        //    tagi.Remove(tag);
        //}

        // Abstrakcyjna metoda pochodząca od interfejsu IWpis;
        // Nic nie zwraca, metoda powinna zostać nadpisana przez klasy pochodne.
        public abstract string WypiszInformacje();
    }
}