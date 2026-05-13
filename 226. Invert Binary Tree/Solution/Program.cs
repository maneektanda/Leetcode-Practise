namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public TreeNode InvertTree(TreeNode root) {
        TreeNode start = root;

        Swap(start);

        return root;
    }

    public void Swap(TreeNode node){
        if (node == null) return;

        TreeNode temp = node.left;
        node.left = node.right;
        node.right = temp;

        Swap(node.left);
        Swap(node.right);
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
