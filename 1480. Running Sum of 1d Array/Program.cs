using System;
using System.Linq;

namespace _1480._Running_Sum_of_1d_Array
{
    /*
     * https://leetcode.com/problems/running-sum-of-1d-array/
     * Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
     * Return the running sum of nums.
     */
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            var outputs = new int[nums.Length];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                outputs[i] = sum;
            }

            return outputs;
        }
    }
}
