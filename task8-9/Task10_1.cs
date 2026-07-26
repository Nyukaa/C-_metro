using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Инициализируем массив цен на 10 товаров
        int[] hinnat = { 10, 14, 22, 33, 44, 13, 22, 55, 66, 77 };
        
        int kokonaissumma = 0;

        Console.WriteLine("Supermarket");
        Console.WriteLine("===========");

        // 2. Основной цикл покупки товаров
        while (true)
        {
            // Используем Write, так как ввод идет на той же строке без пробела после двоеточия
            Console.Write("Valitse tuote (1-10) 0 lopetus:");
            int valinta = int.Parse(Console.ReadLine());

            // Условие выхода из цикла
            if (valinta == 0)
            {
                break;
            }

            // Проверка корректности введенного номера товара
            if (valinta < 1 || valinta > 10)
            {
                Console.WriteLine("Anna tuote oikein väliltä (1-10)");
                continue; // Возвращаемся в начало цикла
            }

            // Получаем цену товара (индекс равен номеру товара минус 1)
            int hinta = hinnat[valinta - 1];
            kokonaissumma += hinta;

            // Выводим информацию о выбранном товаре
            Console.WriteLine($"tuote: {valinta} Hinta: {hinta}");
        }

        // 3. Расчет и вывод финальной стоимости и сдачи
        Console.WriteLine($"Yhteensä: {kokonaissumma}");

        // Считываем сумму оплаты на той же строке
        Console.Write("Maksu: ");
        int maksu = int.Parse(Console.ReadLine());

        // Считаем сдачу
        int vaihto = maksu - kokonaissumma;
        Console.WriteLine($"Vaihto: {vaihto}");
    }
}
