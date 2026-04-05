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
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(true){
            slow = slow?.next;
            fast = fast?.next?.next;
            if(fast==null || slow ==null)
                break;
            if(slow==fast)
                return true;
        }
        return false;
    }
}
