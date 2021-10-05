using System;

namespace ConsoleApp9
{
    class FibonancciSeries
    {
        int[] arr = new int[] { 20, 30, 10, 5, 20, 30, 15, 10, 2 };
        int count = 0;
        

        public FibonancciSeries()
        {
            int l = arr.Length;

            for (int i=0;i<=l;i++)
            {
                for(int j=1;j<=l;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        count++;
                        Console.WriteLine(arr[i] + "repeated" + count);
                    }
                }
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FibonancciSeries fib = new FibonancciSeries();
        }
    }
}
