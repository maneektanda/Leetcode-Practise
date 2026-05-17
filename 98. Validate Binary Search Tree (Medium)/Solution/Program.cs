namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public bool IsValidBST(TreeNode root) {
        // check the left node value is less than current node value
        // check right node value is greater than current ndoe value   

        // if not return false
        return CheckBST(root, int.MinValue, int.MaxValue);

    }

    public bool CheckBST(TreeNode node, int lowerBound, int upperBound){
        if (node == null) return true;

        if (!(node.val > lowerBound) || !(node.val < upperBound)) return false;

        bool left = CheckBST(node.left, lowerBound, node.val);
        bool right = CheckBST(node.right, node.val, upperBound);

        return left && right;
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
