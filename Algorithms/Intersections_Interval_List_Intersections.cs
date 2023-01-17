// ReSharper disable All

using System.Threading.Tasks.Dataflow;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/interval-list-intersections/?envType=study-plan&id=algorithm-ii
/// solution: https://leetcode.com/problems/interval-list-intersections/solutions/231071/interval-list-intersections/?envType=study-plan&id=algorithm-ii
/// Time Complexity: O(M+N)O(M + N)O(M+N), where M,NM, NM,N are the lengths of A and B respectively.
/// Space Complexity: O(M+N)O(M + N)O(M+N), the maximum size of the answer.
/// </summary>
public class Intersections_Interval_List_Intersections
{
    public int[][] IntervalIntersection(int[][] a, int[][] b)
    {
        if (a == null || b == null || a.Length == 0 || b.Length == 0) return new int[][] { };

        int i = 0, j = 0;

        var output = new List<int[]>();

        while (i < a.Length && j < b.Length)
        {
            var start = Math.Max(a[i][0], b[j][0]);
            var end = Math.Min(a[i][1], b[j][1]);

            if (start <= end)
                output.Add(new int[] { start, end });

            if (a[i][1] < b[j][1])
                i++;
            else
                j++;
        }

        return output.ToArray();
    }
}