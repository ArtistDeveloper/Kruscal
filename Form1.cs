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
        int nodevalue = 0;

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

        private void BgClick(object sender, EventArgs e)
        {
            DrawNode();
        }

        public Point GetNodePoint()
        {
            Point nodePoint = PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));
            return nodePoint;
        }

        public void DrawNode()
        {
            Point nodePoint = GetNodePoint();
            Graphics nodeGraphic = CreateGraphics();
            Pen p = new Pen(Color.Green, 2);

            Rectangle rec = new Rectangle(nodePoint.X, nodePoint.Y, 50, 50);
            nodeGraphic.DrawEllipse(p, rec);
            DrawNodeValue();
        }

        public void DrawNodeValue()
        {
            Graphics valueGraphics = CreateGraphics();
            Point nodePoint = GetNodePoint();

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            String drawNodeValue = Convert.ToString(nodevalue);
            nodevalue++;

            valueGraphics.DrawString(drawNodeValue, drawFont, drawBrush, nodePoint.X+15, nodePoint.Y+15);
            
        }
    }
}

