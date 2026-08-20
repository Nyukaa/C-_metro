using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Leffa> leffat = new List<Leffa>() { };
        leffat.Add(new Leffa("Robocop", 102, 1987));
        leffat.Add(new Leffa("Robocop 2", 117, 1990));
        leffat.Add(new Leffa("Robocop 3", 104, 1993));

        foreach (var leffa in leffat)
        {
            Console.WriteLine("Nimi: " + leffa.Nimi + ", kesto: " + leffa.Kesto + "min, vuosi: " + leffa.Vuosi);
        }
    }
}




[Serializable]
public class Movie
{
    public string Name { get; set; }
    public int Length { get; set; }
    public int Year { get; set; }

    public Movie(string name, int length, int year)
    {
        Name = name;
        Length = length;
        Year = year;
    }
}
