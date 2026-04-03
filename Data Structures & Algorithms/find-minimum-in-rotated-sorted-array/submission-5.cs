public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int l=0;
        int r=n-1;
        while(l<=r){
            int m = (r+l)/2;
            int x=nums[m];
            Console.WriteLine($"l ={l} ; r={r} m ={m} x ={x}");
            if(nums[m==0? n-1:m-1] >= x)
                return x;
            if (x < nums[r])
                r =m-1;
            else 
                l=m+1;
        }
        return 0;
    }
}
