static double DoubleInput()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

static double[] createArray()
{
    double[] liczby = new double[10];

    // Wprowadzanie 10 liczb rzeczywistych
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Wprowadź {i + 1} liczbę rzeczywistą: ");
        liczby[i] = DoubleInput();

    }
    return liczby;
}


static void Zadanie3()
{
    Console.WriteLine("========== Wprowadz 10 liczb rzeczywistych =================");
    double[] liczby = createArray();
    while (true)
        Menu(liczby);
   
    
}



static void Menu(double[] liczby)
{
ViewMenu:      
    Console.WriteLine("========== Operacje na tablicy =================");
    Console.WriteLine("========== 1. Tablica od pierwszego do ostatniego indeksu =================");
    Console.WriteLine("========== 2. Tablica od ostatniego do pierwszego indeksu =================");
    Console.WriteLine("========== 3. Elementy o nieparzystych indeksach =================");
    Console.WriteLine("========== 4. Elementy o parzystych indeksach =================");
    Console.WriteLine("========== 5. Wyjdz =================");
    Console.WriteLine("Twoj wybor: ");
    int choise = Convert.ToInt32(Console.ReadLine());
    
    switch (choise)
    {
        case 1: firstToLast(liczby); break;
        case 2: lastToFirst(liczby); break;
        case 3: Odd(liczby); break;
        case 4: Even(liczby); break;
        case 5: Close(); break;
        default:
            Console.WriteLine("Bledy wybor, sprobuj ponowanie: ");
            goto ViewMenu;

    }
}


static void firstToLast(double[] liczby)
{
    Console.WriteLine("Tablica od pierwszego do ostatniego indeksu:");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(liczby[i]);
    }
}


static void lastToFirst(double[] liczby)
{
    Console.WriteLine("Tablica od ostatniego do pierwszego indeksu:");
    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine(liczby[i]);
    }
}

static void Odd(double[] liczby)
{
    Console.WriteLine("Elementy o nieparzystych indeksach:");
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 != 0)
        {                                                                                                       
            Console.WriteLine(liczby[i]);
        }
    }
}

static void Even(double[] liczby)
{
    Console.WriteLine("Elementy o parzystych indeksach:");
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(liczby[i]);
        }
    }
}

static void Close()
{
    Console.WriteLine("Dziekujemy za skorzystanie z tego czegos.");
    Environment.Exit(0);
}


Zadanie3();