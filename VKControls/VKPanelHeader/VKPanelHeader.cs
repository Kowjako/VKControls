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

        private bool _isMenuOpened = false;
        private readonly Timer Timer = new Timer { Interval = 1 };
        private const float _fullAngle = 180.0F;
        private float _actualAngle = 0.0F;
        private Image _menuImage;

        public VKPanelHeader()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            Timer.Tick += MenuBoxRotate;
            _menuImage = bMenu.Image.Clone() as Image;
        }

        /* EventHandler to handle menu button click */
        public event EventHandler MenuClick
        {
            add
            {
                bMenu.Click += value;
            }
            remove
            {
                bMenu.Click -= value;
            }
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

        private void bMenu_Click(object sender, EventArgs e)
        {
            Timer.Start();
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

        private void MenuBoxRotate(object sender, EventArgs e)
        {
            _actualAngle += 5;
            bMenu.Image = _isMenuOpened ? RotateImage(bMenu.Image, 5) : RotateImage(bMenu.Image, -5);

            if (_actualAngle.Equals(_fullAngle))
            {
                _actualAngle = 0;
                _isMenuOpened = !_isMenuOpened;
                bMenu.Image = _menuImage;
                Timer.Stop();
            }
        }

        private Bitmap RotateImage(Image img, float angle)
        {
            var bitmap = new Bitmap(img.Width, img.Height);
            bitmap.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            var graphics = Graphics.FromImage(bitmap);
            graphics.TranslateTransform(img.Width / 2, img.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-img.Width / 2, -img.Height / 2);
            graphics.DrawImage(img, new PointF(0,0));
            return bitmap;
        }
    }
}
