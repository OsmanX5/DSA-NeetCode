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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        bool res = false;
        void DFS_rootFinder(TreeNode node){
            if(node ==null) return;
            if(node.val == subRoot.val){
                // DFS it sub ro
                Console.WriteLine($"Checking with {node.val}");
                if(AreSame(node , subRoot)){
                    res = true;
                    Console.WriteLine("The res is true");
                }
            }
            DFS_rootFinder(node.left);
            DFS_rootFinder(node.right);
        }
        DFS_rootFinder(root);
        return res;
    }
    bool AreSame(TreeNode parent,TreeNode child){
        if(parent ==null || child ==null)
            return parent ==child;
        bool left = AreSame(parent.left,child.left);
        bool right = AreSame(parent.right,child.right);
        return left && right && parent.val == child.val;
    }
}
