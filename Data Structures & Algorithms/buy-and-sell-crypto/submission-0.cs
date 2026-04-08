public class Solution {
    public int MaxProfit(int[] prices) {
        int max =0;
        int n = prices.Length;
        int holded = prices[0];
        for(int i=0;i<n;i++){
            int x =prices[i];
            if(x>holded){
                int profit = x-holded;
                max = Math.Max(profit,max);
            }
            else{
                holded = x;
            }
        }
        return max;
    }
}
