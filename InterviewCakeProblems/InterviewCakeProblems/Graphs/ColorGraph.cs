using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Graphs
{
    /// <summary>
    /// Problem #45
    /// Given an undirected graph with maximum degree D, 
    /// find a graph coloring using at most D+1 colors.
    /// </summary>
    public class ColorGraph
    {
        public void CreateColorGraph(GraphNode[] graph, string[] colors)
        {
            foreach (var node in graph)
            {
                if (node.Neighbors.Contains(node))
                {
                    throw new ArgumentException(
                        "Legal coloring impossible for node with loop: ${node.Label}",
                        nameof(graph));
                }



                // Get the node's neighbors' colors, as a set so we
                // can check if a color is illegal in constant time
                var illegalColors = new HashSet<string>(
                    from neighbor in node.Neighbors
                    where neighbor.Color != null
                    select neighbor.Color);

                var illegalColorsUsingLinq = new HashSet<string>(
                    node.Neighbors.Where(n => n.Color != null).Select(n => n.Color));

                // Assign the first legal color
                node.Color = colors.First(c => !illegalColors.Contains(c));
            }
        }
    }
}
