public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> qu = new();
        foreach(int x in nums) qu.Enqueue(x, -x);
        for(int i=0;i<k-1;i++) qu.Dequeue();
        return qu.Peek();
    }
}
