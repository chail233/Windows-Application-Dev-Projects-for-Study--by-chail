namespace Pencil
{
    partial class DigPenWidth
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
            labelPenWidth = new Label();
            numericUpDownWidth = new NumericUpDown();
            buttonOK = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            SuspendLayout();
            // 
            // labelPenWidth
            // 
            labelPenWidth.AutoSize = true;
            labelPenWidth.Location = new Point(187, 165);
            labelPenWidth.Name = "labelPenWidth";
            labelPenWidth.Size = new Size(82, 24);
            labelPenWidth.TabIndex = 0;
            labelPenWidth.Text = "画笔宽度";
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(323, 163);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(180, 30);
            numericUpDownWidth.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(118, 344);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(112, 34);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "确定";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(539, 344);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "取消";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DigPenWidth
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(numericUpDownWidth);
            Controls.Add(labelPenWidth);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DigPenWidth";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "设置画笔线宽";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPenWidth;
        public NumericUpDown numericUpDownWidth;
        private Button buttonOK;
        private Button buttonCancel;
    }
}