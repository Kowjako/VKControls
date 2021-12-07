using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKControls.Properties;

namespace VKControls.VKCheckBox
{
    public partial class VKCheckBox : UserControl
    {
        private bool _isChecked = false;

        public VKCheckBox()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new string Text
        {
            get => tbTitle.Text;
            set => tbTitle.Text = value;
        }


        private void pbStatus_Click(object sender, EventArgs e)
        {
            _isChecked = !_isChecked;
            pbStatus.Image = _isChecked ? (Image)Resources._checked
                                        : (Image)Resources._unchecked;

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            pbStatus.Location = new Point(0, 0);
            pbStatus.Height = Height;
            pbStatus.Width = pbStatus.Height;
            tbTitle.Left = pbStatus.Width + 5;
            tbTitle.Width = Width - pbStatus.Width - 10;
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            pbStatus.BackColor = Parent.BackColor;
            panel1.BackColor = Parent.BackColor;
            tbTitle.BackColor = Parent.BackColor;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            pbStatus.BackColor = Parent.BackColor;
            panel1.BackColor = Parent.BackColor;
            tbTitle.BackColor = Parent.BackColor;
        }

    }
}
