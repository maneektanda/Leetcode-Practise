namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {     
        ListNode head = new ListNode();
        ListNode current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                current = current.next;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                current = current.next;
                list2 = list2.next;
            }
        }
        if (list1 == null)
        {
            current.next = list2;
        }
        if (list2 == null)
        {
            current.next = list1;
        }
        return head.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val= val;
        this.next = next;
    }
}