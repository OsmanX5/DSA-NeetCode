public class KthLargest {
    PriorityQueue<int,int> qu = new();
    int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach(int x in nums)
            qu.Enqueue(x , -x);
    }
    
    public int Add(int val) {
        qu.Enqueue(val,-val);
        List<int> temp = new();
        for(int i=0;i<k;i++) 
            temp.Add(qu.Dequeue());

        int res = temp.Last();
        
        foreach(int x in temp)
            qu.Enqueue(x , -x);
        return res;
    }
}
