namespace Pencil
{
    partial class DlgDrawTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgDrawTools));
            buttonLine = new Button();
            buttonRectang = new Button();
            buttonCircle = new Button();
            buttonUndo = new Button();
            buttonColor = new Button();
            buttonWidth = new Button();
            buttonSketch = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonLine
            // 
            buttonLine.Location = new Point(12, 29);
            buttonLine.Name = "buttonLine";
            buttonLine.Size = new Size(137, 62);
            buttonLine.TabIndex = 0;
            buttonLine.Text = "直线";
            buttonLine.UseVisualStyleBackColor = true;
            buttonLine.Click += buttonLine_Click;
            // 
            // buttonRectang
            // 
            buttonRectang.Location = new Point(174, 29);
            buttonRectang.Name = "buttonRectang";
            buttonRectang.Size = new Size(137, 62);
            buttonRectang.TabIndex = 0;
            buttonRectang.Text = "矩形";
            buttonRectang.UseVisualStyleBackColor = true;
            buttonRectang.Click += buttonRectang_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(336, 29);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(137, 62);
            buttonCircle.TabIndex = 0;
            buttonCircle.Text = "圆";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // buttonUndo
            // 
            buttonUndo.Location = new Point(336, 136);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(137, 62);
            buttonUndo.TabIndex = 0;
            buttonUndo.Text = "撤销";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(174, 136);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(137, 62);
            buttonColor.TabIndex = 0;
            buttonColor.Text = "颜色";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // buttonWidth
            // 
            buttonWidth.Location = new Point(12, 136);
            buttonWidth.Name = "buttonWidth";
            buttonWidth.Size = new Size(137, 62);
            buttonWidth.TabIndex = 0;
            buttonWidth.Text = "线宽";
            buttonWidth.UseVisualStyleBackColor = true;
            buttonWidth.Click += buttonWidth_Click;
            // 
            // buttonSketch
            // 
            buttonSketch.Location = new Point(501, 29);
            buttonSketch.Name = "buttonSketch";
            buttonSketch.Size = new Size(137, 62);
            buttonSketch.TabIndex = 0;
            buttonSketch.Text = "徒手";
            buttonSketch.UseVisualStyleBackColor = true;
            buttonSketch.Click += buttonSketch_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(501, 136);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(137, 62);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "退出";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // DlgDrawTools
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 243);
            Controls.Add(buttonExit);
            Controls.Add(buttonUndo);
            Controls.Add(buttonSketch);
            Controls.Add(buttonCircle);
            Controls.Add(buttonColor);
            Controls.Add(buttonRectang);
            Controls.Add(buttonWidth);
            Controls.Add(buttonLine);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DlgDrawTools";
            StartPosition = FormStartPosition.Manual;
            Text = "绘图工具箱";
            TopMost = true;
            FormClosed += DlgDrawTools_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLine;
        private Button buttonRectang;
        private Button buttonCircle;
        private Button buttonUndo;
        private Button buttonColor;
        private Button buttonWidth;
        private Button buttonSketch;
        private Button buttonExit;
    }
}