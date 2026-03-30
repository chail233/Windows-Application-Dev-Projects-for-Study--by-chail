namespace Timer
{
    partial class TimerForm
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
            components = new System.ComponentModel.Container();
            hour = new Label();
            minute = new Label();
            second = new Label();
            msecond = new Label();
            colon1 = new Label();
            colon2 = new Label();
            colon3 = new Label();
            start = new Button();
            stop = new Button();
            pause = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            title = new Label();
            label1 = new Label();
            isCutDown = new CheckBox();
            houradd = new Button();
            minuteadd = new Button();
            secondadd = new Button();
            minuteminus = new Button();
            hourminus = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            secondminus = new Button();
            reset = new Button();
            SuspendLayout();
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.BackColor = Color.Transparent;
            hour.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hour.Location = new Point(17, 135);
            hour.Name = "hour";
            hour.Size = new Size(233, 163);
            hour.TabIndex = 0;
            hour.Text = "00";
            // 
            // minute
            // 
            minute.AutoSize = true;
            minute.BackColor = Color.Transparent;
            minute.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minute.Location = new Point(296, 135);
            minute.Name = "minute";
            minute.Size = new Size(233, 163);
            minute.TabIndex = 0;
            minute.Text = "00";
            // 
            // second
            // 
            second.AutoSize = true;
            second.BackColor = Color.Transparent;
            second.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            second.Location = new Point(587, 135);
            second.Name = "second";
            second.Size = new Size(233, 163);
            second.TabIndex = 0;
            second.Text = "00";
            // 
            // msecond
            // 
            msecond.AutoSize = true;
            msecond.BackColor = Color.Transparent;
            msecond.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msecond.Location = new Point(888, 135);
            msecond.Name = "msecond";
            msecond.Size = new Size(233, 163);
            msecond.TabIndex = 0;
            msecond.Text = "00";
            // 
            // colon1
            // 
            colon1.AutoSize = true;
            colon1.BackColor = Color.Transparent;
            colon1.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colon1.ForeColor = SystemColors.ControlText;
            colon1.Location = new Point(219, 123);
            colon1.Name = "colon1";
            colon1.Size = new Size(123, 163);
            colon1.TabIndex = 0;
            colon1.Text = ":";
            // 
            // colon2
            // 
            colon2.AutoSize = true;
            colon2.BackColor = Color.Transparent;
            colon2.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colon2.ForeColor = SystemColors.ControlText;
            colon2.Location = new Point(489, 123);
            colon2.Name = "colon2";
            colon2.Size = new Size(123, 163);
            colon2.TabIndex = 0;
            colon2.Text = ":";
            // 
            // colon3
            // 
            colon3.AutoSize = true;
            colon3.BackColor = Color.Transparent;
            colon3.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colon3.ForeColor = SystemColors.ControlText;
            colon3.Location = new Point(793, 123);
            colon3.Name = "colon3";
            colon3.Size = new Size(123, 163);
            colon3.TabIndex = 0;
            colon3.Text = ":";
            // 
            // start
            // 
            start.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 134);
            start.Location = new Point(128, 393);
            start.Name = "start";
            start.Size = new Size(214, 106);
            start.TabIndex = 1;
            start.Text = "开始";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Enabled = false;
            stop.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 134);
            stop.Location = new Point(793, 393);
            stop.Name = "stop";
            stop.Size = new Size(214, 106);
            stop.TabIndex = 1;
            stop.Text = "停止";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // pause
            // 
            pause.Enabled = false;
            pause.Font = new Font("Microsoft YaHei UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pause.Location = new Point(458, 393);
            pause.Name = "pause";
            pause.Size = new Size(214, 106);
            pause.TabIndex = 1;
            pause.Text = "暂停";
            pause.UseVisualStyleBackColor = true;
            pause.Click += pause_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Old English Text MT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Location = new Point(276, 9);
            title.Name = "title";
            title.Size = new Size(297, 114);
            title.TabIndex = 2;
            title.Text = "Timer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 28F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(609, 57);
            label1.Name = "label1";
            label1.Size = new Size(192, 66);
            label1.TabIndex = 3;
            label1.Text = "by chail";
            // 
            // isCutDown
            // 
            isCutDown.AutoSize = true;
            isCutDown.Location = new Point(123, 538);
            isCutDown.Name = "isCutDown";
            isCutDown.Size = new Size(90, 28);
            isCutDown.TabIndex = 4;
            isCutDown.Text = "倒计时";
            isCutDown.UseVisualStyleBackColor = true;
            // 
            // houradd
            // 
            houradd.Location = new Point(74, 123);
            houradd.Name = "houradd";
            houradd.Size = new Size(112, 34);
            houradd.TabIndex = 5;
            houradd.Text = "+";
            houradd.UseVisualStyleBackColor = true;
            houradd.Click += houradd_Click;
            // 
            // minuteadd
            // 
            minuteadd.Location = new Point(348, 123);
            minuteadd.Name = "minuteadd";
            minuteadd.Size = new Size(112, 34);
            minuteadd.TabIndex = 5;
            minuteadd.Text = "+";
            minuteadd.UseVisualStyleBackColor = true;
            minuteadd.Click += minuteadd_Click;
            // 
            // secondadd
            // 
            secondadd.Location = new Point(643, 123);
            secondadd.Name = "secondadd";
            secondadd.Size = new Size(112, 34);
            secondadd.TabIndex = 5;
            secondadd.Text = "+";
            secondadd.UseVisualStyleBackColor = true;
            secondadd.Click += secondadd_Click;
            // 
            // minuteminus
            // 
            minuteminus.Location = new Point(348, 275);
            minuteminus.Name = "minuteminus";
            minuteminus.Size = new Size(112, 34);
            minuteminus.TabIndex = 5;
            minuteminus.Text = "-";
            minuteminus.UseVisualStyleBackColor = true;
            minuteminus.Click += minuteminus_Click;
            // 
            // hourminus
            // 
            hourminus.Location = new Point(74, 275);
            hourminus.Name = "hourminus";
            hourminus.Size = new Size(112, 34);
            hourminus.TabIndex = 5;
            hourminus.Text = "-";
            hourminus.UseVisualStyleBackColor = true;
            hourminus.Click += hourminus_Click;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // secondminus
            // 
            secondminus.Location = new Point(643, 275);
            secondminus.Name = "secondminus";
            secondminus.Size = new Size(112, 34);
            secondminus.TabIndex = 5;
            secondminus.Text = "-";
            secondminus.UseVisualStyleBackColor = true;
            secondminus.Click += secondminus_Click;
            // 
            // reset
            // 
            reset.Location = new Point(921, 533);
            reset.Name = "reset";
            reset.Size = new Size(112, 34);
            reset.TabIndex = 6;
            reset.Text = "重置";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 607);
            Controls.Add(reset);
            Controls.Add(hourminus);
            Controls.Add(minuteminus);
            Controls.Add(secondminus);
            Controls.Add(secondadd);
            Controls.Add(minuteadd);
            Controls.Add(houradd);
            Controls.Add(isCutDown);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(stop);
            Controls.Add(pause);
            Controls.Add(start);
            Controls.Add(colon3);
            Controls.Add(colon2);
            Controls.Add(msecond);
            Controls.Add(second);
            Controls.Add(minute);
            Controls.Add(hour);
            Controls.Add(colon1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "TimerForm";
            Text = "Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hour;
        private Label minute;
        private Label second;
        private Label msecond;
        private Label colon1;
        private Label colon2;
        private Label colon3;
        private Button start;
        private Button stop;
        private Button pause;
        private System.Windows.Forms.Timer timer1;
        private Label title;
        private Label label1;
        private CheckBox isCutDown;
        private Button houradd;
        private Button minuteadd;
        private Button secondadd;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button minuteminus;
        private Button hourminus;
        private System.Windows.Forms.Timer timer2;
        private Button secondminus;
        private Button reset;
    }
}
