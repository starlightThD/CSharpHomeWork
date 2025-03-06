using System;
using System.Reflection.Metadata.Ecma335;

namespace assignment
{
    class Solution
    {
        private Solution() { }
        public static bool IsToeplitz(ref List<List<int>> matrix) {
            bool flag = true;
            for(int i = 0; i < Math.Min(matrix.Count, matrix[0].Count) -1 ; i++)
            {
                if (matrix[i][i] != matrix[i + 1][ i + 1])
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
    class Assigment
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Please input a matrix divided by space and enter :\n");
            List<List<int>> matrix = new List<List<int>>();
            string line;
            while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> row = new List<int>();

                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int num))
                    {
                        row.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("ERROR:Input is not a number, program will exit.");
                        return;
                    }
                }

                matrix.Add(row);
            }
            if (matrix.Count == 0)
            {
                Console.WriteLine("ERROR:Nothing is input.");
                return;
            }

            int columns = matrix[0].Count;
            foreach (List<int> row in matrix)
            {
                if (row.Count != columns)
                {
                    Console.WriteLine("ERROR:Input is not a Matrix.");
                    return;
                }
            }
            if (Solution.IsToeplitz(ref matrix))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
                Console.WriteLine("Over,input any key to exit");
            Console.ReadKey();
        }
    }
}