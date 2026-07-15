using System;

// class Program
// {
//     static void Main(string[] args)
public static class Suurin
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Syötä ensimmäinen numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Syötä toinen numero: ");
        int num2 = int.Parse(Console.ReadLine());

        // Проверка условий
        if (num1 > num2)
        {
            Console.WriteLine("Numero 1 on suurempi kuin numero 2.");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("Numero 2 on suurempi kuin numero 1.");
        }
        else
        {
            Console.WriteLine("Numerot ovat yhtä suuret.");
        }
    }
}
