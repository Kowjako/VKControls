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

namespace VKControls.VKButtons
{
    public partial class VKRoundedButton : UserControl
    {
        private GraphicsPath path;
        private bool isMouseInside = false;
        public string Caption
        {
            get => lblCaption.Text;
            set
            {
                lblCaption.Text = value;
                OnFontOrResizeChanged?.Invoke();
            }
        }

        public new Font Font
        {
            get => lblCaption.Font;
            set
            {
                lblCaption.Font = value;
                OnFontOrResizeChanged?.Invoke();
            }
        }

        [Browsable(false)]
        public new Color BackColor { get; set; } = Color.Transparent;

        private int _cornerRadius = 20;
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                mainPanel.Invalidate();
            }
        }

        private Color _borderColor;
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                borderPen.Color = value;
            }
        }

        private Color _buttonColor;
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                buttonPen.Color = value;
            }
        }


        public event Action OnFontOrResizeChanged;

        private Graphics g;
        private Pen buttonPen = new Pen(new SolidBrush(Color.White)),
                    borderPen = new Pen(new SolidBrush(Color.Purple), 2);

        public VKRoundedButton()
        {
            InitializeComponent();
            g = mainPanel.CreateGraphics();
            OnFontOrResizeChanged += PlaceLabel;
            AutoScaleMode = AutoScaleMode.None;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PlaceLabel();
            mainPanel.Invalidate();
        }

        private void PlaceLabel()
        {
            lblCaption.Left = Width / 2 - lblCaption.Width / 2;
            lblCaption.Top = Height / 2 - lblCaption.Height / 2;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var rX = mainPanel.Width / 2;
            var rY = mainPanel.Height / 2;
            var h = mainPanel.Height / 2;
            var w = mainPanel.Width / 2;
            if (Math.Pow(e.X - w, 2) / Math.Pow(rX, 2) + Math.Pow(e.Y - h, 2) / Math.Pow(rY, 2) <= 1 && !isMouseInside)
            {
                isMouseInside = !isMouseInside;
                g?.FillPath(new SolidBrush(Color.White), path);
                g?.DrawPath(borderPen, path);
                lblCaption.BackColor = Color.White;
            }
        }

        private void mainPanel_MouseLeave(object sender, EventArgs e)
        {
            if (!isMouseInside)
            {
                g?.FillPath(new SolidBrush(ButtonColor), path);
                lblCaption.BackColor = ButtonColor;
                isMouseInside = !isMouseInside;
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            g = mainPanel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(new SolidBrush(BackColor), mainPanel.ClientRectangle);

            path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(1, 1, CornerRadius * 2, CornerRadius * 2, 180F, 90F);
            path.AddArc(Width - CornerRadius * 2 - 3, 1, CornerRadius * 2, CornerRadius * 2, 270F, 90F);
            path.AddArc(Width - CornerRadius * 2 - 3, Height - CornerRadius * 2 - 3, CornerRadius * 2, CornerRadius * 2, 0F, 90F);
            path.AddArc(1, Height - CornerRadius * 2 - 3, CornerRadius * 2, CornerRadius * 2, 90F, 90F);
            path.CloseFigure();

            g.FillPath(new SolidBrush(ButtonColor), path);
            lblCaption.BackColor = Color.White;
            g.DrawPath(borderPen, path);
            lblCaption.BackColor = ButtonColor;

        }
    }
}
