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
        public FlatTextBox()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
