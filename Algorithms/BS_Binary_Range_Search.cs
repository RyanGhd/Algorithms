// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question:
/// solution: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/solutions/1136731/find-first-and-last-position-of-element-in-sorted-array/?envType=study-plan&id=algorithm-ii
/// 
/// </summary>
public class BS_Binary_Range_Search
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
            return new int[2] { -1, -1 };

        var lower = BinarySearch(nums, target, 0, true);
        if (lower < 0)
            return new int[2] { -1, -1 };

        var upper = BinarySearch(nums, target, lower, false);

        return new int[2] { lower, upper };
    }

    private int BinarySearch(int[] nums, int target, int lowerBound, bool isFindingLowerBound)
    {
        int low = lowerBound, high = nums.Length - 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            if (nums[mid] == target)
            {
                if (isFindingLowerBound) // search lower bound
                {
                    if (mid == low || nums[mid - 1] != target)
                        return mid;

                    high = mid - 1;
                }
                else // search upper bound
                {
                    if (mid == high || nums[mid + 1] != target)
                        return mid;

                    low = mid + 1;
                }
            }
            else if (nums[mid] < target) low = mid + 1;
            else high = mid - 1;
        }

        return -1;
    }
}