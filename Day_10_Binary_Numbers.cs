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

class Solution10
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int max = 0;

        while (n > 0)
        {
            if (n % 2 == 1)
            {
                sum++;

                if (sum > max)
                {
                    max = sum;
                }

            }
            else
            {
                sum = 0;
            }

            n = n / 2;
        }

        Console.WriteLine(max);
    }
}
