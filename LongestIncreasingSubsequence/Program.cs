using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    internal class Program
    {
        public int LengthOfLIS(int[] seaquence)
        {
            if (seaquence == null || seaquence.Length == 0) return 0;
            int[] dp = new int[seaquence.Length];

            for (int i = 0; i < seaquence.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (seaquence[i] > seaquence[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
            return dp.Max();
        }

        private static void Main(string[] args)
        {
            Program program = new Program();
            int[] array = new[] { 1, 10, 2, 4, 6, 5, 13, 3, 11, 7, 15 };
            int result = program.LengthOfLIS(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}