public class Solution {
    public uint ReverseBits(uint n) {
        string str = Convert.ToString(n,2);
        string res ="";
        for(int i=0;i<32;i++){
            if(i<str.Length)
                res+= str[str.Length-i-1];
            else
                res+="0";
        }
        Console.WriteLine($"{n}");
        Console.WriteLine($"{str}");
        Console.WriteLine($"{res}");
        return Convert.ToUInt32(res,2);
    }
}
