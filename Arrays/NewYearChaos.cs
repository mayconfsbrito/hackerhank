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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int count = 0;
        for (int i = q.Length - 1; i >= 0; i--)
        {
            if (q[i] > i + 3)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (int j = Math.Max(0, q[i] - 2); j <= i; j++)
            {
                if (q[j] > q[i])
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
