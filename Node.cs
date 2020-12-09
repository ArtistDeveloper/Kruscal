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
        int nodeNum;
        Point nodePoint;
        Graphics nodeGraphic;

        public Node(int num, Point nodePoint, Graphics nodeGraphic)
        {
            this.nodeNum = num;
            this.nodePoint = nodePoint;
            this.nodeGraphic = nodeGraphic;
        }

        public Point GetNodePoint()
        {
            return this.nodePoint;
        }

        public void DrawNode()
        {
            Point nodePoint = GetNodePoint();
            Pen p = new Pen(Color.Green, 2);
            Rectangle rec = new Rectangle(nodePoint.X, nodePoint.Y, 50, 50);
            this.nodeGraphic.DrawEllipse(p, rec);
            DrawNodeValue();
        }

        public void DrawNodeValue()
        {
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            String drawNodeValue = Convert.ToString(nodeNum);

            if (nodeNum < 10)
            {
                nodeGraphic.DrawString(drawNodeValue, drawFont, drawBrush, this.nodePoint.X + 15, this.nodePoint.Y + 15);
            }

            else
            {
                nodeGraphic.DrawString(drawNodeValue, drawFont, drawBrush, this.nodePoint.X + 10, this.nodePoint.Y + 15);
            }
        }

    }
}
