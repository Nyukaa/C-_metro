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
        int input;

        // 1. Создаем список целых чисел с именем numerot
        List<int> numbers = new List<int>();

        // 2. Запускаем бесконечный цикл для чтения ввода пользователя
        while (true)
        {
            // Выводим приглашение к вводу строго как в примере (без пробела после двоеточия)
            Console.Write("Input a number:");
            
            // Считываем и преобразуем ввод в число
            input = int.Parse(Console.ReadLine());

            // 3. Если число отрицательное, прерываем цикл
            if (input < 0)
            {
                break;
            }

            // Если число положительное или ноль, добавляем его в список
            numbers.Add(input);
        }



        Console.Write("Your input: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}