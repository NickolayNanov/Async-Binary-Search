namespace Async_Binary_Search
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value) => Value = value;
    }

    public class BinarySearchTree
    {
        private Node? root;

        // Inserts a new value into the tree
        public async Task InsertAsync(int value)
        {
            // If tree is empty, new value becomes the root
            if (root == null)
            {
                root = new Node(value);
                return;
            }

            // Start at the root
            Node? current = root;
            while (current != null)
            {
                // If new value is less than current value, move to left child
                // If left child is null, insert new value as left child
                // If new value is greater than or equal to current value, move to right child
                if (value < current.Value)
                {    
                    if (current.Left == null)
                    {
                        current.Left = new Node(value);
                        return;
                    }
                    current = current.Left;
                }
                else
                {
                    // If right child is null, insert new value as right child
                    if (current.Right == null)
                    {
                        current.Right = new Node(value);
                        return;
                    }
                    current = current.Right;
                }
                await Task.Delay(10);  //simulating some asynchronous processing 
            }
        }

        public async Task<bool> FindAsync(int value)
        {
            // Start at the root
            Node? current = root;

            while (current != null)
            {
                // If current value is equal to the target, return true
                // If target value is less than current value, move to left child
                // If target value is less than current value, move to left child
                // If target value is greater than current value, move to right child
                if (value == current.Value)
                {
                    return true;
                }
                else if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                await Task.Delay(10);  //simulating some asynchronous processing 
            }

            // Target not found, return false
            return false;
        }
    }
}
