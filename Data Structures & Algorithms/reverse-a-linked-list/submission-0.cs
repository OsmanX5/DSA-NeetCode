/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev=null;
        ListNode current = head;
        if(current==null) return head;
        while(true){
            var temp = current.next;
            current.next=prev;
            if(temp==null)
                return current;
            prev=current;
            current=temp;
        }
        return head;
    }
}
