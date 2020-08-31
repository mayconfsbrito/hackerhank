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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {

        int countValleys = 0;
        int position = 0;
        foreach (char step in s.ToCharArray())
        {
            if (step == 'U') position++;
            else position--;

            if (position == -1 && step == 'D') countValleys++;
        }
        return countValleys;

    }
}
