public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length==1) 
            return nums[0];
        var nums2 = nums.ToList();
        nums2.Add(nums[0]);
        nums2.RemoveAt(0);
        return Math.Max(RobDP(nums),RobDP(nums2.ToArray()));
    }
    int RobDP(int [] arr){
        Dictionary<int,int> dp = new();
        int n = arr.Length;
        int DFS(int i){
            if(i>=n-1) return 0;
            if(dp.ContainsKey(i)) return dp[i];
            int x = arr[i];
            int rob = x + DFS(i+2);
            int notRobed = DFS(i+1);
            int res=Math.Max(rob,notRobed); 
            dp[i] = res;
            return res;
        }
        return DFS(0);
    }
}
