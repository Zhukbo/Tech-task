using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 4, 1, 3, 5, 6, 4, 6 };
            Solution obj = new Solution();
            int[] arr2 = obj.SumaDvokhChysel(arr, 2);

            Console.WriteLine("[" + arr2[0] + "," + arr2[1] + "]");

        }
    }
    public class Solution
    {
        public int[] SumaDvokhChysel(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                temp = target - nums[i];

                if (dict.ContainsKey(temp))
                {
                    return new int[] { dict[temp], i };
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new Exception("Таких пари чисел не існує");
        }
    }
}
