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
        //int flag = 0;
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
            Panel primPanel = new Panel();
            Panel kruPanel = new Panel();
            Label primlabel = new Label();
            Label kruLabel = new Label();

            // Initialize the Panel control.
            primPanel.Location = new Point(0, 650);
            primPanel.Size = new Size(750, 350);

            kruPanel.Location = new Point(750, 650);
            kruPanel.Size = new Size(750, 350);

            // Set the Borderstyle for the Panel to three-dimensional.
            primPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            kruPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.
            primlabel.Location = new Point(0, 0);
            primlabel.Text = "Prim";
            primlabel.Size = new Size(104, 16);

            kruLabel.Location = new Point(0, 0);
            kruLabel.Text = "Kruscal";
            kruLabel.Size = new Size(104, 16);

            // Add the Panel control to the form.
            //this.Controls.Add(primPanel);
            //this.Controls.Add(kruPanel);

            // Add the Label and TextBox controls to the Panel.
            primPanel.Controls.Add(primlabel);
            kruPanel.Controls.Add(kruLabel);
        }

        /// <summary>
        /// StartBox의 인덱스가 선택될 때, FromNodeSelect의 값이 선택된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromNodeSelect = startBox.SelectedIndex;
        }

        /// <summary>
        /// DestBox의 인덱스가 선택될 때, toNodeSelect의 값이 선택된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toNodeSelect = destBox.SelectedIndex;
        }

        /// <summary>
        /// AddEdge가 실행될 때, Edge클래스의 객체를 하나 생성한다. 객체가 생성되면 간선과 가중치를 그린다.
        /// </summary>
        /// <param name="weight"></param>
        public void AddEdge(int weight)
        {
            Edge edge = new Edge(nodeList[fromNodeSelect], nodeList[toNodeSelect], CreateGraphics(), weight);
            edgeList.Add(edge);
            edge.DrawEdge();
        }

        /// <summary>
        /// 입력버튼이 눌릴 때, TextBox에 가중치값을 가져오고, AddEdge()메소드를 호출한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightInputBox_Button(object sender, EventArgs e)
        {
            int weight = Int16.Parse(WeightInputBox.Text);
            AddEdge(weight);
            //입력버튼 누르면 ComboBox에 표시된 내용 지우기.
            //startBox.SelectedIndex = -1;
            startBox.Text = "";
            destBox.Text = "";
            WeightInputBox.Text = "";
        }

        public Point GetNodePoint()
        {
            Point nodePoint = PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));
            return nodePoint;
        }

        /// <summary>
        /// 화면을 클릭 시 화면에 노드가 그려집니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgClick(object sender, EventArgs e)
        {
            
            Node node = new Node(nodeNum, GetNodePoint(), CreateGraphics());
            nodeList.Add(node);
            ComboBoxRefresh();
            nodeNum++;
            node.DrawNode();
            
            //startBox.Refresh();

            //좌표값 테스트
            for (int i = 0; i < nodeNum; i++)
            {
                Console.WriteLine("{0} : {1}",i, nodeList[i].GetNodePoint());
            }


            
            Console.WriteLine();
        }

        /// <summary>
        /// 노드가 추가될 때 마다 ComboBox에 내용이 추가됩니다.
        /// </summary>
        public void ComboBoxRefresh()
        {
            String drawNodeValue = Convert.ToString(nodeNum);
            startBox.Items.Add(drawNodeValue);
            destBox.Items.Add(drawNodeValue);
        }

        private void WeightInput(object sender, EventArgs e)
        {

        }

        //크루스칼 영역
        public void kruscal() //Panel krupanel
        {
            List<Edge> sortedEdgeList = edgeList.OrderBy(x => x.weight).ToList();
            List<Edge> kruscalEdgeList = new List<Edge>();
            int nodeListSize = nodeList.Count;

            // 각 정점이 포함된 그래프가 어디인지 저장.
            int[] set = new int[nodeListSize];
            for (int i = 0; i < nodeListSize; i++)
            {
                set[i] = i;
            }

            int edgeListSize = edgeList.Count;
            int sum = 0;
            for (int i = 0; i < edgeListSize; i++)
            {
                //노드2개 ,간선 1개 이어졌는데 간선2번째꺼를 찾으니까 어레이 초과가 일어나지.for문 수정하자.
                if (!find(set, sortedEdgeList[i].fromNode.nodeNum, sortedEdgeList[i].toNode.nodeNum))
                {
                    sum += sortedEdgeList[i].weight;
                    unionParent(set, sortedEdgeList[i].fromNode.nodeNum, sortedEdgeList[i].toNode.nodeNum);
                    kruscalEdgeList.Add(sortedEdgeList[i]);
                }
            }
            

            Console.WriteLine(sum);
            Graphics g = CreateGraphics();
            g.Clear(BackColor);

            for (int i = 0; i < kruscalEdgeList.Count; i++)
            {
                kruscalEdgeList[i].DrawEdge();
            }

            for (int i = 0; i < nodeList.Count; i++)
            {
                nodeList[i].DrawNode();
            }
        }

        public int getParent(int[] set, int x)
        {
            if (set[x] == x) return x;
            return set[x] = getParent(set, set[x]);
        }

        public void unionParent(int[] set, int a, int b)
        {
            a = getParent(set, a);
            b = getParent(set, b);

            if (a < b) set[b] = a;
            else set[a] = b;
        }

        public bool find(int[] set, int a, int b)
        {
            a = getParent(set, a);
            b = getParent(set, b);
            if (a == b) return true;
            else return false;
        }

        private void kruButton_Click(object sender, EventArgs e)
        {
            kruscal();
        }
        

        //------------------------------------------
        private void kruMiddleButton_Click(object sender, EventArgs e)
        {
            kruscalMiddle();
        }

        public void kruscalMiddle() //Panel krupanel
        {
            List<Edge> sortedEdgeList = edgeList.OrderBy(x => x.weight).ToList();
            List<Edge> kruscalEdgeList = new List<Edge>();
            int nodeListSize = nodeList.Count;

            // 각 정점이 포함된 그래프가 어디인지 저장.
            int[] set = new int[nodeListSize];
            for (int i = 0; i < nodeListSize; i++)
            {
                set[i] = i;
            }

            int edgeListSize = edgeList.Count;
            int sum = 0;
            for (int i = 0; i < edgeListSize; i++)
            {
                //노드2개 ,간선 1개 이어졌는데 간선2번째꺼를 찾으니까 어레이 초과가 일어나지.for문 수정하자.
                if (!find(set, sortedEdgeList[i].fromNode.nodeNum, sortedEdgeList[i].toNode.nodeNum))
                {
                    sum += sortedEdgeList[i].weight;
                    unionParent(set, sortedEdgeList[i].fromNode.nodeNum, sortedEdgeList[i].toNode.nodeNum);
                    kruscalEdgeList.Add(sortedEdgeList[i]);
                }
            }


            Console.WriteLine(sum);
            Graphics g = CreateGraphics();
            g.Clear(BackColor);

            for (int i = 0; i < kruscalEdgeList.Count / 2; i++)
            {
                kruscalEdgeList[i].DrawEdge();
            }

            for (int i = 0; i < nodeList.Count; i++)
            {
                nodeList[i].DrawNode();
            }
        }
    }
}

