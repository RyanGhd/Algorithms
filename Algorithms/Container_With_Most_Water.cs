// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/container-with-most-water/submissions/879750493/?envType=study-plan&id=algorithm-ii
/// solution: https://leetcode.com/problems/container-with-most-water/solutions/127443/container-with-most-water/
/// Time complexity: O(n)O(n)O(n). Single pass.
/// Space complexity: O(1)O(1)O(1). Constant space is used.
/// </summary>
public class Container_With_Most_Water
{
    public int MaxArea(int[] height)
    {
        if (height == null || height.Length == 0) return 0;

        int max = 0,left = 0,right = height.Length-1;

        while (left < right)
        {
            var area = CalcArea(left, height[left], right, height[right]);
            
            if (area > max) max = area;

            if (height[left] < height[right]) left++;
            else right--;
        }

        return max;
    }

    private int CalcArea(int x1,int y1,int x2, int y2)
    {
        var x = x2 - x1;
        var y = Math.Min(y1, y2);

        return x * y;
    }
}