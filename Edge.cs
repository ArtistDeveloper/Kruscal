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
            int x1, x2, y1, y2;
            x1 = fromNode.GetNodePoint().X;
            y1 = fromNode.GetNodePoint().Y;
            x2 = toNode.GetNodePoint().X;
            y2 = toNode.GetNodePoint().Y;

            //EdgeGraphic.DrawLine(p, fromNode.GetNodePoint(), toNode.GetNodePoint());
            EdgeGraphic.DrawLine(p, x1+25, y1+25, x2+25, y2+25);
        }


    }
}

