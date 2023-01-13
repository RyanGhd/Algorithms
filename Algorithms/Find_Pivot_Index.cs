// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/find-pivot-index/?envType=study-plan&id=level-1
/// </summary>
public class Find_Pivot_Index
{
    public int PivotIndex(int[] nums)
    {
        if (nums == null || nums.Length == 0) return -1;

        var total = nums.Sum();

        var sumLeft = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (sumLeft == total - nums[i])
                return i;

            sumLeft += nums[i];
            total -= nums[i];
        }

        return -1;
    }
}