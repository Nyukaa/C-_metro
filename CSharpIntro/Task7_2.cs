using System;
using System.Collections.Generic;

// class Program
// {
//     static void Main()
public static class ListanMuokkaaminen
{
    public static void Run(string[] args)
    {
        List<string> names = new List<string> {"Torvalds", "Musk", "Gates", "Buffet", "Dorsey"};


        // Replace "Torvalds" (index 0) with "Jobs"
        names[0] = "Jobs";

        // Replace "Gates" (index 2) with "McAfee"
        names[2] = "McAfee";

        // Replace "Dorsey" (index 4) with "Wozniak"
        names[4] = "Wozniak";



        foreach (string nimi in names)
        {
            Console.WriteLine(nimi);
        }

    }
}