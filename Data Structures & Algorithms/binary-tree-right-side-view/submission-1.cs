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
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> BFS = new();
        if(root!=null)
            BFS.Enqueue(root);
        List<int> res = new();
        while(BFS.Count()>0){
            List<TreeNode> level = new();
            while(BFS.Count()>0)level.Add(BFS.Dequeue());
            res.Add(level[level.Count()-1].val);
            foreach(var node in level){
                if(node.left != null)
                    BFS.Enqueue(node.left);
                if(node.right!=null)
                    BFS.Enqueue(node.right);
            }
        }
        return res;
    }
}
