using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution16 {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        try
        {
            Console.WriteLine(Convert.ToInt32(S));
        }
        catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}
