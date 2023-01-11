// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Linq.Expressions;

Console.WriteLine((new RomanToIntSolution()).RomanToInt("III"));

public class NumberValue
{
    public NumberValue(int value)
    {
        this.Value = value;
    }

    public NumberValue(int value, int exception1, int exception2)
    {
        Value = value;
        Exception1 = exception1;
        Exception2 = exception2;
    }
    public int Value { get; set; }
    public int Exception1 { get; }
    public int Exception2 { get; }
}

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
