using System.DirectoryServices;
using System.Drawing.Drawing2D;
namespace Pencil
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            _bufGraphCont = BufferedGraphicsManager.Current;
            _bufGraph = _bufGraphCont.Allocate(this.CreateGraphics(), this.ClientRectangle);
            _bufGraph.Graphics.Clear(Color.White);
            _bufGraph.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
        private List<Shape> _listShape = new List<Shape>();
        private Shape _tempShape = null;
        private DrawType _drawType = DrawType.Line;

        BufferedGraphicsContext _bufGraphCont = null;
        BufferedGraphics _bufGraph = null;
        private int _drawWidth = 10;
        private Color _drawColor = Color.Red;
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (_drawType != DrawType.Stop)
            {
                if (_drawType == DrawType.Line)
                {
                    _tempShape = new Line();
                    ((Line)_tempShape)._P1 = new Point(e.X, e.Y);
                }
                else if (_drawType == DrawType.Rectangle)
                {
                    _tempShape = new Rectangle();
                    ((Rectangle)_tempShape)._P1 = new Point(e.X, e.Y);
                }
                else if (_drawType == DrawType.Circle)
                {
                    _tempShape = new Circle();
                    ((Circle)_tempShape)._PCenter = new Point(e.X, e.Y);
                }
                _tempShape._PenWidth = _drawWidth;
                _tempShape._PenColor = _drawColor;
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (_drawType != DrawType.Stop)
            {
                if (_drawType == DrawType.Line)
                {
                    ((Line)_tempShape)._P2 = new Point(e.X, e.Y);
                }
                else if (_drawType == DrawType.Rectangle)
                {
                    ((Rectangle)_tempShape)._P2 = new Point(e.X, e.Y);
                }
                else if (_drawType == DrawType.Circle)
                {
                    int tx = ((Circle)_tempShape)._PCenter.X;
                    int ty = ((Circle)_tempShape)._PCenter.Y;
                    ((Circle)_tempShape)._R = (float)Math.Sqrt(Math.Pow(e.X - tx, 2) + Math.Pow(e.Y - ty, 2));
                }
                _listShape.Add(_tempShape);
                _tempShape.Draw(_bufGraph.Graphics, DashStyle.Solid);
                _bufGraph.Render(this.CreateGraphics());
            }
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape tempShape in _listShape)
            {
                tempShape.Draw(_bufGraph.Graphics, DashStyle.Solid);
            }
            _bufGraph.Render(e.Graphics);
        }
        private void MenuItemLine_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Line;
        }
        private void MenuItemRectangle_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Rectangle;
        }
        private void MenuItemCircle_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Circle;
        }
        private void MenuItemStop_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Stop;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_drawType != DrawType.Stop)
                {

                    _bufGraph.Graphics.Clear(Color.White);
                    foreach (Shape shape in _listShape)
                    {
                        shape.Draw(_bufGraph.Graphics, DashStyle.Solid);
                    }
                    if (_drawType == DrawType.Line)
                    {
                        ((Line)_tempShape)._P2 = e.Location;
                    }
                    else if (_drawType == DrawType.Rectangle)
                    {
                        ((Rectangle)_tempShape)._P2 = e.Location;
                    }
                    else if (_drawType == DrawType.Circle)
                    {
                        int tx = ((Circle)_tempShape)._PCenter.X;
                        int ty = ((Circle)_tempShape)._PCenter.Y;
                        ((Circle)_tempShape)._R = (float)Math.Sqrt(Math.Pow(e.X - tx, 2) + Math.Pow(e.Y - ty, 2));
                    }
                    _tempShape.Draw(_bufGraph.Graphics, DashStyle.Dash);
                    _bufGraph.Render(this.CreateGraphics());
                }
            }
        }

        private void MenuItemWidth_Click(object sender, EventArgs e)
        {
            DigPenWidth digPenWidth = new DigPenWidth();
            digPenWidth.numericUpDownWidth.Value = _drawWidth;
            if(digPenWidth.ShowDialog(this) == DialogResult.OK)
            {
                _drawWidth = (int)digPenWidth.numericUpDownWidth.Value;
            }
        }

        private void MenuItemColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _drawColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _drawColor = colorDialog1.Color;
            }
        }
    }
}
