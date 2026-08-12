using System;

// class Program
// {
//     static void Main(string[] args)
    public static class Kvadrantit
{
    public static void Run()
    {
        Console.WriteLine("Find the quadrant for a point in x-y axis:");
        
        Console.Write("X coordinate: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Y coordinate: ");
        int y = int.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is in the First quandrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is in the Second quandrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is in the Third quandrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is in the Fourth quandrant.");
        }
    }
}