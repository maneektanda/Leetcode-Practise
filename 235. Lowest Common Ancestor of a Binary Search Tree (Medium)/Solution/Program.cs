namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // create a queue for each node path
        Queue<TreeNode> pathP = new Queue<TreeNode>();
        Queue<TreeNode> pathQ = new Queue<TreeNode>();

        void GetPath(TreeNode node, Queue<TreeNode> path){
            if (node != null){
                // Enqueue the node as long as it's not null
                path.Enqueue(node);

                // target p found
                if (node == p){
                    pathP = new Queue<TreeNode>(path);
                }

                // target q found
                if (node == q){
                    pathQ = new Queue<TreeNode>(path);;
                }

                // target not found
                // therefore look left and right
                Queue<TreeNode> leftPath = new Queue<TreeNode>(path);
                Queue<TreeNode> rightPath = new Queue<TreeNode>(path);

                GetPath(node.left, leftPath);
                GetPath(node.right, rightPath);                
            }
            return;
        }
        Queue<TreeNode> emptyPath = new Queue<TreeNode>();
        GetPath(root, emptyPath);        
        
        // dequeue and find where they diverge, then return the previous node.
        // allow for empty paths

        if (pathP.Count == 0 || pathQ.Count == 0) return root;
        

        TreeNode prevP = pathP.Dequeue();
        TreeNode prevQ = pathQ.Dequeue();

        while (pathP.Count > 0 && pathQ.Count > 0){
            TreeNode currP = pathP.Dequeue();
            TreeNode currQ = pathQ.Dequeue();

            if (currP != currQ) return prevP;

            else {
                prevP = currP;
                prevQ = currQ;
            }
        }

        return prevP;
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
