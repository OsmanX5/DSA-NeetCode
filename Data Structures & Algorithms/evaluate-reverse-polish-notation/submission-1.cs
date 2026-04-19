public class Solution {
    public int EvalRPN(string[] tokens) {
        int DoOp(int x, int y, string op){
            if(op == "+") return x+y;
            if(op == "-") return x-y;
            if(op == "*") return x*y;
            if(op == "/") return x/y;
            return 0;
        }
        int n = tokens.Length;
        int res = int.Parse(tokens[0]);
        Stack<int> st = new();
        foreach(string str in tokens){
            if(str == "+" || str == "-" || str == "*" || str =="/"){
                int y = st.Pop();
                int x = st.Pop();
                res = DoOp(x,y,str);
                st.Push(res);
            }
            else{
                int temp = int.Parse(str);
                st.Push(temp);
            }
        }
        return res;

    }
}
