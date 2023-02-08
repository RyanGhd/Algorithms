// ReSharper disable All

using Newtonsoft.Json;

namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/number-of-islands/description/?envType=study-plan&id=algorithm-ii
/// solution: https://leetcode.com/problems/number-of-islands/solutions/127691/number-of-islands/?envType=study-plan&id=algorithm-ii
/// I took a different apporach
/// 
/// complexity: 
/// </summary>
public class BFS_DFS__Number_of_Islands
{
    private int _lastIslandIndex = 0;

    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0) return 0;

        var nodes = new Node[grid.Length, grid[0].Length];
        var islands = new HashSet<int>();

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                CreateNode(row, col, grid, nodes, islands);
            }
        }

        Console.WriteLine();
        Console.WriteLine(JsonConvert.SerializeObject(nodes));

        return islands.Count;
    }

    public void CreateNode(int row, int col, char[][] grid, Node?[,] nodes, HashSet<int> islands)
    {
        if (grid[row][col] == '0')
            return;

        Node? node = null;
        if (row == 0 && col == 0)
        {
            _lastIslandIndex = 1;

            node = new Node(0, 0, 1, null);

            islands.Add(_lastIslandIndex);
        }
        else if (row == 0)
        {
            var leftIndex = col - 1;
            var left = nodes[row, leftIndex];

            if (left == null)
            {
                _lastIslandIndex++;
                node = new Node(row, col, _lastIslandIndex, null);
                islands.Add(_lastIslandIndex);
            }
            else
            {
                node = new Node(row, col, left.Island, new List<Node> { left });
                left.Neighbors.Add(node);
            }

        }
        else
        {
            var left = col - 1 < 0 ? null : nodes[row, col - 1];

            var top = row - 1 < 0 ? null : nodes[row - 1, col];

            if (left == null && top == null)
            {
                _lastIslandIndex++;
                node = new Node(row, col, _lastIslandIndex, null);
                islands.Add(_lastIslandIndex);
            }
            else if (left != null && top == null)
            {
                node = new Node(row, col, left.Island, new List<Node> { left });
                left.Neighbors.Add(node);
            }
            else if (left == null && top != null)
            {
                node = new Node(row, col, top.Island, new List<Node> { top });
                top.Neighbors.Add(node);
            }
            else
            {
                if (left.Island == top.Island)
                    node = new Node(row, col, top.Island, new List<Node> { top, left });
                else
                {
                    islands.Remove(left.Island);
                    UpdateIsland(left, top.Island);
                    node = new Node(row, col, top.Island, new List<Node> { left, top });
                }

                top.Neighbors.Add(node);
                left.Neighbors.Add(node);
            }
        }

        nodes[row, col] = node;
    }

    private void UpdateIsland(Node node, int island)
    {
        node.Island = island;

        foreach (var neighbor in node.Neighbors)
        {
            if (neighbor.Island == island)
                continue;

            neighbor.Island = island;
            UpdateIsland(neighbor, island);
        }
    }

    public class Node
    {
        [JsonIgnore]
        public int Row { get; set; }
        [JsonIgnore]
        public int Col { get; set; }
        public int Island { get; set; }
        [JsonIgnore]
        public List<Node> Neighbors { get; set; }


        public Node(int row, int col, int island, List<Node>? neighbors)
        {
            Row = row;
            Col = col;
            Island = island;
            Neighbors = neighbors != null ? neighbors : new List<Node>();
        }

        public override string ToString()
        {
            return this.Island.ToString();
        }
    }
}