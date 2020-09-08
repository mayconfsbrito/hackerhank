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

class Solution
{

    // Complete the substrCount function below.
    static long substrCount(int n, string s)
    {

        int cont = n;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 2; j <= s.Length - i; j++)
            {
                string sub = s.Substring(i, j);
                if (sub.Count(x => x != sub[0]) > 1) break;
                double medium = (double)sub.Length / 2;

                string subOne = sub.Substring(0, (int)Math.Floor(medium));
                string subTwo = sub.Substring((int)Math.Ceiling(medium));

                if (subOne.Equals(subTwo))
                    cont++;
            }
        }

        return cont;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        long result = substrCount(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
