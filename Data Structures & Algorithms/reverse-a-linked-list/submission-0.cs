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

        if(head == null)
            return head;


        ListNode curnode = head;
        ListNode prevnode = null;
        ListNode nextnode = null;
        while(curnode != null)
        {
             nextnode = curnode.next;
             curnode.next = prevnode;
             prevnode = curnode;
             curnode = nextnode;

        }   
    return prevnode;
            
        
    }
}
