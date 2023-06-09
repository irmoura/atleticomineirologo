using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AtleticoMineiroLogo
{
    public partial class Form1 : Form
    {

        private Graphics graphics = null;
        private int centralHorizontalLine;
        private int centralVerticalLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralHorizontalLine = (this.Width / 2) - 8;
            centralVerticalLine = (this.Height / 2) - 7;
            //
            graphics = this.CreateGraphics();
            //
            //DrawHorizontalLine(Color.Red, 0, centralHorizontalLine, centralVerticalLine);//X
            //DrawVerticalLine(Color.Red, centralHorizontalLine, 0, this.Height);//Y
            //
            GraphicsPath graphicsPath = new GraphicsPath();
            //
            DrawCircle(centralHorizontalLine - 145, centralVerticalLine - 284, 395, Color.White);
            DrawCircle(centralHorizontalLine + 145, centralVerticalLine - 284, 395, Color.White);
            //
            DrawCircle2(centralHorizontalLine - 145, centralVerticalLine - 48, 770, Color.White);
            DrawCircle2(centralHorizontalLine + 145, centralVerticalLine - 48, 770, Color.White);
            //
            //LINHAS HORIZONTAL DO ESCUDO
            DrawHorizontalLine(Color.White, centralHorizontalLine - 185, centralHorizontalLine, centralVerticalLine + 20, 12);//X
            DrawHorizontalLine(Color.White, centralHorizontalLine + 185, centralHorizontalLine, centralVerticalLine + 20, 12);//X
            //LINHAS VERTICAIS DO ESCUDO
            DrawVerticalLine(Color.White, centralHorizontalLine - 37, centralVerticalLine + 20, centralVerticalLine + 275, 12);//Y
            DrawVerticalLine(Color.White, centralHorizontalLine + 37, centralVerticalLine + 20, centralVerticalLine + 275, 12);//Y
            DrawVerticalLine(Color.White, centralHorizontalLine - 108, centralVerticalLine + 20, centralVerticalLine + 204, 12);//Y
            DrawVerticalLine(Color.White, centralHorizontalLine + 108, centralVerticalLine + 20, centralVerticalLine + 204, 12);//Y
            //HIDE THINGS
            List<Point> pointList = new List<Point>();
            pointList.Add(new Point(centralHorizontalLine, centralVerticalLine + 303));
            pointList.Add(new Point(centralHorizontalLine - 350, centralVerticalLine + 140));
            pointList.Add(new Point(centralHorizontalLine - 193, centralVerticalLine - 90));
            pointList.Add(new Point(centralHorizontalLine - 193, centralVerticalLine - 95));
            pointList.Add(new Point(centralHorizontalLine, centralVerticalLine - 153));
            pointList.Add(new Point(centralHorizontalLine, 0));
            pointList.Add(new Point(0, 0));
            pointList.Add(new Point(0, this.Height));
            pointList.Add(new Point(centralHorizontalLine - 220, centralVerticalLine + 345));
            pointList.Add(new Point(centralHorizontalLine, centralVerticalLine + 345));
            //
            graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(pointList.ToArray());
            //
            graphics.FillPath(Brushes.Black, graphicsPath);
            //
            //HIDE THINGS RIGHT SIDE
            List<Point> pointListR = new List<Point>();
            pointListR.Add(new Point(centralHorizontalLine, centralVerticalLine + 303));
            pointListR.Add(new Point(centralHorizontalLine + 350, centralVerticalLine + 140));
            pointListR.Add(new Point(centralHorizontalLine + 193, centralVerticalLine - 90));
            pointListR.Add(new Point(centralHorizontalLine + 193, centralVerticalLine - 95));
            pointListR.Add(new Point(centralHorizontalLine, centralVerticalLine - 153));
            pointListR.Add(new Point(centralHorizontalLine, 0));
            pointListR.Add(new Point(this.Width, 0));
            pointListR.Add(new Point(this.Width, this.Height));
            pointListR.Add(new Point(centralHorizontalLine + 220, centralVerticalLine + 345));
            pointListR.Add(new Point(centralHorizontalLine, centralVerticalLine + 345));
            //
            graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(pointListR.ToArray());
            //
            graphics.FillPath(Brushes.Black, graphicsPath);
            //
            //STAR
            graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine, centralVerticalLine - 225),
                new PointF(centralHorizontalLine - 38,  centralVerticalLine - 202),
                new PointF(centralHorizontalLine - 29,  centralVerticalLine - 245),
                new PointF(centralHorizontalLine - 59,  centralVerticalLine - 272),
                new PointF(centralHorizontalLine - 18,  centralVerticalLine - 277),
                new PointF(centralHorizontalLine,  centralVerticalLine - 315),
                new PointF(centralHorizontalLine + 18,  centralVerticalLine - 277),
                new PointF(centralHorizontalLine + 59,  centralVerticalLine - 272),
                new PointF(centralHorizontalLine + 29,  centralVerticalLine - 245),
                new PointF(centralHorizontalLine + 38,  centralVerticalLine - 202),
            });
            //
            graphics.FillPath(new SolidBrush(Color.FromArgb(255, 211, 0)), graphicsPath);
            //
            // Define a fonte e o tamanho do texto
            Font font = new Font("Arial Black", 75, FontStyle.Bold);

            // Define a cor do texto
            Color textColor = Color.White;
            //
            graphics.DrawString($"C A M", font, new SolidBrush(textColor), centralHorizontalLine - 170, centralVerticalLine - 110);
        }

        private void DrawHorizontalLine(Color color, int x1, int x2, int y, int size = 2)
        {
            graphics.DrawLine(new Pen(new SolidBrush(color), size), x1, y, x2, y);
        }

        private void DrawVerticalLine(Color color, int x, int y1, int y2, int size = 2)
        {
            graphics.DrawLine(new Pen(new SolidBrush(color), size), x, y1, x, y2);
        }

        private void FillCircle(int x, int y, int size, Color color)
        {
            Rectangle rectangle = new Rectangle((x - (size / 2)), y - (size / 2), size, size);
            graphics.FillEllipse(new SolidBrush(color), rectangle);
        }

        private void DrawCircle(int x, int y, int size, Color color)
        {
            Rectangle rectangle = new Rectangle((x - (size / 2)), y - (size / 2), size, size);
            graphics.DrawEllipse(new Pen(new SolidBrush(color), 10), rectangle);
        }

        private void DrawCircle2(int x, int y, int size, Color color)
        {
            Rectangle rectangle = new Rectangle((x - (size / 2)) + 50, y - (size / 2), size - 100, size);
            graphics.DrawEllipse(new Pen(new SolidBrush(color), 10), rectangle);
        }
    }
}
