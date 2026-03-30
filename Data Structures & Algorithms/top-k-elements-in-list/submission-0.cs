public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        PriorityQueue<int,int> pq = new();
        foreach(int x in nums)
            dict[x] = dict.TryGetValue(x, out int c)? c+1:1;
        
        foreach(var kvp in dict){
            pq.Enqueue(kvp.Key,-kvp.Value);
            //Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }
        int[] res = new int[k];
        for(int i=0;i<k;i++) res[i] = pq.Dequeue();
        return res;
    }
}
