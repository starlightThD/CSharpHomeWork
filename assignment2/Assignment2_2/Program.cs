using System;

namespace assignment
{
    class Solution
    {
        private Solution() { }
        public static void MyCalculate(ref int[] nums, out int max, out int min, out int sum)
        {
            max = nums[0]; min = nums[0]; sum = 0;
            foreach (int num in nums)
            {
                max = num > max? num : max;
                min = num<min? num : min;
                sum += num;
            }
}
    }
    class Assigment
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Please input numbers separated with space, and enter to over: \n");
            String input = Console.ReadLine() ?? string.Empty;
            string[] StringNums = input.Split(' ');
            int[] nums = new int[StringNums.Length];
            for (int i = 0;i<StringNums.Length;i++)
            {
                nums[i] = int.Parse(StringNums[i]);
            }
            int max = nums[0], min = nums[0], sum=0;
            Solution.MyCalculate(ref nums,out max,out min,out sum);
            Console.WriteLine("The maximum is " + max + "\n" + "The minimum is " + min + "\n" + "The mean is " + 1.0*  sum / StringNums.Length + "\n" + "The sum is " + sum + "\n");
            Console.WriteLine("Over,input any key to exit");
            Console.ReadKey();
        }
    }
}