using System;

    // class Program
    // {
    //     static void Main(string[] args)
    public static class SwitchValikko
{
    public static void Run(string[] args)
    {
        // Вывод меню
        Console.WriteLine("Valitse:");
        Console.WriteLine("1) Vesi");
        Console.WriteLine("2) Mehu");
        Console.WriteLine("3) Limonadi");
        Console.WriteLine("4) Lopeta");

        // Чтение выбора пользователя
        string valinta = Console.ReadLine();

        // Обработка через switch
        switch (valinta)
        {
            case "1":
                Console.WriteLine("Valitsit Vesi.");
                break;
            case "2":
                Console.WriteLine("Valitsit Mehu.");
                break;
            case "3":
                Console.WriteLine("Valitsit Limonadi.");
                break;
            case "4":
                Console.WriteLine("Lopetus!");
                break;
        }
    }
}
