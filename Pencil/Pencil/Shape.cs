using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
namespace Pencil
{
    public enum DrawType
    {
        Stop = 0,Line = 1,Rectangle = 2, Circle = 3,
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
        public abstract void Draw(Graphics g, DashStyle ds);
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
        public override void Draw(Graphics g, DashStyle ds)
        {
            Pen pen = new Pen(_PenColor, _PenWidth);
            pen.DashStyle = ds;
            g.DrawLine(pen, _p1, _p2);
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
        public override void Draw(Graphics g, DashStyle ds)
        {
            Pen pen = new Pen(_PenColor, _PenWidth);
            pen .DashStyle = ds;
            Point lefttop = new Point();
            lefttop.X = _p1.X <= _p2.X ? _p1.X : _p2.X;
            lefttop.Y = _p1.Y <= _p2.Y ? _p1.Y : _p2.Y;
            g.DrawRectangle(pen, lefttop.X, lefttop.Y, Math.Abs(_p2.X-_p1.X), Math.Abs(_p2.Y-_p1.Y));
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
        public override void Draw(Graphics g, DashStyle ds)
        {
            Pen pen = new Pen(_PenColor, _PenWidth);
            pen.DashStyle = ds;
            g.DrawEllipse(pen, _pCenter.X-_r, _pCenter.Y-_r, _r*2, _r*2);
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
}
