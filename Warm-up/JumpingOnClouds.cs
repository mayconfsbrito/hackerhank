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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {

        int steps = 0;
        for (int i = 1; i < c.Length; i++)
        {
            if (i < c.Length - 1 && c[i + 1] == 0) i += 1;
            steps++;
            System.Console.WriteLine($"{i}, {steps}");
        }

        return steps;
    }
}
