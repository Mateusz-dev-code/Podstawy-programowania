def kalkulator():
    print("\n--- KALKULATOR ---")

    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))

    operacja = input("Wybierz działanie (+, -, *, /): ")

    if operacja == "+":
        wynik = a + b
    elif operacja == "-":
        wynik = a - b
    elif operacja == "*":
        wynik = a * b
    elif operacja == "/":
        if b == 0:
            print("Nie można dzielić przez zero.")
            return
        wynik = a / b
    else:
        print("Nieznane działanie.")
        return

    print(f"Wynik: {wynik:g}")


def konwerter_temperatur():
    print("\n--- KONWERTER TEMPERATUR ---")
    kierunek = input(
        "Wpisz 'c' - Celsjusz na Fahrenheit lub 'f' - Fahrenheit na Celsjusz: "
    ).lower()

    temperatura = float(input("Podaj temperaturę: "))

    if kierunek == "c":
        wynik = temperatura * 1.8 + 32
        print(f"{temperatura:g}°C = {wynik:.2f}°F")
    elif kierunek == "f":
        wynik = (temperatura - 32) / 1.8
        print(f"{temperatura:g}°F = {wynik:.2f}°C")
    else:
        print("Nieznany kierunek konwersji.")


def srednia_ocen():
    print("\n--- ŚREDNIA OCEN UCZNIA ---")
    liczba_ocen = int(input("Ile ocen chcesz wprowadzić? "))

    if liczba_ocen <= 0:
        print("Liczba ocen musi być większa od zera.")
        return

    suma = 0

    for i in range(1, liczba_ocen + 1):
        ocena = float(input(f"Podaj ocenę nr {i} (od 1 do 6): "))

        if ocena < 1 or ocena > 6:
            print("Ocena musi być z zakresu od 1 do 6.")
            return

        suma = suma + ocena

    srednia = suma / liczba_ocen
    print(f"Średnia: {srednia:.2f}")

    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


def main():
    while True:
        print("\n========== MENU GŁÓWNE ==========")
        print("1. Kalkulator dwóch liczb")
        print("2. Konwerter temperatur")
        print("3. Średnia ocen ucznia")
        print("0. Zakończ program")

        wybor = input("Wybierz zadanie: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor == "0":
            print("Koniec programu.")
            break
        else:
            print("Niepoprawny wybór.")


main()
