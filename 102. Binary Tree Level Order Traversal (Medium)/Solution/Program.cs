namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> levels = new List<List<int>>();

        void AddLevel(TreeNode node, int level){
            if (node == null) return;
            if (levels.Count <= level) levels.Add(new List<int>());
            levels[level].Add(node.val);
            AddLevel(node.left, level + 1);
            AddLevel(node.right, level + 1);
        }

        AddLevel(root, 0);

        return levels;
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
