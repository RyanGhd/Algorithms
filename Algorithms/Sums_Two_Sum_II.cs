using System.Collections;

namespace Algorithms;

/// <summary>
/// 
/// </summary>
public class Sums_Two_Sum_II
{
    public int[] TwoSum(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length <= 1) return new int[] { };
        if (numbers.Length == 2 && numbers[0] + numbers[1] == target) return AddIndex(new int[] { 0, 1 });

        int low = 0, high = numbers.Length - 1;

        while (low < high)
        {
            var sum = numbers[low] + numbers[high];

            if (sum == target)
                return AddIndex(new int[] { low, high });

            else if (sum < target)
                low++;
            else high--;
        }

        return new int[] { };
    }

    private int[] AddIndex(int[] indexes)
    {
        for (int i = 0; i < indexes.Length; i++)
        {
            indexes[i] += 1;
        }

        return indexes;
    }
}