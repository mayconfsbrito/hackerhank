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

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        var dResult = new SortedDictionary<int, long>();

        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0] - 1;
            int end = queries[i][1];
            int sum = queries[i][2];
            addToDictionary(ref dResult, start, sum);
            addToDictionary(ref dResult, end, -sum);
        }

        long max = 0;
        long lastValue = 0;
        foreach (var item in dResult)
        {
            lastValue += item.Value;
            if (lastValue > max) max = lastValue;
        }

        return max;
    }

    static void addToDictionary(ref SortedDictionary<int, long> myDict, int key, long value)
    {
        if (myDict.ContainsKey(key))
            myDict[key] += value;
        else
            myDict.Add(key, value);
    }

}
