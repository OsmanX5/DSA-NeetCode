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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        bool bothBigger = p.val>root.val && q.val>root.val;
        bool bothSmaller = p.val<root.val && q.val<root.val;
        if(bothBigger)
            return LowestCommonAncestor(root.right,p,q);
        if(bothSmaller)
            return LowestCommonAncestor(root.left,p,q);
        return root;
    }
}
