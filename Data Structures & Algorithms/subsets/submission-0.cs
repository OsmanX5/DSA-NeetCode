public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new();
        void DFS(int i,List<int> subSet){
            if(i == nums.Length){
                res.Add(subSet);
                return;
            }
            DFS(i+1,subSet);
            // add 
            var added = new List<int>(subSet);
            added.Add(nums[i]);
            DFS(i+1,added);
            //don't add it
        }
        List<int> subSet = new();
        DFS(0,subSet);
        return res;
    }
}
