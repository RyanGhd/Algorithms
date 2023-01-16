using System.Security.Cryptography.X509Certificates;
using System.Text;
// ReSharper disable All

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/backspace-string-compare/?envType=study-plan&id=algorithm-ii
/// solution: https://leetcode.com/problems/backspace-string-compare/solutions/136876/backspace-string-compare/?envType=study-plan&id=algorithm-ii
///           There's a second solution with space complexity O(1) which iterates through the array backwards (rather than using stack) - refer to the PDF
/// Time Complexity: O(M+N)O(M + N)O(M+N), where M,NM, NM,N are the lengths of S and T respectively.
/// Space Complexity: O(M+N)O(M + N)O(M+N).
/// </summary>
public class Strings_Backspace_String_Compare
{
    public bool BackspaceCompare(string s, string t)
    {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            return true;
        else if (string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(t))
            return false;
        else if (!string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            return false;

        var stackS = Clean(s);
        var stackT = Clean(t);

        if (stackS.Count != stackT.Count)
            return false;

        while (stackS.Count > 0)
        {
            char sChar = stackS.Pop();
            var tChar = stackT.Pop();

            if (sChar != tChar)
                return false;
        }

        return true;
    }

    private Stack<char> Clean(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '#')
                stack.Push(s[i]);
            else
            {
                char c;
                stack.TryPop(out c);
            }
        }

        return stack;
    }
}