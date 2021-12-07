using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKControls.TextBox
{
    public partial class FlatTextBox : UserControl
    {
        private readonly Timer AnimationTimer = new Timer { Interval = 1 };
        private AnimationDirections AnimationDirection;
        private Graphics panelGraphics;
        private int AnimationOffset = 0;

        public FlatTextBox()
        {
            InitializeComponent();
            this.MinimumSize = new Size(100, Height);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AnimationTimer.Tick += AnimationTimer_Tick;
            panelGraphics = panel.CreateGraphics();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtText.Focus();
        }

        /* Przy tworzeniu kontrolki BackColor textbox'a ustawiamy na kolor rodzica */
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            txtText.BackColor = ParentForm.BackColor;
        }

        /* Gdy zmieniamy BackColor rodzica automatycznie zmieniamy kolor textBox'a */
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            txtText.BackColor = Parent.BackColor;
        }

        public char PasswordChar
        {
            set => txtText.PasswordChar = value;
            get => txtText.PasswordChar;
        }

        public Font LabelFont
        {
            get => txtText.Font;
            set
            {
                txtText.Font = value;
            }
        }

        public string LabelText
        {
            get => txtText.Text;
            set => txtText.Text = value;
        }

        private void txtText_MouseDown(object sender, MouseEventArgs e)
        {
            AnimationDirection = AnimationDirections.Enter;
            AnimationTimer.Start();
        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            AnimationDirection = AnimationDirections.Leave;
            AnimationTimer.Start();
        }

        private void txtText_Enter(object sender, EventArgs e)
        {
            AnimationDirection = AnimationDirections.Enter;
            AnimationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Rectangle r = panel.ClientRectangle;
            switch (AnimationDirection)
            {
                case AnimationDirections.Enter:
                    if(r.Width/2 - AnimationOffset > 0)
                    {
                        AnimationOffset += r.Width / 20;
                        Rectangle transformedRectanlge = new Rectangle(r.Width/2 - AnimationOffset, 0, AnimationOffset * 2, 2);
                        panelGraphics.FillRectangle(new SolidBrush(Color.Purple), transformedRectanlge);
                    }
                    else
                    {
                        AnimationTimer.Stop();
                        AnimationOffset = 0;
                        panel.BackColor = Color.Purple;
                        panel.Invalidate();
                    }
                    break;
                case AnimationDirections.Leave:
                    if (r.Width / 2 >= AnimationOffset)
                    {
                        Rectangle transformedRectanlgeFront = new Rectangle(0, 0, AnimationOffset, 2);
                        Rectangle transformedRectanlgeBack = new Rectangle(r.Width - AnimationOffset, 0, r.Width, 2);
                        panelGraphics.FillRectangle(new SolidBrush(Color.Silver), transformedRectanlgeFront);
                        panelGraphics.FillRectangle(new SolidBrush(Color.Silver), transformedRectanlgeBack);
                        AnimationOffset += r.Width / 20;
                    }
                    else
                    {
                        AnimationTimer.Stop();
                        AnimationOffset = 0;
                        panel.BackColor = Color.Silver;
                        panel.Invalidate();
                    }
                    break;
                default:
                    break;
            } 
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Height = this.txtText.Height + 5; /* prevent Heigth resizing by User */
        }

        /* Hidden properties from UserControl */
        [Browsable(false)]
        public new Font Font { get; set; }
    }
}
