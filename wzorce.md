#WZORCE UŻYTE W PROJEKCIE

##Wzorce kreacyjne
-Singleton (MenedżerNotatek i MenedżerZadań) ++
-Factory (tworzenie Wpisów, konkretnie Notatek lub Zadań) ++
-Builder (upraszcza tworzenie obiektów) ++

##Wzorce strukturalne
-Decorator (wypisywanie dodatkowych informacji o obiektach klas Notatka i Zadanie - dekorator wypisujący tagi (dla obu klas), dekorator wypisujący termin, priorytet, status, etc. (tylko dla obiektów Zadanie)) ++

##Wzorce czynnościowe
-State (wybieranie między Statusami zadania) ++


#Dostępne wzorce:
Singleton
Multiton
Object pool
Factory Method
Prototype
Builder
Proxy
Adapter
Composite
Decorator
Command
State
Observer




Poprawki, wyjaśnienie nowego UML:
Dodałem polskie znaki. W kodzie ich nie będzie, ale tak jest łatwiej czytać ULM.
Zmieniłem formatowanie: pola (zmienne) w camelCase, metody (funkcje) i klasy w PascalCase, to standard w C#.
Menedżerowie Notatek i Zadań są Singletonami.
Połączyłem wspólne pola i metody klas Notatka i Zadanie w jeden abstrakcyjny Wpis, z którego obie te klasy dziedziczą. Ponieważ Notatka nie różni się niczym od Wpis (a powinna żeby skorzystać ze wzorca Factory), dodałem zmienną Ulubiona, której nie ma w klasie Zadanie (zamiast tego niech zostanie Priorytet żeby je odróżnić).
Dodałem abstrakcyjną Fabrykę i dziedziczące z niej Fabryki Notatek i Zadań. Tworzenie Notatek i Zadań odybywa się poprzez Menedżerów, a one następnie wzywają Fabryki do tworzenia Notatek i Zadań. Utworzone Notatki/Zadania dodawane są do List w Menedżerach. To wygląda na skomplikowane na UML bo jest dużo abstrakcyjnych klas, ale to nie jest trudne do zrobienia.
Dodałem ManadżeraTagów. Tagi są tworzone poprzez Menadżera. Menadżer ma Listę wszystkich unikalnych tagów (unikalne tagi to takie, które mają unikalną nazwę - usunąłem 'id'). Każdy tag ma listę Notatek i Zadań do których jest przypisany. Każda Notatka i Zadanie ma listę swoich tagów (Lista ta jest dziedziczona z klasy Wpis).
Tak będzie najłatwiej sortować Notatki/Zadania po tagach.
Notatki i Zadania korzystają z dekoratorów. W podstawie obu klas istnieje metoda WypiszInformacje(), która powinna (potem, w kodzie) wypisywać podstawowe informacje o obiekcie - ID, tytuł, daty, etc. Żeby wyświetlić więcej informacji, istnieją dekorator wypisujący tagi danej Notatki lub Zadania oraz dekorator tylko do Zadań wypisujący dodatkowe informacje o Zadaniu.
Enum StatusZadania zastąpiłem Stanami.
Usunąłem Grupowanie, Sortowanie, Raport. Wstawimy to potem do UML jak będzie trzeba, na razie nie ma po co.