using System;

// class Program
// {
//     static void Main(string[] args)
public static class Task5_2
{
    public static void Run()
    {
        Console.WriteLine("Please input the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Проверка условий
        if (num1 > num2)
        {
            Console.WriteLine("Number 1 is greater than number 2.");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("Number 2 is greater than number 1.");
        }
        else
        {
            Console.WriteLine("Numbers are equal.");
        }
    }
}
