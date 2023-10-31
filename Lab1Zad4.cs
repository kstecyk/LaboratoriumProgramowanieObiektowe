static double DoubleInput()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

static List<double> createList()
{
    List<double> listaLiczb = new List<double>();
    

    // Wprowadzanie 10 liczb rzeczywistych
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Wprowadź {i + 1} liczbę rzeczywistą: ");
        listaLiczb.Add(DoubleInput());

    }
    return listaLiczb;
}


static void Zadanie3()
{
    Console.WriteLine("========== Wprowadz 10 liczb rzeczywistych =================");
    List<double> liczby = createList();
    while (true)
        Menu(liczby);


}



static void Menu(List<double> liczby)
{
ViewMenu:
    Console.WriteLine("========== Operacje na liscie =================");
    Console.WriteLine("========== 1. Suma el. listy =================");
    Console.WriteLine("========== 2. Iloczyn el. listy =================");
    Console.WriteLine("========== 3. Średnia z el. listy =================");
    Console.WriteLine("========== 4. Minimalny el. listy =================");
    Console.WriteLine("========== 5. Maksymalny el. listy =================");
    Console.WriteLine("========== 6. Wyjdź =================");
    Console.WriteLine("Twoj wybor: ");
    int choise = Convert.ToInt32(Console.ReadLine());

    switch (choise)
    {
        case 1: Suma(liczby); break;
        case 2: Iloczyn(liczby); break;
        case 3: Srednia(liczby); break;
        case 4: Min(liczby); break;
        case 5: Max(liczby); break;
        case 6: Close(); break;
        default:
            Console.WriteLine("Bledy wybor, sprobuj ponowanie: ");
            goto ViewMenu;

    }
}


static void Suma(List<double> liczby)
{
    Console.WriteLine($"Suma: {liczby.Sum()}");
}


static void Iloczyn(List<double> liczby)
{
    double result = 1;
 foreach (double d in liczby)
    {
        result = result * d;
    }
    Console.WriteLine($"Iloczyn: {result}");
}

static void Srednia(List<double> liczby)
{
    Console.WriteLine($"Średnia: {liczby.Average()}");
}

static void Min(List<double> liczby)
{

    Console.WriteLine($"Wartość minimalna: {liczby.Min()}");

}

static void Max(List<double> liczby)
{
    Console.WriteLine($"Wartość maksymalna: {liczby.Max()}");
}
static void Close()
{
    Console.WriteLine("Dziekujemy za skorzystanie z tego czegos.");
    Environment.Exit(0);
}


Zadanie3();