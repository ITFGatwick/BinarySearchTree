namespace BinarySearchTree.BST
{
    public class BinarySearchTreeNode<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public BinarySearchTreeNode<TKey, TValue> Left { get; set; }
        public BinarySearchTreeNode<TKey, TValue> Right { get; set; }
    }
}