/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    HashSet<int> visited = new();
    public Node CloneGraph(Node head) {
        Dictionary<int,Node> dict = new ();
        Node DFS(Node node){
            if(node ==null) 
                return null;
            if(dict.ContainsKey(node.val))
                return dict[node.val];
            Node newNode = new Node(node.val);
            dict[newNode.val] = newNode;

            newNode.neighbors = node.neighbors.Select(x =>  DFS(x)).ToList();
            
            return newNode;
        }
        return DFS(head);
    }
}
