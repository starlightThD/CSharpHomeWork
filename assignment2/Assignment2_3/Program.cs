using System;
using System.Reflection.Metadata.Ecma335;

namespace assignment
{
    class Solution
    {
        private Solution() { }
        public static void Eratosthenes(int begin,int end)
        {
            bool[] nums = new bool[end+1];
            for(int i= begin; i <= end; i++)
            {
                nums[i] = true;
            }
            for(int i = 2; i < end + 1; i++)
            {
                int MultNum = i+i; 
                while(MultNum <= end)
                {
                    nums[MultNum] = false;
                    MultNum += i;
                }
            }
            for(int i = begin; i <= end; i++)
            {
                if (nums[i])
                {
                    Console.Write(i+" ");
                }
            }
            Console.Write("\n");
        }
    }
    class Assigment
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("This program will output primes in 2-100 using the Eratosthenes method:\n");
            Solution.Eratosthenes(2,100);
            Console.WriteLine("Over,input any key to exit");
            Console.ReadKey();
        }
    }
}