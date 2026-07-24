using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // 1. Prompt for and capture the file name input
        // Note: No trailing space after the colon to support strict comparison logic
        Console.Write("Tiedostonimi: ");
        string tiedostonimi = Console.ReadLine();

        // 2. Request the string text content for that specific destination file
        Console.WriteLine($"Sisalto tiedostolle {tiedostonimi}:");
        string sisalto = Console.ReadLine();

        // 3. Commit the dynamic contents onto the filesystem
        File.WriteAllText(tiedostonimi, sisalto);
    }
}
