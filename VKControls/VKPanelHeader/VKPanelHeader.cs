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
        public VKPanelHeader()
        {
            InitializeComponent();
        }

        public Color HeaderColor { get; set; } = Color.Black;

        public string HeaderText { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            mainPanel.BackColor = HeaderColor;
            headerLabel.Text = HeaderText;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
