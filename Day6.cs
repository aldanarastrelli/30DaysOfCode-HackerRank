using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int T = int.Parse(Console.In.ReadLine());
        for (int numWords = 0; numWords < T; numWords++) {
            string word = Console.In.ReadLine();
            int length = word.Length;

            string odds = "";
            string even = "";

            for (int i = 0; i < length ; i++)
            {
                if (i%2 == 0)   even += word[i];
                else odds += word[i];
            }

            Console.Out.WriteLine($"{even} {odds}");
        }

    }
}

