public class Solution {
    public int MaxProfit(int[] prices) {
        int max =0;
        int n = prices.Length;
        int holded = prices[0];
        foreach(int x in prices){
            max = Math.Max(x-holded,max);
            holded = Math.Min(holded,x);
        }
        return max;
    }
}
