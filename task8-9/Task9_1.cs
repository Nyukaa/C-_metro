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
public class Leffa
{
    // Публичные автоматические свойства класса
    public string Nimi { get; set; }
    public int Kesto { get; set; }
    public int Vuosi { get; set; }

    // Конструктор класса с правильным порядком параметров
    public Leffa(string nimi, int kesto, int vuosi)
    {
        Nimi = nimi;
        Kesto = kesto;
        Vuosi = vuosi;
    }
}

