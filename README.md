# Zadanie

> Kolega poprosił Cię o zrobienie code-review. Na co zwrócisz uwagę przeglądając poniższy 
kod? 
Przygotuj w formie tekstowej listę uwag oraz zaproponuj poprawny kod. Sklonuj poniższe 
repozytorium, nanieś poprawki i podeślij link do repozytorium z poprawionym kodem.
Link do repozytorium do code-review: 
https://github.com/Dataedo/ConsoleApp/tree/main/ConsoleApp

# Rozwiązanie

### W pierwszej kolejności próbuję zbudować aplikację.
### W dalszej kolejności próbuję uruchomić aplikację.
### Lista uwag:
1.	Nazwa pliku jest twardo zakodowana w `reader.ImportAndPrintData("dataa.csv");` z literówką, powinno być  `data.csv`

2.	Program nie przewiduje rozwiązania na wypadek wystąpienia pustego wiersza w pliku `data.csv`
 - **Rozwiązanie:** W przypadku wystąpienia pustej linii pętla jest kontynuowana bez niej.
3.	Program nie przewiduje braku występowania którejś pozycji w wierszu (np. pozycji `IsNullable` w wierszu 366 pliku `data.csv`). 
- **Rozwiązanie:** Z braku wytycznych, postanowiłem pomijać każdy wiersz z liczbą składowych mniejszych niż 7.
4.	Pętla for `(int i = 0; i <= importedLines.Count; i++)` nie działa dla ostatniej pozycji z uwagi na uwzględnienie `<= importedLines.Count.`
- **Rozwiązanie:** Najczyściej jest zastąpić tę pętlę pętlą foreach.
5.	W miejscu deklarowania listy `ImportedObjects` niepotrzebnie jest jednocześnie tworzony nowy, pusty obiekt `ImportedObject `.
- **Rozwiązanie:** Tworzenie pustej listy.

### Teraz aplikacja wykonuje kod bezbłędnie z punktu widzenia IDE. 

### Jednak liczba kolumn i tabeli jest zliczana błędnie z uwagi na brak zastosowana `.ToUpper()` dla pola `ParentType`
- **Rozwiązanie:** Wygodniej i bezpieczniej jest wykonywać operację `.ToUpper()` na getterach w klasie. W razie potrzeby łatwo dodać taką funkcjonalność do innych properties.

### W dalszej kolejności sprawdzam, czy nie zajdzie potrzeba refactoringu dla lepszej czytelności i serwisowania kodu:

6.	Wystepuje bardzo dużo zanestowanych  `if`.
a.	Odwrócenie wszystkich `if` (invert)
7.	Inicjalizjacja obiektu `importedObject` może być zapisana w uproszczoy sposób
8.	Niespójne modyfikatory dostępu metod
9.	Niespójne accessors dla properties
10.	Klasy można przenieść do osobnych plików
11.	Klasa bazowa i klada `ImportedObject` zawierają to samo pole `Name`.
