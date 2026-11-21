using System;

class Program
{
    static void Main()
    {
        bool dziala = true;

        while (dziala)
        {
            Console.WriteLine("\n========== MENU GŁÓWNE ==========");
            Console.WriteLine("1. Kalkulator dwóch liczb");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.WriteLine("0. Zakończ program");
            Console.Write("Wybierz zadanie: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    KonwerterTemperatur();
                    break;
                case "3":
                    SredniaOcen();
                    break;
                case "0":
                    dziala = false;
                    Console.WriteLine("Koniec programu.");
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    break;
            }
        }
    }

    static void Kalkulator()
    {
        Console.WriteLine("\n--- KALKULATOR ---");

        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Wybierz działanie (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik;

        switch (operacja)
        {
            case "+":
                wynik = a + b;
                break;
            case "-":
                wynik = a - b;
                break;
            case "*":
                wynik = a * b;
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Nie można dzielić przez zero.");
                    return;
                }
                wynik = a / b;
                break;
            default:
                Console.WriteLine("Nieznane działanie.");
                return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }

    static void KonwerterTemperatur()
    {
        Console.WriteLine("\n--- KONWERTER TEMPERATUR ---");
        Console.Write("Wpisz 'c' - Celsjusz na Fahrenheit lub 'f' - Fahrenheit na Celsjusz: ");
        string kierunek = Console.ReadLine().ToLower();

        Console.Write("Podaj temperaturę: ");
        double temperatura = double.Parse(Console.ReadLine());

        if (kierunek == "c")
        {
            double wynik = temperatura * 1.8 + 32;
            Console.WriteLine(temperatura + "°C = " + wynik.ToString("F2") + "°F");
        }
        else if (kierunek == "f")
        {
            double wynik = (temperatura - 32) / 1.8;
            Console.WriteLine(temperatura + "°F = " + wynik.ToString("F2") + "°C");
        }
        else
        {
            Console.WriteLine("Nieznany kierunek konwersji.");
        }
    }

    static void SredniaOcen()
    {
        Console.WriteLine("\n--- ŚREDNIA OCEN UCZNIA ---");
        Console.Write("Ile ocen chcesz wprowadzić? ");
        int liczbaOcen = int.Parse(Console.ReadLine());

        if (liczbaOcen <= 0)
        {
            Console.WriteLine("Liczba ocen musi być większa od zera.");
            return;
        }

        double suma = 0;

        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write("Podaj ocenę nr " + i + " (od 1 do 6): ");
            double ocena = double.Parse(Console.ReadLine());

            if (ocena < 1 || ocena > 6)
            {
                Console.WriteLine("Ocena musi być z zakresu od 1 do 6.");
                return;
            }

            suma = suma + ocena;
        }

        double srednia = suma / liczbaOcen;
        Console.WriteLine("Średnia: " + srednia.ToString("F2"));

        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zdał.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zdał.");
        }
    }
}
