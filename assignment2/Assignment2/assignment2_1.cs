using System;

namespace assignment
{
    class Solution
    {
        private Solution() { }
        public static void AllPrime(long num)
        {
            for (long i = 2; i*i <= num; i+=2)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                    AllPrime(num / i);
                    break;
                }
                if (i == 2)
                    i--;
                if ((i + 1) * (i + 1) > num)
                    Console.Write(num + " ");
            }
        }

    }
    class Assigment
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Please input a number: \n");
            string input = Console.ReadLine() ?? string.Empty;
            long num = long.Parse(input);
            Solution.AllPrime(num);
            Console.WriteLine("\nOver,input any key to exit");
            Console.ReadKey();
        }
    }
}