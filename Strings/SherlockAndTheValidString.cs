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

    // Complete the isValid function below.
    static string isValid(string s)
    {
        var myChars = s.ToCharArray()
            .Distinct()
            .GroupBy(x => x, x => s.Count(y => y.Equals(x)))
            .Select(x => x.FirstOrDefault())
            .ToList();

        var distintos = myChars.Distinct().Count();
        if (distintos > 2) return "NO";

        var unicos = myChars.Count(x => x == 1);
        if (unicos > 1) return "NO";
        if (unicos == 0 && Math.Abs(myChars[0] - myChars[1]) > 1) return "NO";

        return "YES";
    }
}
