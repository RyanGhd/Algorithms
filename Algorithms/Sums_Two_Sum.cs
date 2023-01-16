using System.Collections;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/two-sum/description/
/// nums is not ordered and contains duplicates
/// solution: use hashTable to store values as keys
/// </summary>
public class Sums_Two_Sum
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length <= 1) return new int[] { };
        if (nums.Length == 2 && nums[0] + nums[1] == target) return new int[] { 0, 1 };

        var seen = new Hashtable();
        
        for (int i = 0; i < nums.Length; i++)
        {
            var remainingKey = target - nums[i];
            var remainingValue = seen[remainingKey];

            if (remainingValue != null)
                return new int[] { (int)remainingValue, i };

            if(!seen.Contains(nums[i]))
                seen.Add(nums[i], i);
        }

        return new int[] { };
    }
}