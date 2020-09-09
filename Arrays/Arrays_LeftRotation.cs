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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        int[] newArr = new int[a.Length];
        newArr = (int[])a.Clone();

        for (int j = 0; j < a.Length; j++)
        {
            int newIndex = (j + (a.Length - d)) % a.Length;
            newArr[newIndex] = a[j];
        }

        return newArr;
    }
}
