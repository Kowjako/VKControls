using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKControls.VKSwitch
{
    public partial class VKSwitch : UserControl
    {
        private Graphics g;
        private GraphicsPath path;

        public int CornerRadius { get; set; } = 10;

        public Color ButtonColor { get; set; } = Color.White;
        public Color BorderColor { get; set; } = Color.Green;


        public VKSwitch()
        {
            InitializeComponent();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            g = mainPanel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(new SolidBrush(BackColor), mainPanel.ClientRectangle);

            path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(1, 1, CornerRadius * 2, CornerRadius * 2, 180F, 90F);
            path.AddArc(Width - CornerRadius * 2 - 2, 1, CornerRadius * 2, CornerRadius * 2, 270F, 90F);
            path.AddArc(Width - CornerRadius * 2 - 2, Height - CornerRadius * 2 - 2, CornerRadius * 2, CornerRadius * 2, 0F, 90F);
            path.AddArc(1, Height - CornerRadius * 2 - 2, CornerRadius * 2, CornerRadius * 2, 90F, 90F);
            path.CloseFigure();

            g.FillPath(new SolidBrush(ButtonColor), path);
            g.DrawPath(new Pen(new SolidBrush(BorderColor), 3), path);
        }
    }
}
