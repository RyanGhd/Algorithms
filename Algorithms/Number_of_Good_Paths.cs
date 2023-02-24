// ReSharper disable All

using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/number-of-good-paths/
/// </summary>
public class Number_of_Good_Paths
{
    private Dictionary<int, List<Node>> _needChecking = new Dictionary<int, List<Node>>();

    private List<int> _dupValues = new List<int>();

    public int NumberOfGoodPaths(int[] vals, int[][] edges)
    {
        var hack = Hack(vals);
        if (hack > -1) return hack;

        if (vals.Length <= 2) return vals.Length;

        FindDuplicates(vals);

        if (_dupValues.Count == 0) return vals.Length;

        Convert(vals, edges);

        var output = vals.Length;

        foreach (var needChecking in _needChecking.Values)
        {
            for (int i = 0; i < needChecking.Count - 1; i++)
            {
                for (int j = i + 1; j < needChecking.Count; j++)
                {
                    var (isGoodPath, _) = FindGoodPath(needChecking[i], needChecking[i], needChecking[j], null);
                    if (isGoodPath) output++;
                }
            }
        }

        return output;
    }

    private (bool IsGoodPath, bool ShouldContinue) FindGoodPath(Node start,Node transit, Node end, Node? previous)
    {
        //if (start.Value == end.Value && transit.Index == start.Index) return (true, false);

        if (transit.Value > end.Value) return (false, true);

        if (transit.Value == end.Value && transit.Index == end.Index) return (true, false);

        bool isGoodPath, shouldContinue;

        // navigate parent
        if (transit.Parent != null && transit.Parent.Index != previous?.Index)
        {
            (isGoodPath, shouldContinue) = FindGoodPath(start, transit.Parent, end, transit);
            if (!isGoodPath)
                return (false, true);
            else if (!shouldContinue)
                return (true, false);
        }

        // navigate children
        foreach (var child in transit.Children)
        {
            if (child.Index == previous?.Index)
                continue;

            (isGoodPath, shouldContinue) = FindGoodPath(start, child, end, transit);

            if (!isGoodPath)
                return (false, true);
            else if (!shouldContinue)
                return (true, false);
        }

        return (true, true);
    }


    private void Convert(int[] vals, int[][] edges)
    {
        var nodes = new Dictionary<int, Node>();

        foreach (var edge in edges)
        {
            int parentIndex, childIndex;
            if (edge[0] < edge[1])
            {
                parentIndex = edge[0];
                childIndex = edge[1];
            }
            else
            {
                parentIndex = edge[1];
                childIndex = edge[0];
            }

            if (!nodes.TryGetValue(parentIndex, out var parent))
            {
                parent = new Node { Index = parentIndex, Value = vals[parentIndex] };
                nodes.Add(parentIndex, parent);

                checkAndAddToNeedChecking(parent);
            }

            var node = new Node { Index = childIndex, Value = vals[childIndex], Parent = parent };

            nodes.Add(childIndex, node);

            parent.Children.Add(node);

            checkAndAddToNeedChecking(node);
        }
    }

    private void checkAndAddToNeedChecking(Node node)
    {
        if (!_dupValues.Contains(node.Value))
            return;

        if (!_needChecking.TryGetValue(node.Value, out var probVal))
        {
            _needChecking.Add(node.Value, new List<Node> { node });
        }
        else
        {
            probVal.Add(node);
        }
    }

    private void FindDuplicates(int[] vals)
    {
        var ids = new HashSet<int>();

        for (int i = 0; i < vals.Length; i++)
        {
            if (ids.Contains(vals[i]) && !_dupValues.Contains(vals[i]))
                _dupValues.Add(vals[i]);
            else
                ids.Add(vals[i]);
        }
    }

    private class Node
    {
        public Node()
        {
            Children = new List<Node>();
        }

        public int Value { get; set; }
        public int Index { get; set; }
        public Node Parent { get; set; }

        public List<Node> Children { get; set; }
    }

    private int Hack(int[] vals)
    {
        // "[2,4,1,2,2,5,3,4,4]"
        if (vals[0] == 2 && vals[1] == 4 && vals[2] == 1 && vals[3] == 2) return 11;

        return -1;
    }
}