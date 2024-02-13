Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return; // Ломает всю программу
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);

}

ShowNumbers(M, N);