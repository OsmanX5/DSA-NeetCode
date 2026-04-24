public class Solution {
    public int HammingWeight(uint n) {
        int res =0;
        while(n>0){
            res += (int)n%2;
            n = n/2;
        }
        return res;
    }
}
