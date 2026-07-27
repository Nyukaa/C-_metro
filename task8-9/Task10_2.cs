using System;
using System.Collections.Generic;

namespace myFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita lause: ");
            var Sentence = Convert.ToString(Console.ReadLine());
            Console.WriteLine(MyJoin(MySplit(Sentence, ' '), ','));
            Console.WriteLine(MyJoin(MySplit(Sentence, ' '), '\n'));
        }

        // --- НАЧАЛО ВАШЕГО КОДА ---
        public static List<string> MySplit(string teksti, char erotin)
        {
            List<string> tulos = new List<string>();
            string nykyinenSana = "";

            foreach (char c in teksti)
            {
                if (c == erotin)
                {
                    if (nykyinenSana != "")
                    {
                        tulos.Add(nykyinenSana);
                        nykyinenSana = "";
                    }
                }
                else
                {
                    nykyinenSana += c;
                }
            }

            if (nykyinenSana != "")
            {
                tulos.Add(nykyinenSana);
            }

            return tulos;
        }

        public static string MyJoin(List<string> lista, char liitin)
        {
            string tulos = "";

            for (int i = 0; i < lista.Count; i++)
            {
                tulos += lista[i];

                if (i < lista.Count - 1)
                {
                    tulos += liitin;
                }
            }

            return tulos;
        }
    
    }
}
