using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Graphs
{
    /// <summary>
    /// Problem 46
    /// Given information about active users on the network, 
    /// find the shortest route for a message from one user (the sender) 
    /// to another (the recipient). Return an array of users that make up this route.
    /// </summary>
    public class MeshMessage
    {
        public void BreadthFirstSearchOfGraph(Dictionary<string, string[]> graph, string startNode, string endNode)
        {
            var nodesToVisit = new Queue<string>();
            nodesToVisit.Enqueue(startNode);

            // Keep track of what nodes we've already seen so we don't process them twice
            var nodesAlreadySeen = new HashSet<string>();
            nodesAlreadySeen.Add(startNode);

            while (nodesToVisit.Count > 0)
            {
                var currentNode = nodesToVisit.Dequeue();

                // Stop when we reach the end node
                if (currentNode == endNode)
                {
                    break;
                }

                foreach (var neighbor in graph[currentNode])
                {
                    if (!nodesAlreadySeen.Contains(neighbor))
                    {
                        nodesAlreadySeen.Add(neighbor);
                        nodesToVisit.Enqueue(neighbor);
                    }
                }
            }
        }



        public string[] BreadthFirstSearchGetPath(Dictionary<string, string[]> graph, string startNode, string endNode)
        {
            if (!graph.ContainsKey(startNode))
            {
                throw new ArgumentException("Start node not in graph", nameof(startNode));
            }
            if (!graph.ContainsKey(endNode))
            {
                throw new ArgumentException("End node not in graph", nameof(endNode));
            }

            var nodesToVisit = new Queue<string>();
            nodesToVisit.Enqueue(startNode);

            // Keep track of how we got to each node.
            // We'll use this to reconstruct the shortest path at the end.
            // We'll ALSO use this to keep track of which nodes we've already visited.
            var howWeReachedNodes = new Dictionary<string, string>();
            howWeReachedNodes.Add(startNode, null);

            while (nodesToVisit.Count > 0)
            {
                var currentNode = nodesToVisit.Dequeue();

                // Stop when we reach the end node
                if (currentNode == endNode)
                {
                    return ReconstructPath(howWeReachedNodes, startNode, endNode);
                }

                foreach (var neighbor in graph[currentNode])
                {
                    if (!howWeReachedNodes.ContainsKey(neighbor))
                    {
                        nodesToVisit.Enqueue(neighbor);
                        howWeReachedNodes.Add(neighbor, currentNode);
                    }
                }
            }

            // If we get here, then we never found the end node
            // so there's NO path from startNode to endNode
            return null;
        }

        private string[] ReconstructPath(Dictionary<string, string> howWeReachedNodes, string startNode, string endNode)
        {
            var reversedShortestPath = new List<string>();

            // Start from the end of the path and work backwards
            var currentNode = endNode;

            while (currentNode != null)
            {
                reversedShortestPath.Add(currentNode);
                currentNode = howWeReachedNodes[currentNode];
            }

            // Reverse our path to get the right order
            // by flipping it around, in place
            reversedShortestPath.Reverse();
            return reversedShortestPath.ToArray();
        }


    }
}
