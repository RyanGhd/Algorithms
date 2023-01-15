using System.Reflection.Metadata;

namespace Algorithms;

/// <summary>
/// https://leetcode.com/problems/maximum-subarray/?envType=study-plan&id=data-structure-i
/// </summary>
public class Maximum_Subarray
{
    public int MaxSubArray(int[] nums)
    {
        // Initialize our variables using the first element.
        int currentSubarray = nums[0];
        int maxSubarray = nums[0];

        // Start with the 2nd element since we already used the first one.
        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];
            // If current_subarray is negative, throw it away. Otherwise, keep adding to it.
            currentSubarray = Math.Max(num, currentSubarray + num);
            maxSubarray = Math.Max(maxSubarray, currentSubarray);
        }

        return maxSubarray;
    }

}

