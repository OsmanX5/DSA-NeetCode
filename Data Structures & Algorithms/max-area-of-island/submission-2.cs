public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        HashSet<int> visited = new();
        int res=0;
        int currentIslandArea=0;
        void DFS(int i, int j){
            if(i>=n || i<0 || j>=m || j<0 || grid[i][j]==0 ) return;
            int index = Index(i,j);
            if(visited.Contains(index)) return;
            currentIslandArea+=1;
            Console.WriteLine($"Visiting {i} {j} and area now is {currentIslandArea}");
            visited.Add(index);
            DFS(i+1,j);
            DFS(i-1,j);
            DFS(i,j+1);
            DFS(i,j-1);
        }
        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++){
                if(visited.Contains(Index(i,j)))
                    continue;
                if(grid[i][j]==0)
                    continue;
                currentIslandArea=0;
                DFS(i,j);
                res = Math.Max(res,currentIslandArea);
                Console.WriteLine($"Island Starts on {i} , {j} and max Area now is{res}");
            }
        return res;


        int Index(int i, int j) => i*m+j;
    }
}
