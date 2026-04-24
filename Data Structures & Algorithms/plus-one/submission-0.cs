public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry =1;
        int n =digits.Length;
        for(int i=n-1;i>=0;i--){
            int x = digits[i];
            x+=carry;
            Console.WriteLine($"x = {x}");
            if(x == 10){
                digits[i] =0;
                carry=1;
            }
            else{
                digits[i] +=1;
                return digits;
            }
            Console.WriteLine($"digit i = {digits[i]}");
        }
        List<int> res= new();
        res.Add(1);
        res.AddRange(digits);
        return res.ToArray();
    }
}
