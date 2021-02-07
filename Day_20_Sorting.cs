using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution20
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here

        int temp = 0;
        int totalswaps = 0;
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal

            int numberOfSwaps = 0;
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    temp = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = temp;
                    numberOfSwaps++;
                    totalswaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine("Array is sorted in " + totalswaps + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[a.Length -1]);
    }
}
