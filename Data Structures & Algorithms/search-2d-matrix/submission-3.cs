public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n=matrix.Length;
        if(n==0)return false;
        int m = matrix[0].Length;
        int l=0;
        int r= n*m-1;
        while(l<=r){
            int mid = (l+r)/2;
            int row = mid/m;
            int col = mid%m;
            int x = matrix[row][col];
            if(x==target) return true;
            if(x<target) l=mid+1;
            else r = mid-1;
        }
        return false;
    }
}
