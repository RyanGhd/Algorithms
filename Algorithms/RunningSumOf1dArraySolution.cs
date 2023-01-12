namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/running-sum-of-1d-array/?envType=study-plan&id=level-1
/// 
/// </summary>
public class RunningSumOf1dArraySolution
{
    public int[] RunningSum(int[] nums)
    {
        if (nums == null) return nums;

        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}