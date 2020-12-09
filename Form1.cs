using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlgoSub2
{
    public partial class Form1 : Form
    {
        int flag;
        int toNodeSelect;
        int fromNodeSelect;
        int nodeNum = 0;
        List<Node> nodeList = new List<Node>();
        List<Edge> edgeList = new List<Edge>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromNodeSelect = startBox.SelectedIndex;
            //flag = 1;
        }

        //Dest에서 Edge를 생성하기. StartBox에서는 단순히 선택한 노드만 저장하기.
        private void DestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toNodeSelect = destBox.SelectedIndex;
            Edge edge = new Edge(nodeList[fromNodeSelect], nodeList[toNodeSelect], CreateGraphics());
            edgeList.Add(edge);
            edge.DrawEdge();
            //flag = 0;
        }

        public Point GetNodePoint()
        {
            Point nodePoint = PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));
            return nodePoint;
        }

        private void BgClick(object sender, EventArgs e)
        {
            
            Node node = new Node(nodeNum, GetNodePoint(), CreateGraphics());
            nodeList.Add(node);
            ComboBoxRefresh();
            nodeNum++;
            node.DrawNode();

            //좌표값 테스트
            for (int i = 0; i < nodeNum; i++)
            {
                Console.WriteLine("{0} : {1}",i, nodeList[i].GetNodePoint());
            }
            
            Console.WriteLine();
        }

        // ComboBox 노드 추가될 때 마다 내용추가.
        public void ComboBoxRefresh()
        {
            String drawNodeValue = Convert.ToString(nodeNum);
            startBox.Items.Add(drawNodeValue);
            destBox.Items.Add(drawNodeValue);
        }
 
    }
}

