using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // 1. Prompt for the target file name
        // Note the trailing space after the colon matching: "Tiedosto johon lisätään: foobar.txt"
        Console.Write("Tiedosto johon lisätään: ");
        string tiedostonimi = Console.ReadLine();

        // 2. Request the string content to be appended to that specific file
        Console.WriteLine($"Syötä tiedostoon {tiedostonimi} lisättävä sisältö:");
        string sisalto = Console.ReadLine();

        // 3. Append the dynamic text payload onto the filesystem
        // File.AppendAllText ensures existing content is preserved and the new line is added at the end
        File.AppendAllText(tiedostonimi, sisalto + Environment.NewLine);
    }
}
