namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int MaxDepth(TreeNode root) {
        return Measure(root, 0);
    }

    public int Measure(TreeNode node, int depth){
        if (node == null) return depth;

        int leftDepth = Measure(node.left, depth + 1);
        int rightDepth = Measure(node.right, depth + 1);

        return Math.Max(leftDepth, rightDepth);
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
