public class Solution {
    public bool IsHappy(int n) {

        HashSet<int> visited = new();

        while(true){
            if(visited.Contains(n)) break;
            visited.Add(n);
            n = GetDigitsSum(n);
            Console.WriteLine($"added {n}");
            if(n==1) return true;
        }

        return false;

        
        int GetDigitsSum(int x) => DigitsSum(Digits(x));
        List<int> Digits(int x){
            var digits =x.ToString().ToCharArray();
            return digits.Select(x=>int.Parse($"{x}")).ToList();
        }
        int DigitsSum(List<int> digits) => digits.Aggregate(0,(acc,cur) => acc+cur*cur);
    }
}
