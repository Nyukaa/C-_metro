// using System;

// class Program
// {
//     static void Main(string[] args)
    using System;

public static class Task5_1
{
    public static void Run()
{
        Console.WriteLine("Please input your age: ");
        
        // Считываем возраст и конвертируем в число
        int ika = int.Parse(Console.ReadLine());

        if (ika >= 18)
        {
            Console.WriteLine("You can cast your vote!");
        }
    }
}