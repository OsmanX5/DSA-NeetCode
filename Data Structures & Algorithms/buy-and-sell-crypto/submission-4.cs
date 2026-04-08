public class Solution {
    public int MaxProfit(int[] prices) {
        int max =0;
        int n = prices.Length;
        int holded = prices[0];
        prices.Aggregate(
            prices[0],
            (acc,cur)=>{    
                max = Math.Max(cur-acc,max);
                return Math.Min(acc,cur);
            }
        );
        return max;
    }
}
