using System;
using System.Collections.Generic;
using System.IO;
class Solution8
{
    static void Main(String[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string s = Console.ReadLine();
            phoneBook.Add(s.Split(' ')[0], s.Split(' ')[1]);
        }


        while (true)
        {
            string temp = Console.ReadLine();
            if (temp != null)
            {
                if (phoneBook.ContainsKey(temp))
                {
                    Console.WriteLine(temp + "=" + phoneBook[temp]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            else
            {
                break;
            }
        }
    }
}
