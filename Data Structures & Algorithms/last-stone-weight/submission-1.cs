public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> qu = new();
        foreach(var x in stones) qu.Enqueue(x , -x);
        while(true){
            if(qu.Count == 1) return qu.Dequeue();
            if(qu.Count ==0) return 0;
            int largest = qu.Dequeue();
            int second = qu.Dequeue();
            int afterSmash = largest-second;
            qu.Enqueue(afterSmash,-afterSmash);

        }
        return 0;
    }
}
