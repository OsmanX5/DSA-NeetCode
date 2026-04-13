public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char,int> dict = new();
        foreach(var task in tasks){
            if(dict.ContainsKey(task)) dict[task]++;
            else dict[task]=1;
        }
        PriorityQueue<int,int> maxHeap = new();
        foreach(var kvp in dict){
            maxHeap.Enqueue(kvp.Value,-kvp.Value);
        }
        Queue<int[]> qu = new();
        int counter =0;
        while(maxHeap.Count>0 || qu.Count>0){
            if(qu.Count>0 && qu.Peek()[1] <= counter){
                int[] temp = qu.Dequeue();
                maxHeap.Enqueue(temp[0] , -temp[0]);
            }
            if(maxHeap.Count>0){
                int c = maxHeap.Dequeue() -1 ;
                if(c >0){
                    qu.Enqueue(new int[] { c ,counter+n+1});
                }
            }
            counter ++;
        }
        return counter;
    }
}
