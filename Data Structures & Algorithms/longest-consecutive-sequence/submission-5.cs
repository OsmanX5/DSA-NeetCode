public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set= new HashSet<int>(nums);
        int n=nums.Length;
        int res= 0;
        for(int i=0;i<n;i++){
            int x = nums[i];
            if(!set.Contains(x-1)){
                //seq start
                int len=1;
                while(set.Contains(++x))
                    len++;
                res=Math.Max(res,len);
            }
        }
        return res;
    }
}
