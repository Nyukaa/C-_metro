using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // 1. Get all files matching the "*.dat" pattern in the current folder (".")
        string[] datTiedostot = Directory.GetFiles(".", "*.dat");
        int poistettuMaara = 0;

        // 2. Loop through the array and delete each file safely
        foreach (string tiedosto in datTiedostot)
        {
            if (File.Exists(tiedosto))
            {
                File.Delete(tiedosto);
                poistettuMaara++;
            }
        }

        // 3. Print the final message exactly matching the strict expected output format
        Console.WriteLine($"{poistettuMaara} tiedosto(a) poistettu.");
    }
}
