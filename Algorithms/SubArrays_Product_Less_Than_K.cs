// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/subarray-product-less-than-k/submissions/880996451/?envType=study-plan&id=algorithm-ii
/// solution: sliding window: https://leetcode.com/problems/subarray-product-less-than-k/solutions/127670/subarray-product-less-than-k/?envType=study-plan&id=algorithm-ii
/// PDF was added for the solution
/// 
/// Time Complexity: O(N)
/// Space Complexity: O(1)
/// </summary>
public class SubArrays_Product_Less_Than_K
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return 0;

        int result = 0;

        int totalProduct = 1;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            totalProduct = totalProduct * nums[right];

            while (totalProduct >= k && left < right)
            {
                totalProduct = totalProduct / nums[left];
                left++;
            }

            if (totalProduct < k)
                result += right - left + 1;
        }

        return result;
    }
}