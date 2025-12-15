
// Program główny
// "partial class" oznacza jedynie, że kod całego programu jest porozsiewany po wielu plikach.
// Wszystkie pliki w projekcie powinny zaczynać się od "public partial class Program"
public partial class Program
{

    // Funkcja Main - wykonuje program
    static void Main(string[] args)
    {

        // Menu główne
        while (true)
        {
            Console.WriteLine("\n\nWybierz zadanie:\n1: (zadanie 1, zestaw d; podpunkty II i V)\n2: (zadanie 3)\n3: (zadanie 5)");
            string command = Console.ReadLine();  // Odczytuje komendę z klawiatury - może to być liczba albo słowo.

            switch (command)
            {
                // Przykładowa komenda 1
                case "komenda1":
                    //tu_idzie_nazwa_funkcji();  // przykładowe wyowłanie funkcji
                    Console.WriteLine("Wywołano komendę1");
                    break;

                // Przykładowa komenda 2
                case "komenda2":
                    //tu_idzie_nazwa_funkcji();  // przykładowe wyowłanie funkcji
                    Console.WriteLine("Wywołano komendę2");
                    break;

                // W przypadku podania nieodpowiedniej komendy, należy wpisać coś innego.
                default:
                    Console.WriteLine("Podaj poprawną komendę");
                    break;
            }
        }
    }
}