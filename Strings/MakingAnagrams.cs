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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b)
    {

        char[] finalString = String.Concat(a, b).Distinct().ToArray();
        int count = 0;
        for (int i = 0; i < finalString.Length; i++)
        {
            char myChar = finalString[i];
            int occurrencesInA = a.Split(myChar).Count();
            int occurrencesInB = b.Split(myChar).Count();
            count += Math.Abs(occurrencesInA - occurrencesInB);
        }
        return count;

    }
}

