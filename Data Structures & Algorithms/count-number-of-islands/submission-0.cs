public class Solution {
    public int NumIslands(char[][] grid) {
        int n =grid.Length;
        int m = grid[0].Length;
        HashSet<int> visited = new();
        void DFS(int i,int j){
            if(i>=n || i<0 || j>=m ||j<0) 
                return;
            int index = GetIndex(i,j);
            if(visited.Contains(index)) return;
            visited.Add(index);
            bool isLand = grid[i][j] == '1';
            if(isLand){
                DFS(i+1,j);
                DFS(i-1,j);
                DFS(i,j+1);
                DFS(i,j-1);
            }
        }

        int res=0;

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                int index = GetIndex(i,j);
                if(visited.Contains(index))
                    continue;
                if(grid[i][j] == '0') 
                    continue;
                res++;
                DFS(i,j);
            }
        }
        return res;

        int GetIndex(int i,int j) => grid[0].Length * i + j;
    }
}
