public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new();
        var pairs = new Dictionary<char,char>(){
            {'(' , ')'},
            {'{' , '}'},
            {'[' , ']'}
        };
        foreach(char c in s){
            bool isOpen = pairs.ContainsKey(c);
            if(isOpen){
                st.Push(c);
                continue;
            }
            if(st.Count ==0)
                return false;
            char peek = st.Pop();
            if(pairs[peek] != c)
                return false;
        }
        return st.Count ==0;
    }
}
