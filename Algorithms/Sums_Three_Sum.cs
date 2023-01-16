using System.Collections;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/3sum/solutions/?envType=study-plan&id=algorithm-ii
/// solution: https://leetcode.com/problems/3sum/solutions/593246/3sum/?envType=study-plan&id=algorithm-ii
/// PDF added for the solution
/// </summary>
public class Sums_Three_Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var numbers = nums.OrderBy(i => i).ToArray();

        if (numbers == null || numbers.Length <= 2) return new List<IList<int>>();

        var result = new List<IList<int>>() { };

        for (int i = 0;
             i < numbers.Length && (i == 0 || numbers[i] != numbers[i - 1]);
             i++) // (i == 0 || numbers[i] != numbers[i - 1]): removes duplicates 
        {
            TwoSum(numbers, i, result);
        }

        return result;
    }

    private void TwoSum(int[] nums, int i, IList<IList<int>> output)
    {
        var target = nums[i];

        var seen = new HashSet<int>();

        for (int j = i + 1; j < nums.Length; j++)
        {
            var remaining = ((-1) * target) - nums[j];

            if (seen.Contains(remaining))
            {
                output.Add(new List<int> { target, remaining, nums[j] });

                // to avoid duplicates in second iteration
                // this should happen only if we add the item to the list
                // otherwise it fails for nums:[0,0,0]
                while (j < nums.Length - 1 && nums[j] == nums[j + 1])
                {
                    j++;
                }
            }

            if (!seen.Contains(nums[j]))
                seen.Add(nums[j]);
        }
    }

    public IList<IList<int>> ThreeSum_NoSort(int[] nums)
    {
        if (nums == null || nums.Length <= 2) return new List<IList<int>>();

        var result = new Dictionary<string, IList<int>>();

        var dups = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dups.Add(nums[i])) // to avoid processing duplicates
            {
                TwoSum_NoSort(nums, i, result);
            }
        }

        return result.Values.ToList();
    }

    private void TwoSum_NoSort(int[] nums, int i, Dictionary<string, IList<int>> output)
    {
        var target = nums[i];

        var seen = new HashSet<int>();

        for (int j = i + 1; j < nums.Length; j++)
        {
            var remaining = ((-1) * target) - nums[j];

            if (seen.Contains(remaining))
            {
                var keys = new int[] { target, remaining, nums[j] };

                Array.Sort(keys);

                var key = $"{keys[0]},{keys[1]},{keys[2]}";

                if (!output.ContainsKey(key))
                    output.Add(key, new List<int> { keys[0], keys[1], keys[2] });
            }

            if (!seen.Contains(nums[j]))
                seen.Add(nums[j]);
        }
    }
}