namespace Algorithms;

public class RomanToIntSolution
{
    public int RomanToInt(string s)
    {
        int ans = 0, num = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            num = GetValue(s[i]);
            if (4 * num < ans) ans -= num;
            else ans += num;
        }
        return ans;
    }

    private int GetValue(char s)
    {
        switch (s)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}