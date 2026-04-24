public class Solution {
    public int SingleNumber(int[] nums) => nums.Aggregate(0, (acc,cur)=> acc^cur);
}
