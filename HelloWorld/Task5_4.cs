using System;

// class Program
// {
//     static void Main(string[] args)
    public static class Kvadrantit
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Löydä xy-akseleilla olevan pisteen kvadrantti:");
        
        Console.Write("X-koordinaatti: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Y-koordinaatti: ");
        int y = int.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine($"Koordinaattipiste ({x},{y}) on origossa.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 1.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 2.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 3.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 4.");
        }
    }
}