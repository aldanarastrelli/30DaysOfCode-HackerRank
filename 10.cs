using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static string convertToBinary(int n)
    {
        return Convert.ToString(n,2);
    }

    static int maxConsecutive(char lookedFor, string str)
    {
        int count = 0;
        int max = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == lookedFor)    count++;
            else
            {
                if (max < count)    max = count;
                count = 0;
            }
        }

        return max > count ?  max : count ;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string binaryNumber = convertToBinary(n);
        Console.Out.WriteLine(maxConsecutive('1',binaryNumber));
    }
}
