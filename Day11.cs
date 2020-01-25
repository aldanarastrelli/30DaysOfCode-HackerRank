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

    static int MaxHourglassValue(int[][] arr,int numRows, int numberColumns)
    {
        int maxHourglass = -9 * 7;
        int actualHourglass;
        for (int i = 0; i < (numRows -2); i++)
        {
            for (int j = 0; j < (numberColumns -2); j++){
                actualHourglass = calculateHourglassValue(arr,i,j);
                if (maxHourglass < actualHourglass) maxHourglass = actualHourglass;
            }
        }
        return maxHourglass;
    }

    static int calculateHourglassValue(int[][] arr, int i, int j)
    {
        int count = 0;
        for (int k = 0; k < 3; k++)
        {
            if (k == 1) count += arr[i+k][j+k];
            else    for (int h = 0; h < 3; h++) count += arr[i+k][j+h];
        }
        return count;
    }

    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        Console.Out.WriteLine(MaxHourglassValue(arr,6,6));
    }
}
