// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/solutions/?envType=study-plan&id=data-structure-i
/// solution: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/solutions/127440/best-time-to-buy-and-sell-stock/?envType=study-plan&id=data-structure-i
///
/// The solution is brute force
/// 
/// </summary>
public class Best_Time_to_Buy_and_Sell_Stock
{
    public int MaxProfit(int[] prices)
    {
        int maxprofit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                if (profit > maxprofit)
                    maxprofit = profit;
            }
        }
        return maxprofit;
    }

}