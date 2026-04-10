public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> res = new();
        int n = candidates.Length;
        void DFS(int i , List<int> sub,int total){
            if( total== target){
                res.Add(new List<int>(sub));
                return;
            }
            if(i>= candidates.Length || total>target)
                return;
            sub.Add(candidates[i]);
            DFS(i+1,sub ,total + candidates[i]);
            sub.RemoveAt(sub.Count-1);
            int p = i;
            while(p<n && candidates[i] == candidates[p]) p++;
            DFS(p,sub,total);
        }
        DFS(0,new List<int>(),0);
        return res;
    }
}
