using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode d1 = new ListNode(3);
            ListNode d2 = new ListNode(4);
            ListNode d3 = new ListNode(2);
            d2.next = d1; d3.next = d2;


            ListNode e1 = new ListNode(4);
            ListNode e2 = new ListNode(6);
            ListNode e3 = new ListNode(5);
            e2.next = e1; e3.next = e2;


            Solution s = new Solution();
            ListNode result = s.AddTwoNumbers(d3, e3);
            DisplayList(result);
        }

        private static void DisplayList(ListNode result)
        {
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    }
}




public class ListNode
{
     public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }
}

public class Solution
{
    public ListNode AddLast(ListNode end, int value)
    {
        ListNode newNode = new ListNode(value);
        newNode.next = null;

        if (end != null)
        {
            end.next = newNode;
        }
        

        return newNode;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        ListNode endNode = null;
        int carry = 0;

        while (l1 != null && l2 != null)
        {
           
            endNode = AddLast(endNode, (carry + l1.val + l2.val) % 10);
            if (result == null)
                result = endNode;
            
            carry = (carry + l1.val + l2.val) / 10;
            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 != null)
        {
            endNode = AddLast(endNode, (carry + l1.val) % 10);

            carry = (carry + l1.val) / 10;
            l1 = l1.next;
        }
        while (l2 != null)
        {
            endNode = AddLast(endNode, (carry + l2.val) % 10);
            
            carry = (carry + l2.val) / 10;
            l2 = l2.next;
        }
        if (carry != 0)
            endNode = AddLast(endNode, carry);

        return result;
    }
}