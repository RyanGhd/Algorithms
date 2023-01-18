// ReSharper disable All
namespace Algorithms;
/// <summary>
/// question: https://leetcode.com/problems/merge-sorted-array/submissions/880226441/?envType=study-plan&id=data-structure-i
///
/// 
/// </summary>
public class Merge_Sorted_Array
{
    /// <summary>
    /// Time complexity: O((n+m)log⁡(n+m))\mathcal{O}((n + m)\log(n + m))O((n+m)log(n+m)).
    /// Space complexity: O(n)\mathcal{O}(n)O(n), but it can vary.
    /// </summary>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        

        for (int i = 0; i < n; i++)
        {
            nums1[i + m] = nums2[i];
        }

        Array.Sort(nums1);
    }

    public void Merge_Second_Solution(int[] nums1, int m, int[] nums2, int n)
    {
        int i = 0, j = 0;

        var result = new List<int>();

        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            {
                result.Add(nums1[i]);
                i++;
            }
            else
            {
                result.Add(nums2[j]);
                j++;
            }
        }

        if (i <= m - 1)
        {
            while (i < m)
            {
                result.Add(nums1[i]);
                i++;
            }
        }

        if (j <= n - 1)
        {
            while (j < n)
            {
                result.Add(nums2[j]);
                j++;
            }
        }

        for (int idx = 0; idx < result.Count; idx++)
        {
            nums1[idx] = result[idx];
        }
    }
}