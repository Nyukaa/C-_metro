using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            


            Console.WriteLine(); 
            Console.WriteLine("Movie Watchlog");
            Console.WriteLine("====================");
            Console.WriteLine("1) Add a Movie");
            Console.WriteLine("2) Delete a Movie");
            Console.WriteLine("3) Show Report");
            Console.WriteLine("4) Load Database");
            Console.WriteLine("5) Save Database");
            Console.WriteLine("6) Quit");

            Console.Write("Input: ");
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
                    Console.WriteLine("Add a Movie");
                    break;
                case "2":
                    Console.WriteLine("Delete a Movie");
                    break;
                case "3":
                    Console.WriteLine("Show Report");
                    break;
                case "4":
                    Console.WriteLine("Load Database");
                    break;
                case "5":
                    Console.WriteLine("Save Database");
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }
}
