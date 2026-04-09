/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new List<List<int>>();
        Queue<TreeNode> qu = new();
        if(root ==null)
            return res;
        qu.Enqueue(root);
        while(qu.Count()>0){
            List<TreeNode> nodes = new();
            while(qu.Count()>0) nodes.Add(qu.Dequeue());
            res.Add(nodes.Select(x=>x.val).ToList());
            foreach(var node in nodes) {
                if(node.left != null)
                    qu.Enqueue(node.left);
                if(node.right !=null)
                    qu.Enqueue(node.right);
            }
        }
        return res;
    }
}
