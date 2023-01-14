using Async_Binary_Search;

class Program
{
    static async Task Main(string[] args)
    {
        BinarySearchTree bst = new();

        await bst.InsertAsync(5);
        await bst.InsertAsync(3);
        await bst.InsertAsync(7);
        await bst.InsertAsync(1);
        await bst.InsertAsync(4);
        await bst.InsertAsync(9);

        bool result = await bst.FindAsync(7);

        if (result)
        {
            Console.WriteLine("7 found in the tree");
        }
        else
        {
            Console.WriteLine("7 not found in the tree");
        }
    }
}