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
    public partial class VKFlatButtonWithImage : UserControl
    {
        public VKFlatButtonWithImage()
        {
            InitializeComponent();
            GradientMode = LinearGradientMode.ForwardDiagonal;
        }

        private LinearGradientMode GradientMode;

        public Color FirstGradientColor { get; set; }
        public Color SecondGradientColor { get; set; }

        public string ButtonName
        {
            get
            {
                return txtName.Text;
            }
            set => txtName.Text = value;
        }

        public Color ButtonNameColor
        {
            get
            {
                return txtName.ForeColor;
            }
            set
            {
                txtName.ForeColor = value;
            }
        }

        public Font ButtonNameFont
        {
            get
            {
                return txtName.Font;
            }
            set
            {
                txtName.Font = value;
            }
        }

        public Image ButtonImage
        {
            set
            {

                btnImage.Image = value;
            }
            get
            {
                return btnImage.Image;
            }
        }

        public Color BorderButtonBrush
        {
            get
            {
                return panelBottom.BackColor;
            }
            set
            {
                panelBottom.BackColor = value;
                panelLeft.BackColor = value;
                panelRight.BackColor = value;
                panelTop.BackColor = value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                txtName.Click += value;
                btnImage.Click += value;
            }
            remove
            {
                base.Click -= value;
                txtName.Click -= value;
                btnImage.Click -= value;
            }
        }

        private void FlatButton_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(this.ClientRectangle,
                                                      FirstGradientColor,
                                                      SecondGradientColor,
                                                      GradientMode))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnImage_MouseEnter(object sender, EventArgs e)
        {
            GradientMode = LinearGradientMode.BackwardDiagonal;
            this.BackColor = Color.White;
        }

        private void btnImage_MouseLeave(object sender, EventArgs e)
        {
            GradientMode = LinearGradientMode.ForwardDiagonal;
            this.BackColor = Color.Black;
        }

        private void btnImage_MouseDown(object sender, MouseEventArgs e)
        {
            txtName.Font = new Font(txtName.Font, FontStyle.Bold);
            SwapColors();
            InvalidateControl();
        }

        private void btnImage_MouseUp(object sender, MouseEventArgs e)
        {
            txtName.Font = new Font(txtName.Font, FontStyle.Regular);
            SwapColors();
            InvalidateControl();
        }

        private void InvalidateControl()
        {
            OnPaintBackground(new PaintEventArgs(this.CreateGraphics(), ClientRectangle));
            this.Invalidate();
        }

        private void SwapColors()
        {
            var tmpColor = SecondGradientColor;
            SecondGradientColor = FirstGradientColor;
            FirstGradientColor = tmpColor;
        }
    }
}
