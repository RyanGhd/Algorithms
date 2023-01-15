using System.Diagnostics.Tracing;

namespace Algorithms;

public class BST_Contains_Duplicate
{
    

    public bool ContainsDuplicate(int[] nums) // this is quicker that binary search tree
    {
        if (nums == null || nums.Length <= 1) return false;

        var distinct = nums.Distinct();

        return (distinct.Count() < nums.Length);

    }
    public bool ContainsDuplicateUsingSorting(int[] nums) // this is quicker that binary search tree
    {
        if (nums == null || nums.Length <= 1) return false;

        var sorted = nums.OrderBy(i=>i).ToArray();

        for (int i = 0; i <= sorted.Length-2; i++)
        {
            if (sorted[i]==sorted[i+1]) return true;
        }

        return false;
    }
    public bool ContainsDuplicateUsingBST(int[] nums) // binary search tree
    {
        if (nums == null || nums.Length <= 1) return false;

        Random rnd = new Random();
        var shuffled = nums.OrderBy(x => rnd.Next()).ToArray();

        var node = new DupNode(shuffled[0]);

        for (int i = 1; i < shuffled.Length; i++)
        {
            var result = CreateNode(shuffled[i], node);

            if (!result.Created)
                return true;
        }

        return false;
    }

    private (DupNode? Node, bool Created) CreateNode(int value, DupNode? node)
    {
        (DupNode? Node, bool Created) result = new(null, true);

        if (node == null)
            return (new DupNode(value), true);
        else if (node.Value == value)
            return (node, false);
        else if (value < node.Value)
        {
            result = CreateNode(value, node.Left);
            if (!result.Created)
                return (node, false);

            node.Left = result.Node;
        }
        else
        {
            result = CreateNode(value, node.Right);
            if (!result.Created)
                return (node, false);

            node.Right = result.Node;
        }

        return new(node, result.Created);
    }
}

public class DupNode
{
    public int Value { get; private set; }
    public DupNode? Left { get; set; }
    public DupNode? Right { get; set; }

    public DupNode(int value)
    {
        Value = value;
    }
}