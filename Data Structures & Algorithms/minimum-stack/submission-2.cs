public class MinStack {
    Stack<int> st;
    Stack<int> mins;
    public MinStack() {
        st = new();
        mins = new ();
    }
    
    public void Push(int val) {
        st.Push(val);
        if(mins.Count ==0){
            mins.Push(val);
            return;
        }
        if(val <= mins.Peek()){
            mins.Push(val);
        }
        
    }
    
    public void Pop() {
        int poped = st.Pop();
        if(mins.Peek() == poped){
            mins.Pop();
        }

    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return mins.Peek();
    }
}
