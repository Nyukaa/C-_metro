// using System;

// class Program
// {
//     static void Main(string[] args)
    using System;

public static class Aanioikeus
{
    public static void Run(string[] args)
{
        Console.WriteLine("Syötä ikäsi, ole hyvä: ");
        
        // Считываем возраст и конвертируем в число
        int ika = int.Parse(Console.ReadLine());

        // Проверяем условие
        if (ika >= 18)
        {
            Console.WriteLine("Voit äänestää!");
        }
    }
}