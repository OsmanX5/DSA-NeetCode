public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] charsS = new int[26];
        int[] charsT = new int[26];
        foreach(char c in s)
            charsS[c-'a']++;
        foreach(char c in t)
            charsT[c-'a']++;
        for(int i=0;i<26;i++)
            if(charsS[i]!=charsT[i])
                return false;
        return true;
    }
}
