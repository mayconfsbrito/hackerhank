using System.Reflection.Metadata;
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

class FraudulentActivityNotifications
{

    // Complete the activityNotifications function below.
    static int activityNotifications(int[] expenditure, int d)
    {
        int notifications = 0;
        int[] arrSpent = Enumerable.Repeat<int>(0, 201).ToArray<int>();

        for (int i = 0; i < expenditure.Length; i++)
        {
            int current = expenditure[i];

            if (i >= d)
            {
                double avg = getMedian(arrSpent, d);
                if (current >= avg) notifications++;

                int firstExpenditure = expenditure[i - d];
                arrSpent[firstExpenditure]--;
            }
            arrSpent[current]++;

        }
        return notifications;
    }
    static double getMedian(int[] arr, int d)
    {
        int count = 0;
        double lastExpend = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0) continue;
            count += arr[i];

            if (d % 2 == 0 && count >= d / 2)
            {
                if (count - arr[i] > 1)
                    lastExpend = i;
                else
                    lastExpend = (double)i + lastExpend / 2;
                break;
            }
            else if (d % 2 == 1 && count >= (d / 2 + 1))
            {
                lastExpend = i;
                break;
            }
            lastExpend = i;
        }
        return (double)lastExpend * 2;
    }

    static void Main(string[] args)
    {
        //using (var sr = new StreamReader("./data/fraudulent_test2.txt")) //expected 770
        using (var sr = new StreamReader("./data/fraudulent_test1.txt")) //expected 633
        {
            int result = 0;
            string[] nd = sr.ReadLine().Split(new char[] { ' ' });
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);
            int[] expenditure = Array.ConvertAll(nd.Skip(2).ToArray(), expenditureTemp => Convert.ToInt32(expenditureTemp));

            result = activityNotifications(expenditure, d);
            Console.WriteLine(result);

            result = activityNotifications(new int[] { 1, 2, 3, 4, 4 }, 4); // 0
            Console.WriteLine(result);
            result = activityNotifications(new int[] { 10, 20, 30, 40, 50 }, 3); // 1
            Console.WriteLine(result);
        }
    }
}
