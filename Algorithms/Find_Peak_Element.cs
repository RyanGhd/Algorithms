// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/find-peak-element/submissions/877250105/?envType=study-plan&id=algorithm-ii
/// </summary>
public class Find_Peak_Element
{
    public int FindPeakElement(int[] nums)
    {
        if (nums == null || nums.Length == 0) return -1;
        else if (nums.Length == 1) return 0;
        else if (nums[0] > nums[1]) return 0;
        else if (nums[nums.Length - 1] > nums[nums.Length - 2]) return nums.Length - 1;

        for (int i = 1; i <= nums.Length - 2; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1]) return i;
        }

        return -1;
    }
}