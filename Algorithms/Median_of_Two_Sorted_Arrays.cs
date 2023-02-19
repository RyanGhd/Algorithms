// ReSharper disable All

using System.Collections;

namespace Algorithms;
/// <summary>
/// not finished
/// question:
/// 
/// </summary>
public class Median_of_Two_Sorted_Arrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if ((nums1 == null || nums1.Length == 0) &&
            nums2 == null || nums2.Length == 0) return 0;

        var m1 = Convert.ToInt32(Math.Floor(decimal.Divide(nums1.Length - 1, 2)));
        var m2 = Convert.ToInt32(Math.Floor(decimal.Divide(nums2.Length - 1, 2)));

        int[] left, right;
        int ml, mr;
        if (nums1[m1] <= nums2[m2])
        {
            left = nums1;
            ml = m1;
            right = nums2;
            mr = m2;

        }
        else
        {
            left = nums2;
            ml = m2;
            right = nums1;
            mr = m1;
        }

        // result
        var resultLength = (left.Length - ml) + mr+1;

        var resultMid = Convert.ToInt32(Math.Floor(decimal.Divide(resultLength-1, 2)));

        int resultL, resultR;

        if (resultLength % 2 == 0)
        {
            resultL = resultMid;
            resultR = resultMid + 1;
        }
        else
        {
            resultL = resultMid;
            resultR = resultMid;
        }

        var result = new List<int>();


        // fill result
        int leftPointer = ml, rightPointer = mr, resultPointer = 0;


        while (resultPointer <= resultR)
        {
            if (leftPointer < left.Length && rightPointer >= 0)
            {
                if (left[leftPointer] <= right[rightPointer])
                {
                    result.Add(left[leftPointer]);
                    leftPointer++;
                }
                else if (left[leftPointer] > right[rightPointer])
                {
                    result.Add(right[rightPointer]);
                    rightPointer--;
                }
            }
            else if (leftPointer < left.Length)
            {
                result.Add(left[leftPointer]);
                leftPointer++;
            }
            else
            {
                result.Add(right[rightPointer]);
                rightPointer--;
            }


            resultPointer++;
        }

        var output = (double)decimal.Divide(result[resultL] + result[resultR], 2);

        return output;
    }
}