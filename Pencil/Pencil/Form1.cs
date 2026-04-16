using System.DirectoryServices;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
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
        private List<Shape> _listTempShape = new List<Shape>();//用于保存临时图元以实现重做功能
        private Shape _tempShape = null;
        private DrawType _drawType = DrawType.Line;
        BufferedGraphicsContext _bufGraphCont = null;
        BufferedGraphics _bufGraph = null;
        private int _drawWidth = 10;
        private Color _drawColor = Color.Red;
        private string _filename = "";
        //是否需要保存的标记， true是false否
        private Boolean _saveFlag = false;
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
                //重置重做的功能
                _listTempShape.Clear();
                MenuItemRedo.Enabled = false;
            }
            MenuItemUndo.Enabled = true;
            _saveFlag = true;
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
            Cursor penCur = new Cursor("pencil.cur");
            this.Cursor = penCur;
            menuStrip1.Cursor = penCur;
            toolStrip1.Cursor = penCur;
            statusStrip1.Cursor = penCur;
            MenuItemUndo.Enabled = false;
            MenuItemRedo.Enabled = false;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabelPosition.Text = "鼠标: x=" + e.X.ToString() + ",y=" + e.Y.ToString();
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
            if (digPenWidth.ShowDialog(this) == DialogResult.OK)
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

        private void MenuItemUndo_Click(object sender, EventArgs e)
        {
            if (_listShape.Count > 0)
            {
                _listTempShape.Add(_listShape[_listShape.Count - 1]);//把最后一个先加进临时List
                _listShape.RemoveAt(_listShape.Count - 1);//删除最后的图元
                _bufGraph.Graphics.Clear(Color.White);
                //再次把图元绘制到缓冲区
                foreach (Shape shape in _listShape)
                {
                    shape.Draw(_bufGraph.Graphics, DashStyle.Solid);
                }
                _bufGraph.Render(this.CreateGraphics());//绘制到窗口
                //启动重做菜单
                MenuItemRedo.Enabled = true;
                toolStripButtonRedo.Enabled = true;
                if (_listShape.Count == 0)
                {
                    MenuItemUndo.Enabled = false;
                    toolStripButtonUndo.Enabled = false;
                }
                _saveFlag = true;
            }
        }

        private void MenuItemRedo_Click(object sender, EventArgs e)
        {
            if (_listTempShape.Count > 0)
            {
                //把临时表最后一个图元加入
                _listShape.Add(_listTempShape[_listTempShape.Count - 1]);
                //删除临时表最后一个图元
                _listTempShape.RemoveAt(_listTempShape.Count - 1);
                //再次刷新图像
                _bufGraph.Graphics.Clear(Color.White);
                foreach (Shape shape in _listShape)
                {
                    shape.Draw(_bufGraph.Graphics, DashStyle.Solid);
                }
                _bufGraph.Render(this.CreateGraphics());
                //判断是否需要启用重做
                if (_listTempShape.Count == 0)
                {
                    MenuItemRedo.Enabled = false;
                    toolStripButtonRedo.Enabled = false;
                }
                //启用撤销
                MenuItemUndo.Enabled = true;
                toolStripButtonUndo.Enabled = true;
                _saveFlag = true;
            }
        }

        //下面是修改画笔宽度的方法
        private void ToolStripMenuItem1px_Click(object sender, EventArgs e)
        {
            _drawWidth = 1;
        }

        private void ToolStripMenuItem2px_Click(object sender, EventArgs e)
        {
            _drawWidth = 2;
        }

        private void toolStripMenuItem4px_Click(object sender, EventArgs e)
        {
            _drawWidth = 4;
        }

        private void ToolStripMenuItem8px_Click(object sender, EventArgs e)
        {
            _drawWidth = 8;
        }

        private void ToolStripMenuItem_ClickRed(object sender, EventArgs e)
        {
            _drawColor = Color.Red;
        }

        private void ToolStripMenuItemGreen_Click(object sender, EventArgs e)
        {
            _drawColor = Color.Green;
        }

        private void ToolStripMenuItemYellow_Click(object sender, EventArgs e)
        {
            _drawColor = Color.Yellow;
        }

        private void ToolStripMenuItemBlue_Click(object sender, EventArgs e)
        {
            _drawColor = Color.Blue;
        }

        private void ToolStripMenuItemBlack_Click(object sender, EventArgs e)
        {
            _drawColor = Color.Black;
        }

        //新建
        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            //如果保存标记为true， 提示用户是否保存
            if (_saveFlag)
            {
                //弹出保存提示框
                if (MessageBox.Show("是否保存当前文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MenuItemSave_Click(null, null);
                }
            }
            //清空图元
            _listShape.Clear();
            _listTempShape.Clear();
            _bufGraph.Graphics.Clear(Color.White);
            _bufGraph.Render(this.CreateGraphics());
            //清空文件名
            _filename = "";
            this.Text = "画笔-无标题";
            //重置保存标记
            _saveFlag = false;
            //禁用按钮
            MenuItemRedo.Enabled = false;
            toolStripButtonRedo.Enabled = false;
            MenuItemUndo.Enabled = false;
            toolStripButtonUndo.Enabled = false;
        }

        private void MenuItemSaveas_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _filename = saveFileDialog1.FileName;
                this.Text = "画笔-" + _filename;
                //创建一个文件流对象，用于写入信息
                FileStream fs = new FileStream(_filename, FileMode.Create);
                //创建一个与文件流对象相对应的二进制写入流对象
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(_listShape.Count);
                foreach (Shape shape in _listShape)
                {
                    bw.Write(shape.GetType().ToString());
                    shape.Write(bw);
                }
                bw.Close();
                fs.Close();
                //重置保存标记
                _saveFlag = false;
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            //调用新建方法
            MenuItemNew_Click(null, null);
            //保存文件名
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _filename = openFileDialog1.FileName;
            }
            else return;
            //设置窗口标题
            this.Text = "画笔-" + _filename;
            //创建一个文件流对象用于读出图形信息
            FileStream fs = new FileStream(_filename, FileMode.Open, FileAccess.Read);
            //创建相应的二进制读入流对象
            BinaryReader br = new BinaryReader(fs);

            //读取图元数量
            int shapecnt = br.ReadInt32();
            //读取图元信息
            for (int i = 1; i <= shapecnt; i++)
            {
                //读取图元类型
                string ShapeType = br.ReadString();
                if (ShapeType == "Pencil.Line")
                {
                    Line shape = new Line();
                    shape.Read(br);
                    _listShape.Add(shape);
                }
                else if (ShapeType == "Pencil.Rectangle")
                {
                    Rectangle shape = new Rectangle();
                    shape.Read(br);
                    _listShape.Add(shape);
                }
                else if (ShapeType == "Pencil.Circle")
                {
                    Circle shape = new Circle();
                    shape.Read(br);
                    _listShape.Add(shape);
                }
                else
                {
                    MessageBox.Show("图元类型错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                br.Close();
                fs.Close();
                //设置保存标记为false
                _saveFlag = false;
                _bufGraph.Graphics.Clear(Color.White);
                foreach (Shape shape in _listShape)
                {
                    shape.Draw(_bufGraph.Graphics, DashStyle.Solid);
                }
                _bufGraph.Render(this.CreateGraphics());
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            //如果名字为空，需要设置名字
            if (_filename == "")
            {
                //显示文件保存对话框
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                    this.Text = "画笔-" + _filename;
                }
                else return;
            }
            FileStream fs = new FileStream(_filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            //写入图元数量
            bw.Write(_listShape.Count());
            //写入图元信息
            foreach (Shape shape in _listShape)
            {
                bw.Write(shape.GetType().ToString());
                shape.Write(bw);
            }
            bw.Close();
            fs.Close();
            //重置保存标记
            _saveFlag = false;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_saveFlag)
            {
                if (MessageBox.Show("是否保存当前文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MenuItemSave_Click(null, null);
                }
            }
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemSaveasPic_Click(object sender, EventArgs e)
        {
            if(saveFileDialog2.ShowDialog(this) == DialogResult.OK)
            {
                // 保存图片逻辑
                //创建一个 Bitmap 对象，大小与当前窗口相同
                Bitmap bitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
                //获取Graphics对象
                Graphics g = Graphics.FromImage(bitmap);
                _bufGraph.Render(g);
                //获取后缀
                string ext = Path.GetExtension(saveFileDialog2.FileName).ToLower();
                //根据后缀保存图片
                if (ext == ".jpg")
                {
                    bitmap.Save(saveFileDialog2.FileName, ImageFormat.Jpeg);

                }
                else if (ext == ".png")
                {
                    bitmap.Save(saveFileDialog2.FileName, ImageFormat.Png);
                }
                else if (ext == ".bmp")
                {
                    bitmap.Save(saveFileDialog2.FileName, ImageFormat.Bmp);
                }
                else if (ext == ".gif")
                {
                    bitmap.Save(saveFileDialog2.FileName, ImageFormat.Gif);
                }
                else
                {
                    MessageBox.Show("不支持的图片格式。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
