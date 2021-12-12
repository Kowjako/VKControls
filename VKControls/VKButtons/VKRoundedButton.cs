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
        public string Caption
        {
            get => lblCaption.Text;
            set => lblCaption.Text = value;
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

        public new Color BackColor
        {
            get => mainPanel.BackColor;
            set => mainPanel.BackColor = value;
        }

        public int CornerRadius { get; set; } = 10;

        public event Action OnFontOrResizeChanged;

        private Graphics g;

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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            g = mainPanel.CreateGraphics();
            g.FillRectangle(new SolidBrush(BackColor), mainPanel.ClientRectangle);
            g.DrawArc(new Pen(new SolidBrush(Color.Black)),
                              new Rectangle(0, 0, CornerRadius * 2, CornerRadius * 2), 180F, 90F);
            g.DrawArc(new Pen(new SolidBrush(Color.Black)),
                              new Rectangle(Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2), 270F, 90F);
            g.DrawArc(new Pen(new SolidBrush(Color.Black)),
                              new Rectangle(Width - CornerRadius * 2, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2), 0F, 90F);
            g.DrawArc(new Pen(new SolidBrush(Color.Black)),
                              new Rectangle(0, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2), 90F, 90F);
        }

        private void mainPanel_BackColorChanged(object sender, EventArgs e)
        {
            lblCaption.BackColor = mainPanel.BackColor;
        }
    }
}
