public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> set = new (nums);
        for(int i=0;i<nums.Length;i++){
            int x = nums[i];
            if(set.Contains(target -x )){
                for(int j=i+1;j<nums.Length;j++){
                    if(nums[j] == target-x)
                        return new int[] {i,j};
                }
            }
        }
        return null;
    }
}
