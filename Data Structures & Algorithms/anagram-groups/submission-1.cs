public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,int> dict = new();
        foreach(var str in strs)
            dict[str] = dict.TryGetValue(str,out int c) ? c+1:1;
        List<List<string>> res = new();
        for(int i=0;i<strs.Length;i++){
            string str = strs[i];
            if(!dict.ContainsKey(str)) continue;

            List<string> r = new ();
            r.AddRange(Enumerable.Repeat(str,dict[str]));
            
            dict[str]=0;
            dict.Remove(str);
            
            foreach(var kvp in dict){
                if(!IsAnagram(str, kvp.Key))
                    continue;
                r.AddRange(Enumerable.Repeat(kvp.Key,kvp.Value));
                dict.Remove(kvp.Key);
            }

            res.Add(r);
        }
        return res;
        bool IsAnagram(string a, string b) {
            if(a.Length != b.Length) 
                return false;
            int[] chars = new int[26];
            foreach(char c in a) chars[c-'a']++;
            foreach(char c in b) chars[c-'a']--;
            return chars.All(x=> x==0);
        }
    }
}
