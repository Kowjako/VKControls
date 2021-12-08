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

        private event Action OnProgressChanged;

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnProgressChanged();
            }
        }

        public Color FillingColor
        {
            set => fillingPen = new Pen(new SolidBrush(value), 3);
        }

        private const float startAngle = 45.0F;
        private Graphics g;
        private static Pen pen = new Pen(new SolidBrush(Color.Gray),3);
        public Pen fillingPen;

        public VKProgressBar()
        {
            InitializeComponent();
            g = CreateGraphics();

            OnProgressChanged += () => DrawProgress();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g.DrawEllipse(pen, new Rectangle(3, 3, Width - 6, Height - 6));
        }

        public void ReportProgress(int value)
        {
            if (value > MaxValue - MinValue) return;
            _value = (int)((double)value / (MaxValue - MinValue)) * 100;
            DrawProgress();
        }

        private void DrawProgress()
        {
            g.DrawArc(fillingPen, new Rectangle(3, 3, Width - 6, Height - 6), startAngle, _value / 360.0F);
        }
    }
}
