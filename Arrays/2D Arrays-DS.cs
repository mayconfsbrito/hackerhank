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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {

        int maxSum = Int32.MinValue;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            for (int j = 1; j < arr[0].Length - 1; j++)
            {
                int sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1];
                sum += arr[i][j] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                if (sum > maxSum) maxSum = sum;
            }
        }
        return maxSum;
    }
}
