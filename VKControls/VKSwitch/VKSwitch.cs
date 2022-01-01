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
        public Color EnabledColor { get; set; } = Color.Lime;

        /* enabled => switch on right side */
        private bool _isEnabled = true;

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

            g.FillPath(new SolidBrush(_isEnabled ? EnabledColor : ButtonColor), path);
            g.DrawPath(new Pen(new SolidBrush(BorderColor), 3), path);
            
            if(_isEnabled)
            {
                g.DrawEllipse(new Pen(new SolidBrush(Color.Black), 2), new RectangleF(40, 3, Height - 6, Height - 6));
                g.FillEllipse(new SolidBrush(Color.White), new RectangleF(40, 3, Height - 6, Height - 6));
                g.DrawArc(new Pen(new SolidBrush(Color.White), 2), new Rectangle(17, 7, Height - 15, Height - 15), 0F, 360F);
            }
            else
            {
                g.DrawEllipse(new Pen(new SolidBrush(Color.Black), 2), new RectangleF(3, 3, Height - 6, Height - 6));
                g.FillEllipse(new SolidBrush(Color.White), new RectangleF(3, 3, Height - 6, Height - 6));
                g.DrawLine(new Pen(new SolidBrush(Color.White), 3), 40, 7, 40, 17);
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {
            _isEnabled = !_isEnabled;
            mainPanel.Invalidate();
        }
    }
}
