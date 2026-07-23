using System;
using System.Collections.Generic;

// class Program
// {
//     static void Main()
public static class ListanMuokkaaminen
{
    public static void Run(string[] args)
    {
        List<string> nimet = new List<string> {"Torvalds", "Musk", "Gates", "Buffet", "Dorsey"};


        // Replace "Torvalds" (index 0) with "Jobs"
        nimet[0] = "Jobs";

        // Replace "Gates" (index 2) with "McAfee"
        nimet[2] = "McAfee";

        // Replace "Dorsey" (index 4) with "Wozniak"
        nimet[4] = "Wozniak";



        foreach (string nimi in nimet)
        {
            Console.WriteLine(nimi);
        }

    }
}