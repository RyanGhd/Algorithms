using System.Text.RegularExpressions;

namespace Algorithms;

/// <summary>
/// explanation: https://leetcode.com/problems/longest-common-prefix/solutions/127449/official-solution/
/// </summary>
public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var word = strs[0];


        var prefix = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            var letter = word[i];
            var pattern = $"^{prefix}{letter}.*";
            var matchAll = true;

            for (int j = 1; j < strs.Length; j++)
            {
                if (!Regex.IsMatch(strs[j], pattern, RegexOptions.IgnoreCase))
                {
                    matchAll = false;
                    break;
                }
            }

            if (matchAll)
                prefix += letter;
            else
                return prefix;
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