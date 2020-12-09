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
        int nodeValue = 0;
        List<Node> nodeList = new List<Node>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Point GetNodePoint()
        {
            Point nodePoint = PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));
            return nodePoint;
        }

        private void BgClick(object sender, EventArgs e)
        {
            Node node = new Node(nodeValue, GetNodePoint(), CreateGraphics());
            nodeList.Add(node);
            nodeValue++;
            node.DrawNode();

            //좌표값 살아있는 테스트
            for (int i = 0; i < nodeValue; i++)
            {
                Console.WriteLine("{0}", nodeList[i].GetNodePoint());
            }
            Console.WriteLine();
        }
    }
}

