public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int p1=0;
        int n = numbers.Length;
        int p2=n-1;
        while(p2>p1){
            int x = numbers[p1];
            int y = numbers[p2];
            int sum = x+y;

            if(sum == target)
                return new int[2]{p1+1,p2+1};
            if(sum<target)
                p1++;
            else
                p2--;
        }
        return null;
    }
}
