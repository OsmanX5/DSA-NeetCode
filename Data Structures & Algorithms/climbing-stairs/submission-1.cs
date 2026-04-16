public class Solution {
    public int ClimbStairs(int n) {     
        Dictionary<int,int> dict = new ();
        return DFS(n);


        int DFS(int x){
            if(dict.ContainsKey(x))
                return dict[x];
            if(x<0) return 0;
            if(x==0)return 1;
            int res = DFS(x-2)+DFS(x-1);
            dict[x] = res;
            return res;
        }

    }
}
