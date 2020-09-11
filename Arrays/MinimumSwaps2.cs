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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {

        int[] temp = new int[arr.Length];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            var value = arr[i] - 1;
            temp[value] = i;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != i + 1)
            {
                int tmp = arr[i];
                arr[i] = i + 1;
                arr[temp[i]] = tmp;

                int tmpPos = temp[i];
                temp[i] = temp[tmp - 1];
                temp[tmp - 1] = tmpPos;
                count++;
            }
        }
        return count;
    }
}
