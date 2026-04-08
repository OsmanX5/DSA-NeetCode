public class Solution {
    public int MaxProfit(int[] prices) {
        int max =0;
        int n = prices.Length;
        int holded = prices[0];
        foreach(int x in prices){
            if(x>holded)
                max = Math.Max(x-holded,max);
            else
                holded = x;
        }
        return max;
    }
}
