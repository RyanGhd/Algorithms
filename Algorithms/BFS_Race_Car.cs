// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/race-car/
/// 
/// 
/// </summary>
public class Race_Car
{
    public int Racecar(int target)
    {
        if (target == 0) return 0;

        var seen = new HashSet<string>();

        int level = Move(new List<Node> { new Node { Position = 0, Speed = 1 } }, target, 0, seen);

        return level;
    }

    private int Move(List<Node> nodes, int target, int level, HashSet<string> seen)
    {
        var children = new List<Node>();

        foreach (var node in nodes)
        {
            int position, speed;

            //A
            (position, speed) = A(node.Position, node.Speed);
            var aNode = new Node() { Position = position, Speed = speed };

            if (aNode.Position == target)
            {
                return level + 1;
            }

            //if (aNode.Position <= (target * 1.5))
            var seenKey = string.Concat(aNode.Speed, "#", aNode.Position);

            if (aNode.Position <= (target * 1.3) && !seen.Contains(seenKey))
            {
                children.Add(aNode);
                seen.Add(seenKey);
            }

            //R
            speed = R(node.Speed);
            var rNode = new Node() { Position = node.Position, Speed = speed };

            if (rNode.Position == target)
            {
                return level + 1;
            }

            seenKey = string.Concat(rNode.Speed, "#", rNode.Position);

            if (rNode.Speed != node.Speed && !seen.Contains(seenKey))
            {
                children.Add(rNode);
                seen.Add(seenKey);
            }

        }

        Console.WriteLine(string.Concat(children.Count, ",", seen.Count));

        var childLevel = Move(children, target, level + 1, seen);

        return childLevel;
    }


    private (int Position, int Speed) A(int initPosition, int initSpeed)
    {
        var speed = initSpeed;
        var position = initPosition;

        return (position + speed, speed * 2);
    }

    private static int R(int initSpeed)
    {
        var speed = initSpeed;

        return (speed > 0) ? -1 : 1;
    }


    public class Node
    {
        public int Position { get; set; }
        public int Speed { get; set; }
    }
}