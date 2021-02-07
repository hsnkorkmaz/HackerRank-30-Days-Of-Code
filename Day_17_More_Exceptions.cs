using System;

class Calculator
{
    public int power(int n, int p)
    {
        int sum = 1;
        if (n < 0 || p < 0)
        {
            throw new ArithmeticException("n and p should be non-negative");
        }
        else
        {
            for (int i = 0; i < p; i++)
            {
                sum *= n;
            }

            return sum;
        }
    }
}

class Solution17{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
    }
}