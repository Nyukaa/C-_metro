using System;

// class Program
// {
//     static void Main(string[] args)
public static class KiviPaperiSakset
{
    public static void Run(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            // Вывод меню строго по примеру
            Console.WriteLine("Torakka-Jalka-Ydinase. Valitse 1-4.");
            Console.WriteLine("1) Torakka 2) Jalka 3) Ydinase 4) Poistu");

            string syote = Console.ReadLine();

            // Если пользователь выбрал выход
            if (syote == "4")
            {
                break;
            }

            int playerChoice;
            // Проверяем, что введено именно число от 1 до 3
            if (!int.TryParse(syote, out playerChoice) || playerChoice < 1 || playerChoice > 3)
            {
                continue; // Если ввели некорректные данные, запускаем цикл заново
            }

            // Текстовое представление выбора игрока
            string playerText = "";
            if (playerChoice == 1) playerText = "Torakka";
            if (playerChoice == 2) playerText = "Jalka";
            if (playerChoice == 3) playerText = "Ydinase";

            // Выводим подтверждение выбора игрока: "3 Ydinase! "
            Console.WriteLine($"{playerChoice} {playerText}! ");

            // Генерируем выбор компьютера (от 1 до 3 включительно)
            int computerChoice = random.Next(1, 4);
            string computerText = "";
            if (computerChoice == 1) computerText = "Torakka";
            if (computerChoice == 2) computerText = "Jalka";
            if (computerChoice == 3) computerText = "Ydinase";

            // Логика определения победителя
            string tulos = "";
            if (playerChoice == computerChoice)
            {
                tulos = "Tasapeli!";
            }
            // Условия победы игрока:
            // 1 бьет 3 (Таракан бьет Ядерное оружие)
            // 2 бьет 1 (Нога бьет Таракана)
            // 3 бьет 2 (Ядерное оружие бьет Ногу)
            else if ((playerChoice == 1 && computerChoice == 3) ||
                     (playerChoice == 2 && computerChoice == 1) ||
                     (playerChoice == 3 && computerChoice == 2))
            {
                tulos = "Voitit!";
            }
            else
            {
                tulos = "Hävisit!";
            }

            // Вывод финальной строки раунда
            Console.WriteLine($"Tietokone valitsi: {computerText}. {tulos} ");
            Console.WriteLine(); // Пустая строка для разделения раундов, если требуется системой
        }
    }
}
