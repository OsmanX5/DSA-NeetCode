public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        Console.WriteLine($"Start");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]==2147483647)
                    BFS(i,j);
            }
        }
        void BFS(int startI ,int startJ){
            Console.WriteLine($"BFS ON {startI} , {startJ}");
            Queue<(int i, int j)> qu = new();
            qu.Enqueue((startI,startJ));
            HashSet<(int i,int j)> visited = new();
            int levelC =0;
            while(qu.Count>0){
                // Console.WriteLine($"New Level {levelC}");
                List<(int i,int j)> level = new List<(int i,int j)>();
                while(qu.Count>0) level.Add(qu.Dequeue());
                foreach(var point in level){
                    int i= point.i;
                    int j=point.j;
                    int x = grid[i][j];
                    if(visited.Contains(point)) 
                        continue;
                    visited.Add(point);
                    // Console.WriteLine($"Proccess ({i} ,{j}) = {x}");
                    if(x == 0){
                        grid[startI][startJ] = Math.Min(grid[startI][startJ],levelC);
                    }
                    if(IsValid(i-1,j))
                        qu.Enqueue((i-1,j));
                    if(IsValid(i+1,j))
                        qu.Enqueue((i+1,j));
                    if(IsValid(i,j-1))
                        qu.Enqueue((i,j-1));
                    if(IsValid(i,j+1))
                        qu.Enqueue((i,j+1));
                
                }
                levelC++;
            }


            bool IsValid(int i,int j){
            if(i<0 || i>=n ||j<0 ||j>=m) 
                return false;
            if(grid[i][j] == -1)
                return false;
            return true;
            }
        }
        

    }
}
