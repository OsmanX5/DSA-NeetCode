public class Solution {
    public bool IsValidSudoku(char[][] board) {
        foreach(var row in board){
            if(!IsValidRaw(row))
                return false;
        }
        for(int i=0;i<9;i++){
            char[] row = new char[9];
            for(int j=0;j<9;j++){
                row[j] = board[j][i];
            }
            if(!IsValidRaw(row))
                return false;
        }
        for(int i=0;i<9;i+=3){
            for(int j=0;j<9;j+=3){
                List<char> row = new();
                for(int x = i;x<i+3;x++)
                    for(int y=j;y<j+3;y++)
                        row.Add(board[x][y]);
                if(!IsValidRaw(row.ToArray()))
                    return false;
            }
        }
        return true;


        bool IsValidRaw(char[] row){
            HashSet<char> set= new();
            foreach(char x in row){
                if(x=='.') continue;
                if(set.Contains(x))
                    return false;
                set.Add(x);
            }
            return true;
        }
    }
}
