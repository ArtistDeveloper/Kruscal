using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSub2
{
    class Node
    {
        int num;
        Point nodePoint;

        Node(Point nodePoint)
        {
            this.nodePoint = nodePoint;
        }

        public Point GetNodePoint()
        {
            return this.nodePoint;
        }

        public void SetNodePoint(Point nodePoint)
        {
            this.nodePoint = nodePoint;
        }
    }
}
