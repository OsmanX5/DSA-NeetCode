public class Solution {
    public int[] DailyTemperatures(int[] temps) {
        Stack<int> st = new();
        int n = temps.Length;
        st.Push(0);
        int[] res = new int[n];
        for(int i=1;i<n;i++){
            int x = temps[i];
            while(true){
                if(st.Count==0) {
                    st.Push(i);
                    break;
                }
                int peekI = st.Peek();
                int peek = temps[peekI];
                if(x>peek){
                    res[peekI] = i-peekI;
                    st.Pop();
                }
                else{
                    st.Push(i);
                    break;
                }
            }   
        }
        return res;
    }
}
