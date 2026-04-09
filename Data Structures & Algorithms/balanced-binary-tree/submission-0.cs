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
    bool isBalanced;
    public bool IsBalanced(TreeNode root) {
        int DFS(TreeNode node){
            if(node ==null) return 0;
            int left = DFS(node.left);
            int right = DFS(node.right);
            int dif = Math.Abs(left-right);
            int h = Math.Max(left,right)+1;
            Console.WriteLine($"at {node.val} dif ={dif} , h ={h}");
            if(dif>1)
                isBalanced=false;
            return h;
        }
        isBalanced = true;
        DFS(root);
        return isBalanced;
    }
}
