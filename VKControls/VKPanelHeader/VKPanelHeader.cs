using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKControls.VKPanelHeader
{
    public partial class VKPanelHeader : UserControl
    {
        private Point lastPoint;
        private Panel pLeft, pRight, pBottom;

        public VKPanelHeader()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        public Color HeaderColor { get; set; } = Color.Gray;

        public string HeaderText { get; set; }

        public Font HeaderFont { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            mainPanel.BackColor = HeaderColor;
            headerLabel.Text = HeaderText;
            headerLabel.Font = HeaderFont;

            headerLabel.Top = (Height - headerLabel.Height) / 2;
            if (pLeft != null) pLeft.BackColor = HeaderColor;
            if (pRight != null) pRight.BackColor = HeaderColor;
            if (pBottom != null) pBottom.BackColor = HeaderColor;
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ParentForm.Left += e.X - lastPoint.X;
                Parent.Top += e.Y - lastPoint.Y;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (pLeft == null)
            {
                DrawApplicationBorder();
            }
        }

        private void DrawApplicationBorder()
        {
            pLeft = new Panel();
            pLeft.Dock = DockStyle.Left;
            pLeft.Width = 2;
            pLeft.BackColor = HeaderColor;

            pBottom = new Panel();
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Height = 2;
            pBottom.BackColor = HeaderColor;

            pRight = new Panel();
            pRight.Dock = DockStyle.Right;
            pRight.Width = 2;
            pRight.BackColor = HeaderColor;

            Parent.Controls.Add(pLeft);
            Parent.Controls.Add(pBottom);
            Parent.Controls.Add(pRight);
        }
    }
}
