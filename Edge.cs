using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoSub2
{
    class Edge
    {
        Node fromNode;
        Node toNode;
        Graphics EdgeGraphic;

        //좌표값 받아오기.

        public Edge(Node fromNode, Node toNode, Graphics EdgeGraphic)
        {
            this.fromNode = fromNode;
            this.toNode = toNode;
            this.EdgeGraphic = EdgeGraphic;
        }

        public void DrawEdge()
        {
            Pen p = new Pen(Color.Black, 2);
            EdgeGraphic.DrawLine(p, fromNode.GetNodePoint(), toNode.GetNodePoint());
        }


    }
}
