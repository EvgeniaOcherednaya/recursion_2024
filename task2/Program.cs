int findFunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return findFunctionAkkerman(m - 1, 1);
    else return findFunctionAkkerman(m - 1, findFunctionAkkerman(m, n - 1));
}

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman = findFunctionAkkerman(M, N);

Console.Write($"Функция Аккермана = {Akkerman} ");