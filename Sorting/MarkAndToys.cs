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
    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {

        prices = prices.Where(x => x <= k).OrderBy(x => x).ToArray();
        long sum = 0;
        int count = 0;
        foreach (var item in prices)
        {
            sum += item;
            if (sum > k) break;
            count++;
        }
        return count;
    }
}
