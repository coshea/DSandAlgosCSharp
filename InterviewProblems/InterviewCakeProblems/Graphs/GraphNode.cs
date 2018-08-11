using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Graphs
{
    public class GraphNode
    {
        public string Label { get; }
        public ISet<GraphNode> Neighbors { get; }
        public string Color { get; set; }

        public GraphNode(string label)
        {
            Label = label;
            Neighbors = new HashSet<GraphNode>();
        }

        public void AddNeighbor(GraphNode neighbor)
        {
            Neighbors.Add(neighbor);
        }
    }
}
