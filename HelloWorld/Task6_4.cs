using System;

// class Program
// {
//     static void Main(string[] args)
public static class Kuplalajittelu
{
    public static void Run(string[] args)
    {
        int n = args.Length;
        int[] a = new int[n];

        // Заполняем числовой массив из аргументов командной строки
        int index = 0;
        foreach (string arg in args)
        {
            a[index] = int.Parse(arg);
            index++;
        }

        // Алгоритм пузырьковой сортировки по псевдокоду
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    // Меняем элементы местами (swap)
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        // Вывод отсортированного массива с пробелом в конце каждого числа
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
}
