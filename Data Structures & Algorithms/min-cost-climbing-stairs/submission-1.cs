public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n =cost.Length;
        int[] dp = new int[n];
        Array.Fill(dp,int.MaxValue);
        int Jump(int i){
            if(i>= n)return 0;
            if(dp[i]!=int.MaxValue)return dp[i];
            if(i == n-1){
                dp[i] = cost[n-1];
            }
            else{
                int j1 = Jump(i+1);
                int j2 = Jump(i+2);
                dp[i]= cost[i] + Math.Min(j1,j2);
            }
            return dp[i];

        }
        return Math.Min(Jump(0),Jump(1));
    }
}
