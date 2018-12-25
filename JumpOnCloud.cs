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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int n , int[] c) {

        int numOfJumps = 0;
        int previous,i=0; 
        while (i+1<n){
            
            if(i+2<n && c[i+2]==0){
                numOfJumps++;
                i=i+2;
            }
            else
            {
                numOfJumps++;
                i=i+1;
            }
        }
        return numOfJumps;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(n,c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
