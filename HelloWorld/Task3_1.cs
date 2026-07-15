// using System;

// class Program
// {
//     static void Main(string[] args)
    using System;

public static class TypesVariables
{
    public static void Run(string[] args)
    {
        // Объявляем переменные нужных типов и даем им значения
        short var1 = 10;
        byte var2 = 5;
        float var3 = 3.14f; // 'f' обязателен для float
        char var4 = 'A';
        bool var5 = true; // в C# пишется bool, а не boolean
        ulong var6 = 1000UL;
        decimal var7 = 10.5m; // 'm' обязателен для decimal

        // Выводим типы данных, используя GetType()
        Console.WriteLine("Var1 on tyyppiä " + var1.GetType());
        Console.WriteLine("Var2 on tyyppiä " + var2.GetType());
        Console.WriteLine("Var3 on tyyppiä " + var3.GetType());
        Console.WriteLine("Var4 on tyyppiä " + var4.GetType());
        Console.WriteLine("Var5 on tyyppiä " + var5.GetType());
        Console.WriteLine("Var6 on tyyppiä " + var6.GetType());
        Console.WriteLine("Var7 on tyyppiä " + var7.GetType());
    }
}
