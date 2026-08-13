using System;

// class Program
// {
//     static void Main(string[] args)
//     {
public static class Task6_2
{
    public static void Run(string[] args)
{
        int summa = 0;

        while (summa < 200)
        {
            Console.Write($"Sum is now {summa}. Input: ");
            int syote = int.Parse(Console.ReadLine());
            summa += syote;
        }

        Console.WriteLine($"Reached 200. The total was {summa}.");
    }
    }

