// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/submissions/877280663/?envType=study-plan&id=algorithm-ii
/// </summary>
public class BS_Find_Minimum_in_Rotated_Sorted_Array
{
    public int FindMin(int[] nums)
    {
        nums.Min();
        if (nums == null || nums.Length == 0) return -1;
        else if (nums[0] < nums[nums.Length - 1]) return nums[0];
        else if (nums.Length == 1) return nums[0];

        var pivot = BinarySearchPivot(nums);

        return pivot > -1 ? nums[pivot] : -1;
    }

    private int BinarySearchPivot(int[] nums)
    {
        int low = 0, high = nums.Length - 1;

        if (nums[0] < nums[nums.Length - 1]) return 0;

        while (low <= high)
        {
            var mid = (low + high) / 2;

            if (nums[mid] > nums[mid + 1])
                return mid + 1;
            else if (nums[mid] < nums[mid - 1])
                return mid;
            else if (nums[mid] > nums[low])
                low = mid + 1;
            else
                high = mid - 1;

        }

        return -1;
    }

    public int FindMinWithoutBinary(int[] nums)
    {
        nums.Min();
        if (nums == null || nums.Length == 0) return -1;
        else if (nums[0] < nums[nums.Length - 1]) return nums[0];
        else if (nums.Length == 1) return nums[0];

        return nums.Min(); // the performance is the same as above.
    }
}