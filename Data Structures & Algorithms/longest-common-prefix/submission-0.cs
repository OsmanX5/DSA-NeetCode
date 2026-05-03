public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res ="";
        int m = strs[0].Length;
        for(int i =0 ;i<m;i++){
            char x = strs[0][i];
            foreach(string str in strs){
                if(i>= str.Length)
                    return res;
                char y = str[i];
                if(y!=x)
                    return res;
            }
            res +=x;
        }
        return res;
    }
}