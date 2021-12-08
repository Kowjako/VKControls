using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKControls.VKProgressBar
{
    public partial class VKProgressBar : UserControl
    {
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int Value { get; set; }
        public Color FillingColor { get; set; }

        private const float startAngle = 45.0F;
        private Graphics g;
        private static Pen pen = new Pen(new SolidBrush(Color.Gray),3);
        private static Pen fillingPen = new Pen(new SolidBrush(Color.Red), 3);

        public VKProgressBar()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g.DrawEllipse(pen, new Rectangle(3, 3, Width - 6, Height - 6));
        }

        public void ReportProgress(int value)
        {
            if (value > MaxValue - MinValue) return;
            Value = (int)((double)value / (MaxValue - MinValue)) * 100;
            DrawProgress();
        }

        private void DrawProgress()
        {
            g.DrawArc(fillingPen, new Rectangle(3, 3, Width - 6, Height - 6), startAngle, 0);
        }



        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //}
    }
}
