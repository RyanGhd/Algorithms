// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/intersection-of-two-arrays-ii/solutions/?envType=study-plan&id=data-structure-i
///
/// didn't solve this one. The recommended solution was not good enough. It suggested to use hashMap but didn't make much sense.
/// </summary>
//public class Intersections_of_Two_Arrays_II
//{
//    public int[] Intersect(int[] a, int[] b)
//    {
//        if (a == null || b == null || a.Length == 0 || b.Length == 0) return new int[0];

//        //Array.Sort(a);
//        //Array.Sort(b);

//        int[] target, other;

//        if (a.Length < b.Length)
//        {
//            target = a;
//            other = b;
//        }
//        else
//        {
//            target = b;
//            other = a;
//        }

//        var result = new List<int>();

//        int i = 0, j = -1;

//        for (i = 0; i < target.Length; i++)
//        {
//            var start = Array.Find(other, x => x == target[i]);

//            if (start >= 0)
//            {
//                j = start;
//                break;
//            }

//            while (i < target.Length - 1 && target[i] == target[i + 1]) // to avoid searchig for duplicates if the first one doesn't exists 
//            {
//                i++;
//            }
//        }

//        if (j == -1)
//            return new int[0];

//        while (i < target.Length && j < other.Length)
//        {
//            if (target[i] == other[j])
//            {
//                result.Add(target[i]);
//                i++;
//                j++;
//            }
//            else
//            {
//                break;
//            }

           
//        }

//        return result.ToArray();
//    }
//}