namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void ReorderList(ListNode head)
    {
        List<ListNode> nodes = new List<ListNode>();
        while (head != null)
        {
            nodes.Add(head);
            head = head.next;
        }

        if (nodes.Count == 1) return;

        for (int i = 0; i < nodes.Count / 2 ; i++)
        {
            nodes[i].next = nodes[^(i + 1)];
            nodes[^(i + 1)].next = nodes[i + 1];
        }

        if (nodes.Count % 2 != 0)
        {
            nodes[(nodes.Count / 2) + 1].next = nodes[nodes.Count / 2];
        }            

        nodes[nodes.Count / 2].next = null;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
