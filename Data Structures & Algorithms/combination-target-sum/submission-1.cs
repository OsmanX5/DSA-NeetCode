public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new();
        void DFS(int i,List<int> sub){
            if(sub.Sum()==target){
                //Console.WriteLine($"Added {ListStr(sub)}");
                res.Add(sub);
                return;
            }
            if(i>= nums.Length) 
                return;
            //Console.WriteLine($"working on {i} [{nums[i]}] || {ListStr(sub)}");
            DFS(i+1,sub);
            int x = nums[i];
            int rem = target - sub.Sum();
            rem = Math.Max(rem,0);
            int div = rem/x;
            //Console.WriteLine($"we could DFS with {div} ways of {x}");
            for(int count=1;count<=div;count++){
                List<int> temp = new (sub);
                for(int j=0;j<count;j++)
                    temp.Add(x);
                DFS(i+1,temp);
            }
        }
        DFS(0,new List<int>());
        return res;
    }
    string ListStr(List<int> list) => list.Aggregate("",(acc,cur)=>$"{acc},{cur}");
}
