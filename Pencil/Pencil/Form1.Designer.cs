namespace Pencil
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            MenuItemFile = new ToolStripMenuItem();
            MenuItemNew = new ToolStripMenuItem();
            MenuItemOpen = new ToolStripMenuItem();
            MenuItemSave = new ToolStripMenuItem();
            MenuItemSaveas = new ToolStripMenuItem();
            MenuItemSaveasPic = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            MenuItemClose = new ToolStripMenuItem();
            MenuItemDrawing = new ToolStripMenuItem();
            MenuItemLine = new ToolStripMenuItem();
            MenuItemRectangle = new ToolStripMenuItem();
            MenuItemCircle = new ToolStripMenuItem();
            MenuItemSketch = new ToolStripMenuItem();
            MenuItemStop = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MenuItemUndo = new ToolStripMenuItem();
            MenuItemRedo = new ToolStripMenuItem();
            MenuItemSetting = new ToolStripMenuItem();
            MenuItemWidth = new ToolStripMenuItem();
            MenuItemColor = new ToolStripMenuItem();
            查看ToolStripMenuItem = new ToolStripMenuItem();
            MenuItemZoomIn = new ToolStripMenuItem();
            MenuItemZoomOut = new ToolStripMenuItem();
            其它ToolStripMenuItem = new ToolStripMenuItem();
            MenuItemScreenPen = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            toolStripButtonLine = new ToolStripButton();
            toolStripButtonRectangle = new ToolStripButton();
            toolStripButtonCircle = new ToolStripButton();
            toolStripButtonSketch = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonUndo = new ToolStripButton();
            toolStripButtonRedo = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonWidth = new ToolStripSplitButton();
            ToolStripMenuItem1px = new ToolStripMenuItem();
            ToolStripMenuItem2px = new ToolStripMenuItem();
            toolStripMenuItem4px = new ToolStripMenuItem();
            ToolStripMenuItem8px = new ToolStripMenuItem();
            toolStripSplitButtonColor = new ToolStripSplitButton();
            ToolStripMenuItemRed = new ToolStripMenuItem();
            ToolStripMenuItemGreen = new ToolStripMenuItem();
            ToolStripMenuItemYellow = new ToolStripMenuItem();
            ToolStripMenuItemBlue = new ToolStripMenuItem();
            ToolStripMenuItemBlack = new ToolStripMenuItem();
            toolStripButtonZoomIn = new ToolStripButton();
            toolStripButtoZoomOut = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            StatusLabelPosition = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            panelContainer = new Panel();
            panelDraw = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemFile, MenuItemDrawing, MenuItemSetting, 查看ToolStripMenuItem, 其它ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1228, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            MenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { MenuItemNew, MenuItemOpen, MenuItemSave, MenuItemSaveas, MenuItemSaveasPic, toolStripMenuItem3, MenuItemClose });
            MenuItemFile.Name = "MenuItemFile";
            MenuItemFile.Size = new Size(62, 28);
            MenuItemFile.Text = "文件";
            // 
            // MenuItemNew
            // 
            MenuItemNew.Image = (Image)resources.GetObject("MenuItemNew.Image");
            MenuItemNew.Name = "MenuItemNew";
            MenuItemNew.ShortcutKeys = Keys.Control | Keys.N;
            MenuItemNew.Size = new Size(215, 34);
            MenuItemNew.Text = "新建";
            MenuItemNew.Click += MenuItemNew_Click;
            // 
            // MenuItemOpen
            // 
            MenuItemOpen.Image = (Image)resources.GetObject("MenuItemOpen.Image");
            MenuItemOpen.Name = "MenuItemOpen";
            MenuItemOpen.ShortcutKeys = Keys.Control | Keys.O;
            MenuItemOpen.Size = new Size(215, 34);
            MenuItemOpen.Text = "打开";
            MenuItemOpen.Click += MenuItemOpen_Click;
            // 
            // MenuItemSave
            // 
            MenuItemSave.Image = (Image)resources.GetObject("MenuItemSave.Image");
            MenuItemSave.Name = "MenuItemSave";
            MenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            MenuItemSave.Size = new Size(215, 34);
            MenuItemSave.Text = "保存";
            MenuItemSave.Click += MenuItemSave_Click;
            // 
            // MenuItemSaveas
            // 
            MenuItemSaveas.Name = "MenuItemSaveas";
            MenuItemSaveas.Size = new Size(215, 34);
            MenuItemSaveas.Text = "另存为";
            MenuItemSaveas.Click += MenuItemSaveas_Click;
            // 
            // MenuItemSaveasPic
            // 
            MenuItemSaveasPic.Name = "MenuItemSaveasPic";
            MenuItemSaveasPic.Size = new Size(215, 34);
            MenuItemSaveasPic.Text = "另存为图片";
            MenuItemSaveasPic.Click += MenuItemSaveasPic_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(212, 6);
            // 
            // MenuItemClose
            // 
            MenuItemClose.Name = "MenuItemClose";
            MenuItemClose.ShortcutKeys = Keys.Control | Keys.C;
            MenuItemClose.Size = new Size(215, 34);
            MenuItemClose.Text = "关闭";
            MenuItemClose.Click += MenuItemClose_Click;
            // 
            // MenuItemDrawing
            // 
            MenuItemDrawing.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLine, MenuItemRectangle, MenuItemCircle, MenuItemSketch, MenuItemStop, toolStripMenuItem1, MenuItemUndo, MenuItemRedo });
            MenuItemDrawing.Name = "MenuItemDrawing";
            MenuItemDrawing.ShortcutKeys = Keys.Control | Keys.D;
            MenuItemDrawing.Size = new Size(62, 28);
            MenuItemDrawing.Text = "绘图";
            MenuItemDrawing.ToolTipText = "绘图";
            // 
            // MenuItemLine
            // 
            MenuItemLine.Image = (Image)resources.GetObject("MenuItemLine.Image");
            MenuItemLine.Name = "MenuItemLine";
            MenuItemLine.ShortcutKeys = Keys.Control | Keys.L;
            MenuItemLine.Size = new Size(229, 34);
            MenuItemLine.Text = "直线";
            MenuItemLine.ToolTipText = "绘制直线";
            MenuItemLine.Click += MenuItemLine_Click;
            // 
            // MenuItemRectangle
            // 
            MenuItemRectangle.Image = (Image)resources.GetObject("MenuItemRectangle.Image");
            MenuItemRectangle.Name = "MenuItemRectangle";
            MenuItemRectangle.ShortcutKeys = Keys.Control | Keys.R;
            MenuItemRectangle.Size = new Size(229, 34);
            MenuItemRectangle.Text = "矩形";
            MenuItemRectangle.ToolTipText = "绘制矩形";
            MenuItemRectangle.Click += MenuItemRectangle_Click;
            // 
            // MenuItemCircle
            // 
            MenuItemCircle.Image = (Image)resources.GetObject("MenuItemCircle.Image");
            MenuItemCircle.Name = "MenuItemCircle";
            MenuItemCircle.ShortcutKeys = Keys.Control | Keys.C;
            MenuItemCircle.Size = new Size(229, 34);
            MenuItemCircle.Text = "圆";
            MenuItemCircle.Click += MenuItemCircle_Click;
            // 
            // MenuItemSketch
            // 
            MenuItemSketch.Image = (Image)resources.GetObject("MenuItemSketch.Image");
            MenuItemSketch.Name = "MenuItemSketch";
            MenuItemSketch.ShortcutKeys = Keys.Control | Keys.K;
            MenuItemSketch.Size = new Size(229, 34);
            MenuItemSketch.Text = "徒手画";
            MenuItemSketch.Click += MenuItemSketch_Click;
            // 
            // MenuItemStop
            // 
            MenuItemStop.Image = (Image)resources.GetObject("MenuItemStop.Image");
            MenuItemStop.Name = "MenuItemStop";
            MenuItemStop.ShortcutKeys = Keys.Control | Keys.S;
            MenuItemStop.Size = new Size(229, 34);
            MenuItemStop.Text = "停止";
            MenuItemStop.Click += MenuItemStop_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(226, 6);
            // 
            // MenuItemUndo
            // 
            MenuItemUndo.Image = (Image)resources.GetObject("MenuItemUndo.Image");
            MenuItemUndo.Name = "MenuItemUndo";
            MenuItemUndo.ShortcutKeys = Keys.Control | Keys.Z;
            MenuItemUndo.Size = new Size(229, 34);
            MenuItemUndo.Text = "撤销";
            MenuItemUndo.ToolTipText = "撤销图元";
            MenuItemUndo.Click += MenuItemUndo_Click;
            // 
            // MenuItemRedo
            // 
            MenuItemRedo.Image = (Image)resources.GetObject("MenuItemRedo.Image");
            MenuItemRedo.Name = "MenuItemRedo";
            MenuItemRedo.ShortcutKeys = Keys.Control | Keys.X;
            MenuItemRedo.Size = new Size(229, 34);
            MenuItemRedo.Text = "重做";
            MenuItemRedo.ToolTipText = "重做图元";
            MenuItemRedo.Click += MenuItemRedo_Click;
            // 
            // MenuItemSetting
            // 
            MenuItemSetting.DropDownItems.AddRange(new ToolStripItem[] { MenuItemWidth, MenuItemColor });
            MenuItemSetting.Name = "MenuItemSetting";
            MenuItemSetting.Size = new Size(62, 28);
            MenuItemSetting.Text = "设置";
            // 
            // MenuItemWidth
            // 
            MenuItemWidth.Image = (Image)resources.GetObject("MenuItemWidth.Image");
            MenuItemWidth.Name = "MenuItemWidth";
            MenuItemWidth.Size = new Size(146, 34);
            MenuItemWidth.Text = "线宽";
            MenuItemWidth.ToolTipText = "设置线宽";
            MenuItemWidth.Click += MenuItemWidth_Click;
            // 
            // MenuItemColor
            // 
            MenuItemColor.Image = (Image)resources.GetObject("MenuItemColor.Image");
            MenuItemColor.Name = "MenuItemColor";
            MenuItemColor.Size = new Size(146, 34);
            MenuItemColor.Text = "颜色";
            MenuItemColor.ToolTipText = "设置颜色";
            MenuItemColor.Click += MenuItemColor_Click;
            // 
            // 查看ToolStripMenuItem
            // 
            查看ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItemZoomIn, MenuItemZoomOut });
            查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            查看ToolStripMenuItem.Size = new Size(62, 28);
            查看ToolStripMenuItem.Text = "查看";
            // 
            // MenuItemZoomIn
            // 
            MenuItemZoomIn.Name = "MenuItemZoomIn";
            MenuItemZoomIn.ShortcutKeys = Keys.Control | Keys.I;
            MenuItemZoomIn.Size = new Size(215, 34);
            MenuItemZoomIn.Text = "放大";
            MenuItemZoomIn.Click += MenuItemZoomIn_Click;
            // 
            // MenuItemZoomOut
            // 
            MenuItemZoomOut.Name = "MenuItemZoomOut";
            MenuItemZoomOut.ShortcutKeys = Keys.Control | Keys.O;
            MenuItemZoomOut.Size = new Size(215, 34);
            MenuItemZoomOut.Text = "缩小";
            MenuItemZoomOut.Click += MenuItemZoomOut_Click;
            // 
            // 其它ToolStripMenuItem
            // 
            其它ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItemScreenPen });
            其它ToolStripMenuItem.Name = "其它ToolStripMenuItem";
            其它ToolStripMenuItem.Size = new Size(62, 28);
            其它ToolStripMenuItem.Text = "其它";
            // 
            // MenuItemScreenPen
            // 
            MenuItemScreenPen.Image = (Image)resources.GetObject("MenuItemScreenPen.Image");
            MenuItemScreenPen.Name = "MenuItemScreenPen";
            MenuItemScreenPen.ShortcutKeys = Keys.F3;
            MenuItemScreenPen.Size = new Size(213, 34);
            MenuItemScreenPen.Text = "屏幕画笔";
            MenuItemScreenPen.Click += MenuItemScreenPen_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonLine, toolStripButtonRectangle, toolStripButtonCircle, toolStripButtonSketch, toolStripSeparator1, toolStripButtonUndo, toolStripButtonRedo, toolStripButtonStop, toolStripSeparator2, toolStripButtonWidth, toolStripSplitButtonColor, toolStripButtonZoomIn, toolStripButtoZoomOut });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1228, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLine
            // 
            toolStripButtonLine.Image = (Image)resources.GetObject("toolStripButtonLine.Image");
            toolStripButtonLine.ImageTransparentColor = Color.Magenta;
            toolStripButtonLine.Name = "toolStripButtonLine";
            toolStripButtonLine.Size = new Size(74, 28);
            toolStripButtonLine.Text = "直线";
            toolStripButtonLine.Click += MenuItemLine_Click;
            // 
            // toolStripButtonRectangle
            // 
            toolStripButtonRectangle.Image = (Image)resources.GetObject("toolStripButtonRectangle.Image");
            toolStripButtonRectangle.ImageTransparentColor = Color.Magenta;
            toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            toolStripButtonRectangle.Size = new Size(74, 28);
            toolStripButtonRectangle.Text = "矩形";
            toolStripButtonRectangle.Click += MenuItemRectangle_Click;
            // 
            // toolStripButtonCircle
            // 
            toolStripButtonCircle.Image = (Image)resources.GetObject("toolStripButtonCircle.Image");
            toolStripButtonCircle.ImageTransparentColor = Color.Magenta;
            toolStripButtonCircle.Name = "toolStripButtonCircle";
            toolStripButtonCircle.Size = new Size(56, 28);
            toolStripButtonCircle.Text = "圆";
            toolStripButtonCircle.Click += MenuItemCircle_Click;
            // 
            // toolStripButtonSketch
            // 
            toolStripButtonSketch.Image = (Image)resources.GetObject("toolStripButtonSketch.Image");
            toolStripButtonSketch.ImageTransparentColor = Color.Magenta;
            toolStripButtonSketch.Name = "toolStripButtonSketch";
            toolStripButtonSketch.Size = new Size(92, 28);
            toolStripButtonSketch.Text = "徒手画";
            toolStripButtonSketch.Click += MenuItemSketch_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripButtonUndo
            // 
            toolStripButtonUndo.Image = (Image)resources.GetObject("toolStripButtonUndo.Image");
            toolStripButtonUndo.ImageTransparentColor = Color.Magenta;
            toolStripButtonUndo.Name = "toolStripButtonUndo";
            toolStripButtonUndo.Size = new Size(74, 28);
            toolStripButtonUndo.Text = "撤销";
            toolStripButtonUndo.Click += MenuItemUndo_Click;
            // 
            // toolStripButtonRedo
            // 
            toolStripButtonRedo.Image = (Image)resources.GetObject("toolStripButtonRedo.Image");
            toolStripButtonRedo.ImageTransparentColor = Color.Magenta;
            toolStripButtonRedo.Name = "toolStripButtonRedo";
            toolStripButtonRedo.Size = new Size(74, 28);
            toolStripButtonRedo.Text = "重做";
            toolStripButtonRedo.Click += MenuItemRedo_Click;
            // 
            // toolStripButtonStop
            // 
            toolStripButtonStop.Image = (Image)resources.GetObject("toolStripButtonStop.Image");
            toolStripButtonStop.ImageTransparentColor = Color.Magenta;
            toolStripButtonStop.Name = "toolStripButtonStop";
            toolStripButtonStop.Size = new Size(74, 28);
            toolStripButtonStop.Text = "停止";
            toolStripButtonStop.Click += MenuItemStop_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // toolStripButtonWidth
            // 
            toolStripButtonWidth.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem1px, ToolStripMenuItem2px, toolStripMenuItem4px, ToolStripMenuItem8px });
            toolStripButtonWidth.Font = new Font("Microsoft YaHei UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 134);
            toolStripButtonWidth.Image = (Image)resources.GetObject("toolStripButtonWidth.Image");
            toolStripButtonWidth.ImageTransparentColor = Color.Magenta;
            toolStripButtonWidth.Name = "toolStripButtonWidth";
            toolStripButtonWidth.Padding = new Padding(5);
            toolStripButtonWidth.Size = new Size(101, 28);
            toolStripButtonWidth.Text = "线宽";
            toolStripButtonWidth.Click += MenuItemWidth_Click;
            // 
            // ToolStripMenuItem1px
            // 
            ToolStripMenuItem1px.Font = new Font("Microsoft YaHei UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ToolStripMenuItem1px.Name = "ToolStripMenuItem1px";
            ToolStripMenuItem1px.Size = new Size(139, 34);
            ToolStripMenuItem1px.Text = "1px";
            ToolStripMenuItem1px.Click += ToolStripMenuItem1px_Click;
            // 
            // ToolStripMenuItem2px
            // 
            ToolStripMenuItem2px.Font = new Font("Microsoft YaHei UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ToolStripMenuItem2px.Name = "ToolStripMenuItem2px";
            ToolStripMenuItem2px.Size = new Size(139, 34);
            ToolStripMenuItem2px.Text = "2px";
            ToolStripMenuItem2px.Click += ToolStripMenuItem2px_Click;
            // 
            // toolStripMenuItem4px
            // 
            toolStripMenuItem4px.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem4px.Name = "toolStripMenuItem4px";
            toolStripMenuItem4px.Size = new Size(139, 34);
            toolStripMenuItem4px.Text = "4px";
            toolStripMenuItem4px.Click += toolStripMenuItem4px_Click;
            // 
            // ToolStripMenuItem8px
            // 
            ToolStripMenuItem8px.Font = new Font("Microsoft YaHei UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ToolStripMenuItem8px.Name = "ToolStripMenuItem8px";
            ToolStripMenuItem8px.Size = new Size(139, 34);
            ToolStripMenuItem8px.Text = "8px";
            ToolStripMenuItem8px.Click += ToolStripMenuItem8px_Click;
            // 
            // toolStripSplitButtonColor
            // 
            toolStripSplitButtonColor.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemRed, ToolStripMenuItemGreen, ToolStripMenuItemYellow, ToolStripMenuItemBlue, ToolStripMenuItemBlack });
            toolStripSplitButtonColor.Image = (Image)resources.GetObject("toolStripSplitButtonColor.Image");
            toolStripSplitButtonColor.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonColor.Name = "toolStripSplitButtonColor";
            toolStripSplitButtonColor.Size = new Size(91, 28);
            toolStripSplitButtonColor.Text = "颜色";
            toolStripSplitButtonColor.ButtonClick += MenuItemColor_Click;
            // 
            // ToolStripMenuItemRed
            // 
            ToolStripMenuItemRed.Image = (Image)resources.GetObject("ToolStripMenuItemRed.Image");
            ToolStripMenuItemRed.Name = "ToolStripMenuItemRed";
            ToolStripMenuItemRed.Size = new Size(146, 34);
            ToolStripMenuItemRed.Text = "红色";
            ToolStripMenuItemRed.Click += ToolStripMenuItem_ClickRed;
            // 
            // ToolStripMenuItemGreen
            // 
            ToolStripMenuItemGreen.Image = (Image)resources.GetObject("ToolStripMenuItemGreen.Image");
            ToolStripMenuItemGreen.Name = "ToolStripMenuItemGreen";
            ToolStripMenuItemGreen.Size = new Size(146, 34);
            ToolStripMenuItemGreen.Text = "绿色";
            ToolStripMenuItemGreen.Click += ToolStripMenuItemGreen_Click;
            // 
            // ToolStripMenuItemYellow
            // 
            ToolStripMenuItemYellow.Image = (Image)resources.GetObject("ToolStripMenuItemYellow.Image");
            ToolStripMenuItemYellow.Name = "ToolStripMenuItemYellow";
            ToolStripMenuItemYellow.Size = new Size(146, 34);
            ToolStripMenuItemYellow.Text = "黄色";
            ToolStripMenuItemYellow.Click += ToolStripMenuItemYellow_Click;
            // 
            // ToolStripMenuItemBlue
            // 
            ToolStripMenuItemBlue.Image = (Image)resources.GetObject("ToolStripMenuItemBlue.Image");
            ToolStripMenuItemBlue.Name = "ToolStripMenuItemBlue";
            ToolStripMenuItemBlue.Size = new Size(146, 34);
            ToolStripMenuItemBlue.Text = "蓝色";
            ToolStripMenuItemBlue.Click += ToolStripMenuItemBlue_Click;
            // 
            // ToolStripMenuItemBlack
            // 
            ToolStripMenuItemBlack.Image = (Image)resources.GetObject("ToolStripMenuItemBlack.Image");
            ToolStripMenuItemBlack.Name = "ToolStripMenuItemBlack";
            ToolStripMenuItemBlack.Size = new Size(146, 34);
            ToolStripMenuItemBlack.Text = "黑色";
            ToolStripMenuItemBlack.Click += ToolStripMenuItemBlack_Click;
            // 
            // toolStripButtonZoomIn
            // 
            toolStripButtonZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonZoomIn.Image = (Image)resources.GetObject("toolStripButtonZoomIn.Image");
            toolStripButtonZoomIn.ImageTransparentColor = Color.Magenta;
            toolStripButtonZoomIn.Name = "toolStripButtonZoomIn";
            toolStripButtonZoomIn.Size = new Size(50, 28);
            toolStripButtonZoomIn.Text = "放大";
            toolStripButtonZoomIn.Click += MenuItemZoomIn_Click;
            // 
            // toolStripButtoZoomOut
            // 
            toolStripButtoZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtoZoomOut.Image = (Image)resources.GetObject("toolStripButtoZoomOut.Image");
            toolStripButtoZoomOut.ImageTransparentColor = Color.Magenta;
            toolStripButtoZoomOut.Name = "toolStripButtoZoomOut";
            toolStripButtoZoomOut.Size = new Size(50, 28);
            toolStripButtoZoomOut.Text = "缩小";
            toolStripButtoZoomOut.Click += MenuItemZoomOut_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabelPosition });
            statusStrip1.Location = new Point(0, 702);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1228, 31);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelPosition
            // 
            StatusLabelPosition.Name = "StatusLabelPosition";
            StatusLabelPosition.Size = new Size(123, 24);
            StatusLabelPosition.Text = "鼠标：x= , y=";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = ".dwg";
            openFileDialog1.Filter = "所有文件|*.dwg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "\\";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = ".dwg";
            saveFileDialog1.Filter = "所有文件|*.dwg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.InitialDirectory = "\\";
            // 
            // saveFileDialog2
            // 
            saveFileDialog2.FileName = ".gif";
            saveFileDialog2.Filter = "所有文件|*.gif|*.jpg|*.png";
            saveFileDialog2.FilterIndex = 2;
            saveFileDialog2.InitialDirectory = "\\";
            saveFileDialog2.Title = "保存为图片";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.Silver;
            panelContainer.Controls.Add(panelDraw);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 65);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1228, 637);
            panelContainer.TabIndex = 3;
            // 
            // panelDraw
            // 
            panelDraw.BackColor = Color.White;
            panelDraw.BorderStyle = BorderStyle.FixedSingle;
            panelDraw.Location = new Point(0, 0);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(660, 410);
            panelDraw.TabIndex = 0;
            panelDraw.Paint += panelDraw_Paint;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 733);
            Controls.Add(panelContainer);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "画笔";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            Paint += FormMain_Paint;
            MouseDown += FormMain_MouseDown;
            MouseMove += FormMain_MouseMove;
            MouseUp += FormMain_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemDrawing;
        private ToolStripMenuItem MenuItemLine;
        private ToolStripMenuItem MenuItemRectangle;
        private ToolStripMenuItem MenuItemCircle;
        private ToolStripMenuItem MenuItemStop;
        private ToolStripMenuItem MenuItemSetting;
        private ToolStripMenuItem MenuItemWidth;
        private ToolStripMenuItem MenuItemColor;
        private ColorDialog colorDialog1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem MenuItemUndo;
        private ToolStripMenuItem MenuItemRedo;
        public ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonLine;
        private ToolStripButton toolStripButtonRectangle;
        private ToolStripButton toolStripButtonCircle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripButton toolStripButtonRedo;
        private ToolStripButton toolStripButtonStop;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton toolStripButtonWidth;
        private ToolStripMenuItem ToolStripMenuItem1px;
        private ToolStripMenuItem ToolStripMenuItem2px;
        private ToolStripMenuItem toolStripMenuItem4px;
        private ToolStripMenuItem ToolStripMenuItem8px;
        private ToolStripSplitButton toolStripSplitButtonColor;
        private ToolStripMenuItem ToolStripMenuItemRed;
        private ToolStripMenuItem ToolStripMenuItemGreen;
        private ToolStripMenuItem ToolStripMenuItemYellow;
        private ToolStripMenuItem ToolStripMenuItemBlue;
        private ToolStripMenuItem ToolStripMenuItemBlack;
        public  StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabelPosition;
        private ToolStripMenuItem MenuItemFile;
        private ToolStripMenuItem MenuItemNew;
        private ToolStripMenuItem MenuItemOpen;
        private ToolStripMenuItem MenuItemSave;
        private ToolStripMenuItem MenuItemSaveas;
        private ToolStripMenuItem MenuItemSaveasPic;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem MenuItemClose;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
        private ToolStripMenuItem MenuItemSketch;
        private ToolStripButton toolStripButtonSketch;
        private Panel panelContainer;
        private Panel panelDraw;
        private ToolStripMenuItem 查看ToolStripMenuItem;
        private ToolStripMenuItem MenuItemZoomIn;
        private ToolStripMenuItem MenuItemZoomOut;
        private ToolStripButton toolStripButtonZoomIn;
        private ToolStripButton toolStripButtoZoomOut;
        private ToolStripMenuItem 其它ToolStripMenuItem;
        private ToolStripMenuItem MenuItemScreenPen;
    }
}
