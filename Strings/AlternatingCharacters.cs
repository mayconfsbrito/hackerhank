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

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {

        int countDelete = 0;
        int i = 1;

        while (i < s.Length)
        {
            if (s[i] == s[i - 1]) countDelete++;
            i++;
        }
        return countDelete;
    }
}
