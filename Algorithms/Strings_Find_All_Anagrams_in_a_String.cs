// ReSharper disable All

using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/find-all-anagrams-in-a-string/submissions/880915315/?envType=study-plan&id=algorithm-ii
/// solution: sliding window: https://leetcode.com/problems/find-all-anagrams-in-a-string/solutions/498476/find-all-anagrams-in-a-string/?envType=study-plan&id=algorithm-ii
/// PDF attched for the solution
///
/// Time complexity: O(Ns)
/// Space complexity: O(K)
/// </summary>
public class Strings_Find_All_Anagrams_in_a_String
{
    public IList<int> FindAnagrams(string s, string p)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || s.Length<p.Length) return new List<int>();

        var pDic = new Dictionary<char, Value>();
        foreach (var c in p.ToCharArray())
        {
            if (pDic.ContainsKey(c))
                pDic[c].Expected++;
            else
                pDic.Add(c, new Value { Expected = 1, Actual = 0 });
        }

        var result = new List<int>();

        for (int i = 0; i < p.Length; i++) //check the first slide
        {
            if (pDic.ContainsKey(s[i]))
                pDic[s[i]].Actual++;
        }

        if (pDic.All(x=>x.Value.Expected==x.Value.Actual))
            result.Add(0);

        for (int i = 0; i < s.Length - p.Length; i++)
        {
            if (pDic.ContainsKey(s[i]))
                pDic[s[i]].Actual--;

            if (pDic.ContainsKey(s[i + p.Length]))
                pDic[s[i + p.Length]].Actual++;

            if (pDic.All(x => x.Value.Expected == x.Value.Actual))
                result.Add(i + 1);
        }

        return result;
    }

    public class Value
    {
        public int Expected { get; set; }
        public int Actual { get; set; }


    }
}