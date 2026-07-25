using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<Leffa> leffat = new List<Leffa>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine("Leffojen Katseluloki");
            Console.WriteLine("====================");
            Console.WriteLine("1) Lisää Leffa");
            Console.WriteLine("2) Poista Leffa");
            Console.WriteLine("3) Näytä Raportti");
            Console.WriteLine("4) Lataa Tietokanta");
            Console.WriteLine("5) Tallenna Tietokanta");
            Console.WriteLine("6) Lopeta");

            Console.Write("Syöte: ");
            string syote = Console.ReadLine();

            if (syote == "6")
            {
                Console.WriteLine();                 
                break;
            }

            Console.WriteLine(); 

            switch (syote)
            {
                case "1":
                    Console.WriteLine("Lisää Leffa:");
                    
                    Console.Write("Nimi:");
                    string nimi = Console.ReadLine();
                    
                    Console.Write("Kesto (min):");
                    int kesto = int.Parse(Console.ReadLine());
                    
                    Console.Write("Vuosi:");
                    int vuosi = int.Parse(Console.ReadLine());

                    leffat.Add(new Leffa(nimi, kesto, vuosi));
                    break;

                case "2":
                    Console.WriteLine("Poista Leffa:");
                    
                    for (int i = 0; i < leffat.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {leffat[i].Nimi} ({leffat[i].Vuosi}), {leffat[i].Kesto} minuuttia.  ");
                    }
                    
                    Console.Write("Syöte: ");
                    int valinta = int.Parse(Console.ReadLine());
                    
                    if (valinta > 0 && valinta <= leffat.Count)
                    {
                        leffat.RemoveAt(valinta - 1);
                    }
                    break;

                case "3":
                    int yhteiskesto = 0;

                    foreach (var leffa in leffat)
                    {
                        Console.WriteLine($"{leffa.Nimi} ({leffa.Vuosi}), {leffa.Kesto} minuuttia.  ");
                        yhteiskesto += leffa.Kesto; 
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Leffoja katsottu yhteensä {leffat.Count}, yhteiskesto {yhteiskesto} minuuttia.");
                    break;

                case "4":
                    Console.WriteLine("Lataa Tietokanta");
                    break;

                case "5":
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Leffa>));
                    
                    using (StreamWriter writer = new StreamWriter("tietokanta.xml"))
                    {
                        serializer.Serialize(writer, leffat);
                    }
                    
                    Console.WriteLine("Tietokanta tallennettu.");
                    break;

                default:
                    Console.WriteLine("Tuntematon komento");
                    break;
            }
        }
    }
}

[Serializable]
public class Leffa
{
    public string Nimi { get; set; }
    public int Kesto { get; set; }
    public int Vuosi { get; set; }

    public Leffa() { }

    public Leffa(string nimi, int kesto, int vuosi)
    {
        Nimi = nimi;
        Kesto = kesto;
        Vuosi = vuosi;
    }
}
