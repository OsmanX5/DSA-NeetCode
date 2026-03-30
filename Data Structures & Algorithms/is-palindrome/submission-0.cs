public class Solution {
    public bool IsPalindrome(string s) {
        var sanatized=s.ToLower().Where(x => ( x>='a'&& x <='z') || (x>='0' &&x<='9')).ToArray();
        string str = String.Join("",sanatized);
        string str2 = String.Join("",sanatized.Reverse());
        return str==str2;
    }
}
