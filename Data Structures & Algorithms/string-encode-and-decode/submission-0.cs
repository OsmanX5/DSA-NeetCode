public class Solution {

    public string Encode(IList<string> strs) {
        string res="";
        foreach(var s in strs){
            res += $"SEP;{s}";
        }
        return res;
    }

    public List<string> Decode(string s) {
        return s.Split("SEP;").Skip(1).ToList();
   }
}
