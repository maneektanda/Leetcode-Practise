namespace _121._Best_Time_to;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    int MaxProfit(int[] prices) {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length - 1; i++){
            int buyPrice = prices[i];
            for (int j = i + 1; j < prices.Length; j++){
                int sellPrice = prices[j];
                int profit = sellPrice - buyPrice;
                if (profit > maxProfit){
                    maxProfit = profit;
                }
            }
        }
        return maxProfit;
    }
}
