// ReSharper disable All

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/search-a-2d-matrix/?envType=study-plan&id=algorithm-ii
/// solution: 
/// </summary>
public class BS_Search_2d_Matrix
{
    public bool SearchMatrix(int[][] matrix, int target) // this matrix called jagged array:https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays?source=recommendations 
    {
        if (matrix == null || (matrix.GetLength(0) == 0 && matrix.GetLength(1) == 0)) return false;

        int horizontal = -1;

        if (matrix.GetLength(0) == 1 && matrix[0].Length == 1) // has 1 row and 1 col
            return matrix[0][0] == target;
        else if (matrix.GetLength(0) == 1) // has 1 row and multiple cols
            horizontal = BinarySearchHorizontal(matrix, target, 0);
        else // has multiple rows and cols
        {
            var vertical = BinarySearchVertical(matrix, target);
            if (vertical == -1) return false;

            horizontal = BinarySearchHorizontal(matrix, target, vertical);
        }

        return horizontal > -1;
    }

    private int BinarySearchVertical(int[][] matrix, int target)
    {
        int low = 0, high = matrix.GetLength(0) - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (mid == matrix.GetLength(0) - 1) // if it reaches last row, means target> if first cell of the last row
                return mid;
            if (matrix[mid][0] <= target && target < matrix[mid + 1][0])
                return mid;
            else if (target < matrix[mid][0])
                high = mid - 1;
            else
                low = mid + 1;
        }

        return -1;
    }

    private int BinarySearchHorizontal(int[][] matrix, int target, int row)
    {
        int low = 0, high = matrix[0].Length - 1;

        if (target < matrix[row][low] || target > matrix[row][high])
            return -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (matrix[row][mid] == target)
                return mid;
            else if (matrix[row][mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}