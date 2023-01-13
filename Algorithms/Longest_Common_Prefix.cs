using System.Text.RegularExpressions;
// ReSharper disable All

namespace Algorithms;

/// <summary>
/// explanation: https://leetcode.com/problems/longest-common-prefix/solutions/127449/official-solution/
/// </summary>
public class Longest_Common_Prefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        var word = GetSmallestString(strs);

        var prefix = string.Empty;

        for (int i = 0; i < strs.Length; i++)
        {
            prefix = string.Empty;

            for (int j = 0; j < word.Length; j++)
            {
                if (strs[i].Length - 1 >= j &&
                    strs[i][j] == word[j])
                {
                    prefix += word[j];
                }
                else
                {
                    word = prefix;
                    break;
                }
            }

            if (string.IsNullOrEmpty(prefix)) return string.Empty;
        }

        return prefix;
    }

    public string GetSmallestString(string[] strs)
    {

        var result = strs[0];
        var minLength = result.Length;

        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < minLength)
            {
                result = strs[i];
                minLength = result.Length;
            }
        }

        return result;
    }
}