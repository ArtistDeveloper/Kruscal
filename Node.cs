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
        public int nodeNum; //객체가 가지고 있는 각자의 노드 값.
        private Point nodePoint;
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

        public void SetNodePointX(int x)
        {
            Point point = new Point();
            point.X += x;
            point.Y = this.nodePoint.Y;

            this.nodePoint = point;
        }

        public void DrawNode()
        {
            Point nodePoint = GetNodePoint();
            Pen p = new Pen(Color.Green, 2);
            Rectangle rec = new Rectangle(nodePoint.X, nodePoint.Y, 40, 40); //TODO : 50 50
            this.nodeGraphic.DrawEllipse(p, rec);
            DrawNodeValue();
        }

        public void DrawNodeValue()
        {
            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            String drawNodeValue = Convert.ToString(nodeNum); //nodeNum을 통해 그려지는 노드밸류 값으로 형변환.

            // node의 값이 10이하일 때 글씨좌표를 맞게 출력
            if (nodeNum < 10)
            {
                nodeGraphic.DrawString(drawNodeValue, drawFont, drawBrush, this.nodePoint.X + 13, this.nodePoint.Y + 11);
            }

            // node의 값이 10이상일 때 글씨좌표를 맞게 출력
            else
            {
                nodeGraphic.DrawString(drawNodeValue, drawFont, drawBrush, this.nodePoint.X + 8, this.nodePoint.Y + 11);
            }
        }

    }
}
