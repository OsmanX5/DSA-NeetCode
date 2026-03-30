public class Solution {
    public int LongestConsecutive(int[] nums) {
        nums = new HashSet<int>(nums).ToArray();
        Array.Sort(nums);
        int n = nums.Length;
        if(n<1) return 0;
        int res =1;
        int current=1;
        for(int i=0;i<n-1;i++){
            if( Math.Abs(nums[i+1]-nums[i])==1)
                current++;
            else 
                current=1;
            res = Math.Max(current,res);
        }
        return res;
    }
}
