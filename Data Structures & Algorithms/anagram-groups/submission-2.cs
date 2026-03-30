public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new();
        foreach(string s in strs){
            string sorted = new (s.Order().ToArray());
            if(dict.ContainsKey(sorted))
                dict[sorted].Add(s);
            else    
                dict[sorted] = new List<string>(){s};
        }
        //foreach(var kvp in dict)Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        return dict.Select(kvp=>kvp.Value).ToList();
    }
}
