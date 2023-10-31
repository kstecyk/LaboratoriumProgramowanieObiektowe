while (true)
{
    Console.Write("Podaj liczbę całkowitą (liczba ujemna kończy program): ");
    int liczba = Convert.ToInt32(Console.ReadLine());

    if (liczba < 0)
    {
        Console.WriteLine("Wprowadzono liczbę mniejszą od zera. Koniec programu.");
        break;
    }
}