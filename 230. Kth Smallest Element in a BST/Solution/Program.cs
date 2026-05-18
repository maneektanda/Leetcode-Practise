namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    // Using in-order traversal instead
    public int KthSmallest(TreeNode root, int k) {
        if (root == null) return 0;

        List<int> sortedList  = new List<int>();
        DfsInOrder(root, sortedList);
        return sortedList[k - 1];
    }

    public void DfsInOrder(TreeNode node, List<int> sortedList){
        if (node == null) return;

        DfsInOrder(node.left, sortedList);
        sortedList.Add(node.val);
        DfsInOrder(node.right, sortedList);
    }


    // // Using stack to just get all elements and insert in order

    // public int KthSmallest(TreeNode root, int k) {

    //     if (root == null) return 0;

    //     List<int> sortedList = new List<int>();

    //     // iterate of each node, add to sorted array
    //     Stack<TreeNode> stack = new Stack<TreeNode>();

    //     stack.Push(root);

    //     while (stack.Count != 0){
    //         TreeNode node = stack.Pop();
    //         if (node == null) continue;
    //         sortedList = InsertionSort(sortedList, node.val);

    //         stack.Push(node.right);
    //         stack.Push(node.left);
    //     }
        
    //     // return kth smallest element of array
    //     return sortedList[k - 1];
    // }

    // public List<int> InsertionSort(List<int> sortedList, int val){
    //     if (sortedList.Count == 0){
    //         sortedList.Add(val);
    //         return sortedList;
    //     }
        
    //     sortedList.Add(val);

    //     // 2nd last element
    //     int i = sortedList.Count - 2;

    //     while (i >= 0 && sortedList[i] > sortedList[i + 1]){
    //         // swap elements
    //         int temp = sortedList[i];
    //         sortedList[i] = sortedList[i + 1];
    //         sortedList[i + 1] = temp;
    //         i--;
    //     }

    //     return sortedList;
    // }

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
