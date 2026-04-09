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
    int maxD =0;
    public int DiameterOfBinaryTree(TreeNode root) {
        int Depth(TreeNode node){
            if(node == null) return 0;
            if(node.left==null && node.right ==null) return 1;
            return Math.Max(Depth(node.left),Depth(node.right)) +1;
        }
        if(root ==null)
            return 0;
        int myD = Depth(root.left) + Depth(root.right);
        maxD = Math.Max(myD,maxD);
        DiameterOfBinaryTree(root.left);
        DiameterOfBinaryTree(root.right);
        return maxD;
    }
}
