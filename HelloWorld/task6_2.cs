using System;

// class Program
// {
//     static void Main(string[] args)
//     {
public static class Summaus
{
    public static void Run(string[] args)
    {
        int summa = 0;

        // Цикл работает, пока сумма меньше 200
        while (summa < 200)
        {
            // Обратите внимание на пробел после двоеточия в "Syöte: "
            Console.Write($"Summa on nyt {summa}. Syöte: ");
            int syote = int.Parse(Console.ReadLine());
            summa += syote;
        }

        // Финальный вывод после выхода из цикла
        Console.WriteLine($"Saavutettiin 200. Summa oli {summa}.");
    }
}
