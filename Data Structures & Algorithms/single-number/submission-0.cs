public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> set = new();
        foreach(int x in nums){
            if(set.Contains(x)) set.Remove(x);
            else set.Add(x);
        }
        return set.ElementAt(0);
    }
}
