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


    // Complete the rotLeft function below.
    static int[] rotLeft(int[] arr, int d) {

        int[] temp = new int[d];
        for(int i=0; i<d ; i++)
        {
           temp[i] = arr[i];
        }
        for(int i=0; i<arr.Length - d ;i++)
        {
            arr[i] = arr[d+i];
        }
        for(int i=0 ; i<d ; i++)
        {
            //Console.WriteLine(i);
            arr[arr.Length-d+i] = temp[i];
            Console.WriteLine(arr[arr.Length-d+i]);
           // Console.WriteLine(temp[i]);
        }
        return arr;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
