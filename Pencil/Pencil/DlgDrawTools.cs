using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pencil
{
    public partial class DlgDrawTools : Form
    {
        public FormMain formMain;
        public DlgDrawTools()
        {
            InitializeComponent();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            formMain.MenuItemLine_Click(sender, e);
        }

        private void buttonRectang_Click(object sender, EventArgs e)
        {
            formMain.MenuItemRectangle_Click(sender, e);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            formMain.MenuItemCircle_Click(sender, e);
        }

        private void buttonSketch_Click(object sender, EventArgs e)
        {
            formMain.MenuItemSketch_Click(sender, e);
        }

        private void buttonWidth_Click(object sender, EventArgs e)
        {
            formMain.MenuItemWidth_Click(sender, e);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            formMain.MenuItemColor_Click(sender, e);
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            formMain.MenuItemUndo_Click(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DlgDrawTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.menuStrip1.Visible = true;
            formMain.statusStrip1.Visible = true;
            formMain.toolStrip1.Visible = true;
            formMain.FormBorderStyle = FormBorderStyle.Sizable;
            formMain.WindowState = FormWindowState.Maximized;
        }
    }
}
