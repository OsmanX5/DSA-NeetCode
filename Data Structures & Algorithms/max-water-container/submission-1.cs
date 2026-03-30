public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int n = heights.Length;
        int l=0;
        int r = n-1;
        while(l<r){
            int x = heights[l];
            int y = heights[r];
            int area = (r-l) * Math.Min(x,y);
            maxArea = Math.Max(area,maxArea);
            if(x<y)
                l++;
            else
                r--;
        }
        return maxArea;
    }
}
