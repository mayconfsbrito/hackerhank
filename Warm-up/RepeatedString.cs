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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long numberAsInString = s.Split('a').Length - 1;
        long lengthDivision = (long)System.Math.Floor((decimal)(n / s.Length));
        long totalOfAs = (numberAsInString * lengthDivision);

        if (n % s.Length != 0)
        {
            long lengthRepeatedSubstring = lengthDivision * s.Length;
            long numberOfCharsToCount = n - lengthRepeatedSubstring;
            long numberOfRestAs = s.Substring(0, (int)numberOfCharsToCount).Split('a').Length - 1;
            totalOfAs = (long)(numberAsInString * lengthDivision) + numberOfRestAs;

        }
        return totalOfAs;
    }
}
