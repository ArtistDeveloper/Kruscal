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
            Panel panel1 = new Panel();
            Panel panel2 = new Panel();
            Label label1 = new Label();
            Label label2 = new Label();

            // Initialize the Panel control.
            panel1.Location = new Point(0, 650);
            panel1.Size = new Size(750, 350);

            panel2.Location = new Point(750, 650);
            panel2.Size = new Size(750, 350);

            // Set the Borderstyle for the Panel to three-dimensional.
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.
            label1.Location = new Point(0, 0);
            label1.Text = "Prim";
            label1.Size = new Size(104, 16);

            label2.Location = new Point(0, 0);
            label2.Text = "Kruscal";
            label2.Size = new Size(104, 16);

            // Add the Panel control to the form.
            this.Controls.Add(panel1);
            this.Controls.Add(panel2);

            // Add the Label and TextBox controls to the Panel.
            panel1.Controls.Add(label1);
            panel2.Controls.Add(label2);
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
    }
}

