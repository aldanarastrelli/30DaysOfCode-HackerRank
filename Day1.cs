using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int inputInt = 0;
        double inputDouble = 0.0;
        string inputString = "";
        // Read and save an integer, double, and String to your variables.
        
        bool Error = true;
        do
        {
            try
            {
                inputInt = int.Parse(Console.ReadLine());
                inputDouble = double.Parse(Console.ReadLine());
                inputString = Console.ReadLine();
            } catch {
                continue;
            }
            Error = false;
        } while (Error);

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + inputInt);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", d + inputDouble));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine($"{s}{inputString}");
    }
