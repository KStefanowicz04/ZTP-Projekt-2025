using System.Collections.Generic;
using System.Linq;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public partial class Program
{

    public enum StanZadania
    {
        Aktywne,
        Wykonane,
        Zalegle
    }

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


    }
 }