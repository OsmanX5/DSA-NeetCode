public class Solution {
    public int Rob(int[] nums) {
        Dictionary<int,int> dp = new ();
        int n = nums.Length;
        int DFS(int i){
            if(i>=n) return 0;
            if(dp.ContainsKey(i)) return dp[i];
            int x = nums[i];
            int rob= x + DFS(i+2);
            int notRob = DFS(i+1);
            int res = Math.Max(rob,notRob);
            dp[i]= res;
            return res;
        }
        return DFS(0);
    }
}
