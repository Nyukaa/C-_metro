using System;
using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
public static class Lista
{
    public static void Run(string[] args)
    {
        int syote;

        // 1. Создаем список целых чисел с именем numerot
        List<int> numerot = new List<int>();

        // 2. Запускаем бесконечный цикл для чтения ввода пользователя
        while (true)
        {
            // Выводим приглашение к вводу строго как в примере (без пробела после двоеточия)
            Console.Write("Syötä numero:");
            
            // Считываем и преобразуем ввод в число
            syote = int.Parse(Console.ReadLine());

            // 3. Если число отрицательное, прерываем цикл
            if (syote < 0)
            {
                break;
            }

            // Если число положительное или ноль, добавляем его в список
            numerot.Add(syote);
        }



        Console.Write("Syöttämäsi numerot: ");
        foreach (int numero in numerot)
        {
            Console.Write(numero + " ");
        }
    }
}