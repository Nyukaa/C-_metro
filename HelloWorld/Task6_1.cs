using System;

// class Program
// {
//     static void Main(string[] args)
 public static class Toistuvat
{
    public static void Run(string[] args)
    {
    // {
    //     // Парсим число из первого аргумента командной строки
    //     int n = int.Parse(args[0]);

    //     // Перебираем строки от 1 до n
    //     for (int i = 1; i <= n; i++)
    //     {
    //         // На каждой строке печатаем числа от 1 до i
    //         for (int j = 1; j <= i; j++)
    //         {
    //             Console.Write(j);
    //         }
    //         Console.WriteLine(); // Переход на новую строку
    //     }
    // }
     {
        // 1. Guard against empty command-line arguments to prevent IndexOutOfRangeException
        if (args == null || args.Length == 0)
        {
            return; // Gracefully exit if no argument is passed
        }

        // 2. Parse the first argument safely
        // When testing locally, make sure to type a pure number: dotnet run 12
        if (int.TryParse(args[0], out int n))
        {
            // Outer loop: controls rows (1 to n)
            for (int i = 1; i <= n; i++)
            {
                // Inner loop: prints numbers in a single row without spaces
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); // Newline at the end of each row
            }
        }
}
    }}