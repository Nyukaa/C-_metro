using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // 1. Fetch all file paths from the current active folder (".")
        string[] tiedostot = Directory.GetFiles(".");

        // 2. Loop through the array collection and print each item on its own row
        foreach (string tiedosto in tiedostot)
        {
            Console.WriteLine(tiedosto);
        }
    }
}
