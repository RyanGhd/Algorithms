// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/minimum-size-subarray-sum/?envType=study-plan&id=algorithm-ii
/// solution: sliding window: https://leetcode.com/problems/minimum-size-subarray-sum/solutions/127732/minimum-size-subarray-sum/
///
/// Time complexity: O(n)
/// Space complexity: O(1)
/// </summary>
public class SubArrays_Minimum_Size_Subarray_Sum
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        int total = 0;
        int min = nums.Length + 1;

        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] >= target)
                return 1;

            total += nums[right];

            if (total < target)
                continue;

            while (total >= target && left < right)
            {
                if (min > right - left + 1)
                    min = right - left + 1;

                total -= nums[left];
                left++;
            }
        }

        if (min > nums.Length)
            return 0;

        return min;
    }
}