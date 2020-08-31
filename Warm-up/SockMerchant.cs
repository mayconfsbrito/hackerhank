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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        var tempArray = new int[100];
        var countPairs = 0;
        foreach (var item in ar)
        {
            tempArray[item - 1]++;
            if (tempArray[item - 1] % 2 == 0)
                countPairs++;
        }
        return countPairs;
    }
}