public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;
        int p = n-1;
        for(int i=0;i<n/2;i++){
            char temp = s[i];
            s[i] = s[p];
            s[p] = temp;
            p--;
        }
    }
}