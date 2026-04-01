public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1;
        int r= piles.Max();
        int best=r;
        while(l<=r){
            int mid = l + (r-l)/2;
            int sumHourly = piles.Select(x=> (int)Math.Ceiling((double)x/mid)).Sum();
            if(sumHourly>h){
                l = mid+1;
            }
            else{
                best = Math.Min(best,mid);
                r = mid-1;
            }
        }
        return best;
    }
}
