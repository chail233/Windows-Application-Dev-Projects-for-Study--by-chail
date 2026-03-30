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
            MenuItemDrawing = new ToolStripMenuItem();
            MenuItemLine = new ToolStripMenuItem();
            MenuItemRectangle = new ToolStripMenuItem();
            MenuItemCircle = new ToolStripMenuItem();
            MenuItemStop = new ToolStripMenuItem();
            MenuItemSetting = new ToolStripMenuItem();
            MenuItemWidth = new ToolStripMenuItem();
            MenuItemColor = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemDrawing, MenuItemSetting });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemDrawing
            // 
            MenuItemDrawing.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLine, MenuItemRectangle, MenuItemCircle, MenuItemStop });
            MenuItemDrawing.Name = "MenuItemDrawing";
            MenuItemDrawing.ShortcutKeys = Keys.Control | Keys.D;
            MenuItemDrawing.Size = new Size(62, 28);
            MenuItemDrawing.Text = "绘图";
            MenuItemDrawing.ToolTipText = "绘图";
            // 
            // MenuItemLine
            // 
            MenuItemLine.Image = Properties.Resources.line;
            MenuItemLine.Name = "MenuItemLine";
            MenuItemLine.ShortcutKeys = Keys.Control | Keys.L;
            MenuItemLine.Size = new Size(212, 34);
            MenuItemLine.Text = "直线";
            MenuItemLine.ToolTipText = "绘制直线";
            MenuItemLine.Click += MenuItemLine_Click;
            // 
            // MenuItemRectangle
            // 
            MenuItemRectangle.Image = Properties.Resources.rectangle;
            MenuItemRectangle.Name = "MenuItemRectangle";
            MenuItemRectangle.ShortcutKeys = Keys.Control | Keys.R;
            MenuItemRectangle.Size = new Size(212, 34);
            MenuItemRectangle.Text = "矩形";
            MenuItemRectangle.ToolTipText = "绘制矩形";
            MenuItemRectangle.Click += MenuItemRectangle_Click;
            // 
            // MenuItemCircle
            // 
            MenuItemCircle.Image = Properties.Resources.circle;
            MenuItemCircle.Name = "MenuItemCircle";
            MenuItemCircle.ShortcutKeys = Keys.Control | Keys.C;
            MenuItemCircle.Size = new Size(212, 34);
            MenuItemCircle.Text = "圆";
            MenuItemCircle.Click += MenuItemCircle_Click;
            // 
            // MenuItemStop
            // 
            MenuItemStop.Image = Properties.Resources.stop;
            MenuItemStop.Name = "MenuItemStop";
            MenuItemStop.ShortcutKeys = Keys.Control | Keys.S;
            MenuItemStop.Size = new Size(212, 34);
            MenuItemStop.Text = "停止";
            MenuItemStop.Click += MenuItemStop_Click;
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
            MenuItemWidth.Image = Properties.Resources.width;
            MenuItemWidth.Name = "MenuItemWidth";
            MenuItemWidth.Size = new Size(270, 34);
            MenuItemWidth.Text = "线宽";
            MenuItemWidth.ToolTipText = "设置线宽";
            MenuItemWidth.Click += MenuItemWidth_Click;
            // 
            // MenuItemColor
            // 
            MenuItemColor.Image = Properties.Resources.color;
            MenuItemColor.Name = "MenuItemColor";
            MenuItemColor.Size = new Size(270, 34);
            MenuItemColor.Text = "颜色";
            MenuItemColor.ToolTipText = "设置颜色";
            MenuItemColor.Click += MenuItemColor_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "画笔";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            Paint += FormMain_Paint;
            MouseDown += FormMain_MouseDown;
            MouseMove += FormMain_MouseMove;
            MouseUp += FormMain_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemDrawing;
        private ToolStripMenuItem MenuItemLine;
        private ToolStripMenuItem MenuItemRectangle;
        private ToolStripMenuItem MenuItemCircle;
        private ToolStripMenuItem MenuItemStop;
        private ToolStripMenuItem MenuItemSetting;
        private ToolStripMenuItem MenuItemWidth;
        private ToolStripMenuItem MenuItemColor;
        private ColorDialog colorDialog1;
    }
}
