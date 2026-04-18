public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int p1 =0;
        int p2 = n-1;
        int res = nums.Sum();
        int acc = 0;
        Console.WriteLine($"Start SUm = {res}");
        for(int i=0;i<n;i++){
            if(acc <=0 )
                acc = nums[i];
            else
                acc+=nums[i];
            res = Math.Max(res,acc);
        }
        return res;
    }
}
