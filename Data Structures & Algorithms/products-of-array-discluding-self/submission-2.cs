public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        long prod = nums.Aggregate(
            nums.Count(x=>x==0)>1 ? 0 : 1
            ,(total,next)=>{
                Console.WriteLine($"{next} : {total}");
                return next==0? total:total*next;
            });
        //Console.WriteLine(prod);
        if(nums.Contains(0)){
            return nums.Select(x=>x==0?(int)prod:0).ToArray();
        }
        
        return nums.Select(x=>(int)(prod/x)).ToArray();
    }
}
