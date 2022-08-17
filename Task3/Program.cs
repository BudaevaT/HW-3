using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine(Math.Pow(i, 3));
    }
}