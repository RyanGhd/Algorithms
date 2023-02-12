// ReSharper disable All
namespace Algorithms;

/// <summary>
/// 3. google
/// question: https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// solution: https://leetcode.com/problems/longest-substring-without-repeating-characters/solutions/127839/longest-substring-without-repeating-characters/
///
/// Sliding window
/// Time complexity : O(n)
/// Space complexity : O(min(m,n))
/// </summary>
public class Longest_Substring_Without_Repeating_Characters
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        else if (s.Length == 1) return 1;

        var array = s.ToCharArray();

        var dic = new Dictionary<char, int>();

        int left = 0, right = 0, max = 0;

        for (int i = 0; i < array.Length; i++)
        {
            right = i;

            int index;
            if (dic.TryGetValue(array[i], out index))
            {
                left = Math.Max(index+1, left);

                dic[array[i]] = i;
            }
            else
                dic.Add(array[i], i);

            if (right - left + 1 > max || right == 0)
                max = right - left + 1;
        }

        return max;
    }
}