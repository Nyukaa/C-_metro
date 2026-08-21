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
            Console.Write("Please select product (1-10) 0 to Quit:");
            int valinta = int.Parse(Console.ReadLine());

            // Условие выхода из цикла
            if (valinta == 0)
            {
                break;
            }

            // Проверка корректности введенного номера товара
            if (valinta < 1 || valinta > 10)
            {
                Console.WriteLine("Please select correct product (1-10)");
                continue; // Возвращаемся в начало цикла
            }

            // Получаем цену товара (индекс равен номеру товара минус 1)
            int hinta = hinnat[valinta - 1];
            kokonaissumma += hinta;

            // Выводим информацию о выбранном товаре
            Console.WriteLine($"Product: {valinta} Price: {hinta}");
        }

        // 3. Расчет и вывод финальной стоимости и сдачи
        Console.WriteLine($"Total: {kokonaissumma}");

        // Считываем сумму оплаты на той же строке
        Console.Write("Payment: ");
        int maksu = int.Parse(Console.ReadLine());

        // Считаем сдачу
        int vaihto = maksu - kokonaissumma;
        Console.WriteLine($"Change: {vaihto}");
    }
}
