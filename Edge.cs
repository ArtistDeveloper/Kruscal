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
        int weight;
        Graphics EdgeGraphic;

        public Edge(Node fromNode, Node toNode, Graphics EdgeGraphic, int weight)
        {
            this.fromNode = fromNode;
            this.toNode = toNode;
            this.EdgeGraphic = EdgeGraphic;
            this.weight = weight;
        }

        //TODO : 간선이 노드밑에 그려지도록 하기.
        public void DrawEdge()
        {
            Pen p = new Pen(Color.Black, 2);
            int x1, x2, y1, y2;
            //각 값에 +25가 된 것은 노드의 중간을 가리키기 위해서이다.
            x1 = fromNode.GetNodePoint().X+20; //TODO : + 25
            y1 = fromNode.GetNodePoint().Y+20;
            x2 = toNode.GetNodePoint().X+20;
            y2 = toNode.GetNodePoint().Y+20;

            //EdgeGraphic.DrawLine(p, fromNode.GetNodePoint(), toNode.GetNodePoint());

            //노드중심부터 노드중심까지 선을 긋는다.
            EdgeGraphic.DrawLine(p, x1, y1, x2, y2);

            //x1,y1은 노드 중심의 좌표이다. (간선의 종착점이기도 하기에, 간선의 끝과 끝의 좌표가 매개변수로 호출된다.)
            DrawEdgeWeight(x1, y1, x2, y2);
        }

        /// <summary>
        /// 간선의 가중치를 그린다.
        /// </summary>
        /// <param name="x1">시작노드 x좌표</param>
        /// <param name="y1">시작노드 y좌표</param>
        /// <param name="x2">도착노드 x좌표</param>
        /// <param name="y2">도착노드 y좌표</param>
        public void DrawEdgeWeight(int x1, int y1, int x2, int y2)
        {
            int positionX = x2 - x1;
            int positionY = y2 - y1;
            float fx1 = (float)x1;
            float fy1 = (float)y1;
            float fx2 = (float)x2;
            float fy2 = (float)y2;


            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //Edge에 포함된 가중치를 string으로 형변환.
            String drawEdgeValue = Convert.ToString(weight);

            //TODO : 간선의 도착노드지점을 기준으로 가중치 그리기.
            //시작 노드 좌표에서 도착 노드좌표가 -, -이면 다른 위치에 그린다. 이런 식으로 예외처리를 해야하나?
            //+,+ 인 경우.
            if (positionX > 0 && positionY > 0)
            {
                //EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, x2 - 35, y2 + 5);
                EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, fx1 + ((fx2 - fx1) / 1.5f), y2 - ((fy2 - fy1) / 5f));
            }
            // +, -인 경우.
            else if (positionX > 0 && positionY < 0)
            {
                //EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, x2 - 35, y2 + 5);
                EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, fx1 + ((fx2 - fx1) / 1.3f), fy1 - ((fy1 - fy2) / 1.3f));
            }
            // -, -인 경우
            else if(positionX < 0 && positionY < 0)
            {
                EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, fx2 + ((fx1 - fx2) / 4f), fy1 - ((fy1 - fy2) / 1.7f));
            }
            // -, +인 경우
            else if(positionX < 0 && positionY > 0)
            {
                //EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, x2 - 35, y2 + 5);
                EdgeGraphic.DrawString(drawEdgeValue, drawFont, drawBrush, fx2 + ((fx1 - fx2) / 4f), y2 - ((fy2 - fy1) / 4f));
            }
        }
    }
}


