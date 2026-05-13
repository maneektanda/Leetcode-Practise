namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    public bool IsSameTree(TreeNode node1, TreeNode node2) {
        
        if (node1 == null && node2 == null) return true;
        
        if (node1 == null ^ node2 == null) return false;

        if (node1.val != node2.val) return false;

        if (!IsSameTree(node1.left, node2.left)) return false;
        if (!IsSameTree(node1.right, node2.right)) return false;

        return true;
    }


    // Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
