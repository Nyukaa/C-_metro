using System;

class Program
{
    static void Main(string[] args)
    {
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
                    Console.WriteLine("Lisää Leffa");
                    break;
                case "2":
                    Console.WriteLine("Poista Leffa");
                    break;
                case "3":
                    Console.WriteLine("Näytä Raportti");
                    break;
                case "4":
                    Console.WriteLine("Lataa Tietokanta");
                    break;
                case "5":
                    Console.WriteLine("Tallenna Tietokanta");
                    break;
                default:
                    Console.WriteLine("Tuntematon komento");
                    break;
            }
        }
    }
}
