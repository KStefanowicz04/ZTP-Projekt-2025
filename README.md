Wybrany temat: #2 - Aplikacja do zarządzania notatkami i zadaniami

Aplikacja do zarządzania notatkami i zadaniami. Aplikacja umożliwia użytkownikowi tworzenie, edytowanie i organizowanie notatek oraz list zadań. Notatki i zadania można opatrywać tagami (np. „praca”, „pomysł”) lub przypisywać do kategorii (np. „dom”, „projekt”). Zadania można oznaczać jako wykonane i nadawać im priorytety (np. „wysoki”, „niski”) oraz termin realizacji. Aplikacja obsługuje wyszukiwanie po słowach kluczowych, grupowanie według tagów lub kategorii, sortowanie według terminów lub priorytetów oraz generowanie raportów o zbliżających się terminach (np. „na najbliższy tydzień”) i podsumowań o wykonanych i zaległych zadaniach.


UML Przedstawiony 12.12.2025, jest poprawnie


Zadania do wykonania (najlepiej wykonać w kolejności):
- ( ) Interfejs IWpis i klasa Wpis 
- ( ) Klasa Notatka dziedzicząca z Wpis i jej Menedżer
- ( ) Klasa Zadanie dziedzicząca z Wpis i jej Menedżer
- ( ) Klasa Tag i jej Menedżer
- ( ) Abstrakcyjna FabrykaWpisów i dziedziczące po niej Fabryki
- ( ) Interfejs StanZadania i Stany klasy Zadanie
- ( ) Interfejs IBuilder i Builder Klasy Zadanie
Dekoratory:
- ( ) Dekorator ogólny DekoratorWpisów i pochodny DekoratorTagowy
- ( ) Poddekorator DekoratorZadań i pochodny DekoratorStanowy

Funkcjonalności nie zawarte w UML:
- ( ) Wyszukiwanie (po słowach kluczowych, po tagach, po terminach, itp.)
- ( ) Grupowanie wyników wyszukiwania po tagach
- ( ) Sortowanie według terminów, priorytetów
- ( ) Generowanie raportów - wykonane zadania, zaległe zadania, czas do końca terminu 

Funkcjonalności dodatkowe:
- ( ) Kategorie
- ( ) 