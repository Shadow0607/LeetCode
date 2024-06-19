using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };

            Solution solution = new Solution();
            int[] result =solution.TwoSum(nums, 9);
            if (result != null)
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }
        }
    }
}
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }
            if (!numMap.ContainsKey(nums[i]))
            {
                numMap[nums[i]] = i;
            }
        }
        return null;
    }
}