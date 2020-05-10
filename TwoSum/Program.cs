using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// Example:
        /// Given nums = [2, 7, 11, 15], target = 9,
        /// Because nums[0] + nums[1] = 2 + 7 = 9,
        /// return [0, 1].
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15, 12 };
            int target = 27;
            var result = TwoSum(nums, target);
            Console.Read();
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            var len = nums.Length;
            int index = 0;
            bool isMatched = false;
            return FindArray(nums, index, target, out isMatched, len);
        }

        private static int[] FindArray(int[] nums, int index, int target, out bool isMatched, int len)
        {
            isMatched = false;
            for (int i = index + 1; i < len; i++)
            {
                if (nums[index] + nums[i] == target)
                {
                    isMatched = true;
                    int[] res = { nums[index], nums[i] };
                    return res;
                }
            }

            index++;
            if (index < len - 1)
            {
                return FindArray(nums, index, target, out isMatched, len);
            }
            else
            {
                int[] res = { 0, 0 };
                return res;
            }
        }
    }
}
