public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int res=0;
        int DFS(int i, int j){
            if(i>=n || i<0 || j>=m || j<0 || grid[i][j]==0 ) 
                return 0;
            grid[i][j] =0;
            return DFS(i+1,j)+DFS(i-1,j)+DFS(i,j+1)+DFS(i,j-1)+1;
        }
        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++)
                res = Math.Max(res,DFS(i,j));
        return res;

    }
}
