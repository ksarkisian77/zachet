/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат:");
        PrintNumbers(N);
    }

    static void PrintNumbers(int num)
    {
        if (num >= 1)
        {
            Console.Write(num + ", ");
            PrintNumbers(num - 1);
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1;
        int N = 15;

        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", M, N, sum);
    }
}

*/
//Вывод программы будет:

//Сумма натуральных элементов от 1 до 15 равна 120



using System;

class Program
{
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = AckermannFunction(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");

        m = 3;
        n = 2;
        result = AckermannFunction(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");

        Console.ReadLine();
    }
}
