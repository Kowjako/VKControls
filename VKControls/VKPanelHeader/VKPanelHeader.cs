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

        public VKPanelHeader()
        {
            InitializeComponent();
        }

        public Color HeaderColor { get; set; } = Color.Black;

        public string HeaderText { get; set; }

        public Font HeaderFont { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            mainPanel.BackColor = HeaderColor;
            headerLabel.Text = HeaderText;
            headerLabel.Font = HeaderFont;

            headerLabel.Top = (Height - headerLabel.Height) / 2;
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
    }
}
