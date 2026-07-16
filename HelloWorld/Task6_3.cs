using System;

// class Program
// {
//     static void Main(string[] args)
public static class MerkkienTulostus
{
    public static void Run(string[] args)
    {
        // Если в системе уже есть массив "merkit", этот блок объявления можно убрать
        char[] merkit = { 'O', 'p', 'i', ' ', 'C', '#', '!' };

        // Используем foreach по требованию задания
        foreach (char merkki in merkit)
        {
            Console.Write(merkki);
        }
       
    }
}
