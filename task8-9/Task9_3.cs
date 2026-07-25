using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Создаем список для хранения фильмов
        List<Leffa> leffat = new List<Leffa>();

        while (true)
        {
            // Сохраняем вашу структуру пустых строк, подогнанную под тесты
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
                    
                    // Запрашиваем данные БЕЗ пробела на конце двоеточия (строго по примеру)
                    Console.Write("Nimi:");
                    string nimi = Console.ReadLine();
                    
                    Console.Write("Kesto (min):");
                    int kesto = int.Parse(Console.ReadLine());
                    
                    Console.Write("Vuosi:");
                    int vuosi = int.Parse(Console.ReadLine());

                    // Создаем объект фильма и добавляем его в список
                    leffat.Add(new Leffa(nimi, kesto, vuosi));
                    break;

                case "2":
                    Console.WriteLine("Poista Leffa");
                    break;

                case "3":
                    int yhteiskesto = 0;

                    // Выводим каждый фильм из списка
                    foreach (var leffa in leffat)
                    {
                        Console.WriteLine($"{leffa.Nimi} ({leffa.Vuosi}), {leffa.Kesto} minuuttia.");
                        yhteiskesto += leffa.Kesto; // Считаем общую продолжительность
                    }

                    // Печатаем пустую строчку перед итоговой статистикой, если это требуется по визуалу примера
                    Console.WriteLine();

                    // Выводим финальную строку отчета
                    Console.WriteLine($"Leffoja katsottu yhteensä {leffat.Count}, yhteiskesto {yhteiskesto} minuuttia.");
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

// Класс из задания 6.1, который обязательно должен быть в коде для работы списка
[Serializable]
public class Leffa
{
    public string Nimi { get; set; }
    public int Kesto { get; set; }
    public int Vuosi { get; set; }

    public Leffa(string nimi, int kesto, int vuosi)
    {
        Nimi = nimi;
        Kesto = kesto;
        Vuosi = vuosi;
    }
}
