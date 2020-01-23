using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.In.ReadLine());

        IDictionary<string,double> phoneBook = new Dictionary<string,double>();

        for (int i = 0; i < n; i++)
        {
            string[] keyValuePair = Console.In.ReadLine().Split(' ');
            string key = keyValuePair[0];
            int value = Convert.ToInt32(keyValuePair[1]);

            phoneBook.Add(new KeyValuePair<string,double>(key,value));
        }

        string query = Console.In.ReadLine();

        while (query != null)
        {
            if (phoneBook.TryGetValue(query, out double value))    Console.Out.WriteLine($"{query}={value}");
            else    Console.Out.WriteLine("Not found");

            query = Console.In.ReadLine();
        }
    }
}
