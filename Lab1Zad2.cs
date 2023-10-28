static double DoubleInput()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}
static void Zadanie2()
{
    Menu();
}

static void Menu()
{
ViewMenu:
    Console.WriteLine("========== Kalkulator =================");
    Console.WriteLine("========== 1. Suma =================");
    Console.WriteLine("========== 2. Roznica =================");
    Console.WriteLine("========== 3. Iloczyn =================");
    Console.WriteLine("========== 4. Iloraz =================");
    Console.WriteLine("========== 5. Potegowanie =================");
    Console.WriteLine("========== 6. Pierwisatek z liczby =================");
    Console.WriteLine("========== 7. Funkcje trygonometryczne zadanego kata =================");
    Console.WriteLine("========== 8. Wyjscie =================");
    Console.WriteLine("Twoj wybor: ");
    int choise = Convert.ToInt32(Console.ReadLine());

    switch (choise)
    {
        case 1: Total(); break;
        case 2: Difference(); break;
        case 3: ProductNumber(); break;
        case 4: QuotientNumber(); break;
        case 5: ExponentiationNumber(); break;
        case 6: SquareNumber(); break;
        case 7: Trigonometry(); break;
        case 8: Close(); break;
        default:
            Console.WriteLine("Bledy wybor, sprobuj ponowanie: ");
            goto ViewMenu;

    }
}

static void Total()
{
    double a = DoubleInput();
    double b = DoubleInput();

    double result = a + b;
    Console.WriteLine("Wynik: " + result);

}


static void Difference()
{
    Console.WriteLine("Podaj pierwsza liczbe: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj druga liczbe: ");
    double b = Convert.ToDouble(Console.ReadLine());
    double result = a - b;
    Console.WriteLine("Wynik: " + result);
}

static void ProductNumber()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double result = a * b;
    Console.WriteLine("Wynik: " + result);
}

static void QuotientNumber()
{
    double a = DoubleInput();
    double b = DoubleInput();

    if (b == 0)
    {
        Console.WriteLine("Nie można dzielić przez zero.");
    }
    else
    {
        double result = a / b;
        Console.WriteLine("Wynik: " + result);
    }
}

static void ExponentiationNumber()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double result = Math.Pow(a, b);
    Console.WriteLine("Wynik: " + result);
}

static void SquareNumber()
{
    double a = DoubleInput(); ;

    if (a < 0)
    {
        Console.WriteLine("Nie można obliczyć pierwiastka z liczby ujemnej.");
    }
    else
    {
        double result = Math.Sqrt(a);
        Console.WriteLine("Wynik: " + result);
    }
}

static void Trigonometry()
{

    double angle = DoubleInput();
    double radians = Math.PI * angle / 180.0;

    double sinValue = Math.Round(Math.Sin(radians), 2);
    double cosValue = Math.Round(Math.Cos(radians), 2);
    double tanValue = Math.Round(Math.Tan(radians), 2);

    Console.WriteLine("Sinus(" + angle + "°) = " + sinValue);
    Console.WriteLine("Cosinus(" + angle + "°) = " + cosValue);
    Console.WriteLine("Tangens(" + angle + "°) = " + tanValue);
}

static void Close()
{
    Console.WriteLine("Dziekujemy za skorzystanie z kalkulatora.");
    Environment.Exit(0);
}

while (true)
Zadanie2();