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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode res =null;
        ListNode p1=list1;
        ListNode p2=list2;
        ListNode current = null;
        while (p1!=null || p2!=null){
            var smaller = GetSmaller(p1,p2);
            if(res==null) {
                res = smaller;
                current =res;
            }
            else {
                current.next=smaller;
                current = smaller;
            }

            if(smaller == p1) p1 = p1.next;
            else p2 = p2.next;
        }
        return res;


        ListNode GetSmaller(ListNode a,ListNode b){
            if(a == null) return b;
            if(b == null) return a;
            return a.val<=b.val? a : b;
        }
    }
}