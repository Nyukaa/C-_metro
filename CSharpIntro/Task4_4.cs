using System;

// class Program
// {
//     static void Main(string[] args)
public static class Operaattorit2
{
    public static void Run(string[] args)
    {
        // Создаем переменные (значения можно подобрать любые базовые)
           {
       int x = 5;
int y = 3;
int z = 10;
string s = "C";


        if (((x >= y) && (y < z)) || ((x > y) && (s == "A")) )
        {
            if (s == "C")
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Almost there!");
            }
        }
        else
        {
            Console.WriteLine("Not quite, try once more!");
        }
    }
    }  
}


