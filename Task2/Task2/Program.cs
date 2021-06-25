using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[7] { 5, 2, 5, 1, 10, 4, 8 };
            Solution obj = new Solution();
            int num = obj.MaxPrybutok(prices);
            Console.WriteLine(num);
        }
        public class Solution
        {
            public int MaxPrybutok(int[] prices)
            {
                int tempMax = prices[0],
                    tempMin = prices[0],
                    day=0;

                for (int i = 0; i < prices.Length; i++)
                {
                    if(prices[i] >= tempMax)
                    {
                        tempMax = prices[i];
                        day = i;
                    }
                    if(prices[i] <= tempMin)
                    {
                        tempMin = prices[i];
                        tempMax = prices[i];
                    }
                }
                return ++day;
            }
        }

    }
}
