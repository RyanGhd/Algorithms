// ReSharper disable All
namespace Algorithms;

public class Search_in_Rotated_Sorted_Array
{
    public int Search(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0) return -1;

        if (nums.Length == 1)
        {
            if (nums[0] == target) return 0;
            return -1;
        }
        else if (nums[0] == target) return 0;
        else if (nums[nums.Length - 1] == target) return nums.Length - 1;
        

        var pivot = BinaryPivotSearch(nums);

        if (nums[pivot] == target)
            return pivot;
        else if (pivot == 0) // array has ascending order
            return BinarySearch(nums, target, 0, nums.Length - 1);
        else if (nums[pivot] < target && target <= nums[nums.Length - 1])
            return BinarySearch(nums, target, pivot + 1, nums.Length - 1);
        else
            return BinarySearch(nums, target, 0, pivot - 1);

    }

    private int BinarySearch(int[] nums, int target, int lowInput, int highInput)
    {
        int low = lowInput, high = highInput;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            if (nums[mid] == target)
                return mid;
            else if (target < nums[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }

        return -1;
    }

    private int BinaryPivotSearch(int[] nums)
    {
        int low = 0, high = nums.Length - 1;

        if (nums[low] < nums[high]) return 0; // array has ascending order

        while (low <= high)
        {
            var pivot = low + (high - low) / 2;

            if (nums[pivot + 1] < nums[pivot])
                return pivot + 1;
            else if (nums[pivot] < nums[low])
                high = pivot - 1;
            else
                low = pivot + 1;
        }

        return -1;
    }
}