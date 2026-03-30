public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // seprate to 2 arrays
        var pos = nums.Where(x=> x>0).Order().ToArray();
        var neg = nums.Where(x=> x<0).Order().ToArray();
        var zeros = nums.Where(x=> x==0);
        
        bool hasZero = zeros.Count()>0;
        HashSet<(int a, int b,int c)> triplets = new();
        if(zeros.Count()>=3) triplets.Add((0,0,0));
        foreach(int x in neg)Console.WriteLine($"{x}");
        

        // check for 1 pos = 2 neg
        foreach(var p in pos){
            var pairs = TwoSum(neg, -p);
            foreach(var pair in pairs){
                ///Console.WriteLine($"adding  {pair.x} , {pair.y},{p}");
                triplets.Add((pair.x,pair.y,p));
            }
            if(hasZero && neg.Contains(-p)) triplets.Add((-p,0,p));
        }
        //check for 1neg = 2pos
        foreach(var n in neg){
            var pairs = TwoSum(pos, -n);
            foreach(var pair in pairs){
                //Console.WriteLine($"adding {n} , {pair.x} , {pair.y}");
                triplets.Add((n,pair.x,pair.y));
            }
            if(hasZero && pos.Contains(-n)) triplets.Add(( n,0,-n));

        }
        
        // foreach(var trip in triplets){
        //     Console.WriteLine($"{trip.a} ,{trip.b} ,{trip.c}");
        // }
        List<List<int>> res = new();
        foreach(var trip in triplets){
            var temp = new List<int>(){trip.a,trip.b,trip.c};
            res.Add(temp);
        }
        return res;
        //2 sum function
        List<(int x,int y)> TwoSum(int[] sortedNums,int target){
            int p1=0;
            int p2=sortedNums.Length-1;
            var res = new List<(int x, int y)>();
            while(p1<p2){
                int sum = sortedNums[p1]+sortedNums[p2];
                if(sum == target){
                    res.Add((sortedNums[p1],sortedNums[p2]));
                    p2-=1;
                    continue;
                }
                if(sum<target){
                    p1++;
                }
                else{
                    p2--;
                }
            }
            return res;
        }
        return null;
    }
}
