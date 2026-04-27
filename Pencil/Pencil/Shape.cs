using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace Pencil
{
    public enum DrawType
    {
        Stop = 0,Line = 1,Rectangle = 2, Circle = 3, Sketch = 4,
    }
    public abstract class Shape
    {
        private int _penWidth = 10;
        private Color _penColor = Color.Red;
        public int _PenWidth
        {
            get { return _penWidth; }
            set { _penWidth = value; }
        }
        public Color _PenColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }
        //绘制图元方法
        public abstract void Draw(Graphics g, DashStyle ds, double zoomRatio);
        //写入文件方法
        public abstract void Write(BinaryWriter bw);
        //读取文件方法
        public abstract void Read(BinaryReader br);
    }
    public class  Line : Shape
    {
        private Point _p1;
        private Point _p2;
        public Point _P1
        {
            get { return _p1; }
            set { _p1 = value; }
        }
        public Point _P2
        {
            get { return _p2;}
            set { _p2 = value; }
        }
        public Line() {

        }
        public Line(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen pen = new Pen(_PenColor, (int)(_PenWidth*zoomRatio));
            pen.DashStyle = ds;
            Point p1 = new Point((int)(_p1.X*zoomRatio), (int)(_p1.Y*zoomRatio));
            Point p2 = new Point((int)(_p2.X*zoomRatio), (int)(_p2.Y*zoomRatio));
            g.DrawLine(pen, p1, p2);
        }
        public override void Write(BinaryWriter bw)
        {
            bw.Write(_PenWidth);
            bw.Write(_PenColor.ToArgb());
            bw.Write(_P1.X);
            bw.Write(_P1.Y);
            bw.Write(_P2.X);
            bw.Write(_P2.Y);
        }
        public override void Read(BinaryReader br)
        {
            _PenWidth = br.ReadInt32();
            _PenColor = Color.FromArgb(br.ReadInt32());
            _p1.X = br.ReadInt32();
            _p1.Y = br.ReadInt32();
            _p2.X = br.ReadInt32();
            _p2.Y = br.ReadInt32();
        }
    }
    public class Rectangle : Shape
    {
        private Point _p1;
        private Point _p2;
        public Point _P1
        {
            get{ return _p1; }
            set{ _p1 = value; }
        }
        public Point _P2
        {
            get { return _p2;}
            set { _p2 = value; }
        }
        public Rectangle() { 
        
        }
        public Rectangle(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen pen = new Pen(_PenColor, (int)(_PenWidth * zoomRatio));
            pen .DashStyle = ds;
            Point p1 = new Point((int)(_p1.X * zoomRatio), (int)(_p1.Y * zoomRatio));
            Point p2 = new Point((int)(_p2.X*zoomRatio), (int)((_p2.Y*zoomRatio)));
            Point lefttop = new Point();
            lefttop.X = p1.X <= p2.X ? p1.X : p2.X;
            lefttop.Y = p1.Y <= p2.Y ? p1.Y : p2.Y;
            g.DrawRectangle(pen, lefttop.X, lefttop.Y, Math.Abs(p2.X-p1.X), Math.Abs(p2.Y-p1.Y));
        }
        public override void Write(BinaryWriter bw)
        {
            bw.Write(_PenWidth);
            bw.Write(_PenColor.ToArgb());
            bw.Write(_P1.X);
            bw.Write(_P1.Y);
            bw.Write(_P2.X);
            bw.Write(_P2.Y);
        }
        public override void Read(BinaryReader br)
        {
            _PenWidth = br.ReadInt32();
            _PenColor = Color.FromArgb(br.ReadInt32());
            _p1.X = br.ReadInt32();
            _p1.Y = br.ReadInt32();
            _p2.X = br.ReadInt32();
            _p2.Y = br.ReadInt32();
        }
    }
    public class Circle : Shape
    {
        private Point _pCenter;
        private float _r;
        public Point _PCenter
        {
            get { return _pCenter; }
            set { _pCenter = value; }
        }
        public float _R
        {
            get { return _r; }
            set { _r =  value; }
        }
        public Circle() { 
        }
        public Circle(Point pCener, float r) { 
            _pCenter = pCener;
            _r = r;
        }
        public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen pen = new Pen(_PenColor, (int)(_PenWidth * zoomRatio));
            pen.DashStyle = ds;
            Point pCenter = new Point((int)(_pCenter.X*zoomRatio), (int)(_pCenter.Y*zoomRatio));
            float r = (float)_r*(float)zoomRatio;
            g.DrawEllipse(pen, pCenter.X-r, pCenter.Y-r, r*2, r*2);
        }
        public override void Write(BinaryWriter bw)
        {
            bw.Write(_PenWidth);
            bw.Write(_PenColor.ToArgb());
            bw.Write(_PCenter.X);
            bw.Write(_PCenter.Y);
            bw.Write(_R);
        }
        public override void Read(BinaryReader br)
        {
            _PenWidth = br.ReadInt32();
            _PenColor = Color.FromArgb(br.ReadInt32());
            _pCenter.X = br.ReadInt32();
            _pCenter.Y = br.ReadInt32();
            _r = br.ReadSingle();
        }
    }
    public class Sketch : Shape
    {
        private List<Point> _pointList = new List<Point>();
        public List<Point> _PointList
        {
            get { return _pointList; }
            set { _pointList = value; }
        }
        public Sketch() { }
        public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen pen = new Pen(_PenColor, (int)(_PenWidth * zoomRatio));
            pen.DashStyle = ds;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            //遍历点来绘制所有直线段
            for (int i = 1; i < _pointList.Count - 1; ++i)
            {
                Point p1 = new Point((int)(_pointList[i - 1].X * zoomRatio), (int)(_pointList[i - 1].Y * zoomRatio));
                Point p2 = new Point((int)(_pointList[i].X * zoomRatio), (int)(_pointList[i].Y * zoomRatio));
                g.DrawLine(pen, p1, p2);
            }
        }
        public override void Write(BinaryWriter bw)
        {
            bw.Write(_PenWidth);
            bw.Write(_PenColor.ToArgb());

            //写入点总数
            bw.Write(_pointList.Count);
            //逐一写入点坐标
            foreach (Point p in _pointList) { 
                bw.Write(p.X);
                bw.Write(p.Y);
            }
            
        }
        public override void Read(BinaryReader br)
        {
            _pointList.Clear();
            _PenWidth = br.ReadInt32();
            _PenColor = Color.FromArgb(br.ReadInt32());

            int pcnt = br.ReadInt32();
            for (int i = 0; i < pcnt; ++i) { 
                int x = br.ReadInt32();
                int y = br.ReadInt32();
                Point point = new Point(x, y);
                _PointList.Add(point);
            }
        }
    }
}
