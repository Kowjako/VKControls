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

        #region Properties

        public string Caption
        {
            get => lblCaption.Text;
            set
            {
                lblCaption.Text = value;
                OnFontOrResizeChanged?.Invoke();
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
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

        private Color _color;

        public Color EnterColor
        {
            get => _color;
            set
            {
                _color = value;
                enterPen.Color = value;
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

        #endregion

        public event Action OnFontOrResizeChanged;

        private Graphics g;
        private bool _isMouseInside;
        private GraphicsPath path;
        private Pen buttonPen = new Pen(new SolidBrush(Color.White)),
                    borderPen = new Pen(new SolidBrush(Color.Purple), 2),
                    enterPen = new Pen(new SolidBrush(Color.Gray), 2);

        private EventHandler ButtonClickHandler = (send, arg) => MessageBox.Show("HELLO");

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
            var (rx, ry) = (mainPanel.Width / 2, mainPanel.Height / 2);
            if(Math.Pow(e.X - rx, 2) / Math.Pow(rx, 2) +
               Math.Pow(e.Y - ry, 2) / Math.Pow(ry, 2) <= 1.1)
            {
                if (!_isMouseInside)
                {
                    g?.FillPath(new SolidBrush(enterPen.Color), path);
                    g?.DrawPath(borderPen, path);
                    lblCaption.BackColor = enterPen.Color;
                    _isMouseInside = true;
                }
            }
            else
            {
                g?.FillPath(new SolidBrush(buttonPen.Color), path);
                g?.DrawPath(borderPen, path);
                lblCaption.BackColor = buttonPen.Color;
                _isMouseInside = false;
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
            path.AddArc(Width - CornerRadius * 2 - 2, 1, CornerRadius * 2, CornerRadius * 2, 270F, 90F);
            path.AddArc(Width - CornerRadius * 2 - 2, Height - CornerRadius * 2 - 2, CornerRadius * 2, CornerRadius * 2, 0F, 90F);
            path.AddArc(1, Height - CornerRadius * 2 - 2, CornerRadius * 2, CornerRadius * 2, 90F, 90F);
            path.CloseFigure();

            g.FillPath(new SolidBrush(ButtonColor), path);
            g.DrawPath(borderPen, path);
            lblCaption.BackColor = ButtonColor;
        }
    }
}
