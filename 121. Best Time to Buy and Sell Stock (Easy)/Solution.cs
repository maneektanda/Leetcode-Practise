namespace _121._Best_Time_to;

class Solution
{
    public static int MaxProfit(int[] prices)
    {
        int max_profit = 0;

        int left = 0;
        int right = 1;

        while (right < prices.Length)
        {
            int buy_price = prices[left];
            int sell_price = prices[right];
            if (sell_price < buy_price)
            {
                left = right;
                right++;
            }
            else
            {
                max_profit = Math.Max(max_profit, sell_price - buy_price);
                right++;
            }
        }
        return max_profit;
    }
}
