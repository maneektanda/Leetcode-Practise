namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public bool HasCycle(ListNode head) {
        HashSet<ListNode> seen = new HashSet<ListNode>();

        while(head != null){
            if (seen.Contains(head)){
                return true;
            }
            seen.Add(head);
            head = head.next;
        }
        return false;
    }

  //Deinition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 
}
