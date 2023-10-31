Console.Write("Podaj liczbę elementów do posortowania: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] liczby = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Podaj liczbę #{i + 1}: ");
    liczby[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Liczby przed sortowaniem:");
PrintNumbers(liczby);

BubbleSort(liczby);

Console.WriteLine("Liczby po sortowaniu:");
PrintNumbers(liczby);


static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

static void PrintNumbers(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
