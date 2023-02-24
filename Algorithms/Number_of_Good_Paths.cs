// ReSharper disable All

using System.ComponentModel.Design;
using System.Diagnostics;
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
        if (vals.Length <= 1) return vals.Length;

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
                    var isGoodPath= FindGoodPath(needChecking[i], needChecking[j], null);
                    if (isGoodPath)
                    {
                        output++;
                       Debug.Write(output);
                    }
                }
            }
        }

        return output;
    }

    private bool FindGoodPath(Node transit, Node end, Node? previous)
    {
        if (transit.Value > end.Value) return false;

        if (transit.Value == end.Value && transit.Index == end.Index) return true;

        bool isGoodPath;

        // navigate parent
        if (transit.Parent != null && transit.Parent.Index != previous?.Index)
        {
            isGoodPath = FindGoodPath(transit.Parent, end, transit);
            if (isGoodPath)
                return true;
        }

        // navigate children
        foreach (var child in transit.Children)
        {
            if (child.Index == previous?.Index)
                continue;

            isGoodPath = FindGoodPath(child, end, transit);

            if (isGoodPath)
                return true;
        }

        return false;
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

     
}