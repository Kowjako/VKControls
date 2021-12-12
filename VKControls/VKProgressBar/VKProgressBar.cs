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
        public int MaxValue { get; set; } = 100;
        public int MinValue { get; set; } = 0;

        private event Action OnProgressChanged;

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    _value = value;
                    OnProgressChanged();
                }
            }
        }

        public Color FillingColor
        {
            set
            {
                fillingPen = new Pen(new SolidBrush(value), 3);
            }
            get => fillingPen.Color;
        }

        public Color BarColor
        {
            get => pen.Color;
            set 
            {
                pen = new Pen(new SolidBrush(value), 3);
            }
        }

        private const float startAngle = 270.0F;
        private Graphics g;
        private Pen pen = new Pen(new SolidBrush(Color.Black), 3), 
                    fillingPen = new Pen(new SolidBrush(Color.Gainsboro), 3);

        public VKProgressBar()
        {
            InitializeComponent();
            OnProgressChanged += () => DrawProgress();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g.DrawEllipse(pen, new Rectangle(3, 3, Width - 6, Height - 6));
            g.DrawArc(fillingPen, new Rectangle(3, 3, Width - 6, Height - 6), startAngle, (float)_value / 100 * 360F);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            g = CreateGraphics();
            g.DrawEllipse(pen, new Rectangle(3, 3, Width - 6, Height - 6));
            lblProgress.Top = Height / 2 - lblProgress.Height / 2;
            lblProgress.Left = Width / 2 - lblProgress.Width / 2;
        }

        public void ReportProgress(int value)
        {
            if (value > MaxValue - MinValue) return;
            _value = (int)((double)value / (MaxValue - MinValue)) * 100;
            DrawProgress();
        }

        private void DrawProgress()
        {
            lblProgress.Text = string.Format("{0} %", Math.Round((float)_value / (MaxValue - MinValue) * 100));
            Invalidate();
        }
    }
}
