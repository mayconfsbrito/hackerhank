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

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2)
    {
        int[,] matrix = new int[s1.Length + 1, s2.Length + 1];
        for (int i = 1; i <= s1.Length; i++)
        {
            for (int j = 1; j <= s2.Length; j++)
            {
                if (s1[i - 1] == s2[j - 1]) matrix[i, j] = matrix[i - 1, j - 1] + 1;
                else matrix[i, j] = Math.Max(matrix[i, j - 1], matrix[i - 1, j]);
            }
        }
        return matrix[s1.Length, s2.Length];
    }
}
