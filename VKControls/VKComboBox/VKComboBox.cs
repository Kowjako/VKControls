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

namespace VKControls.VKComboBox
{
    public partial class VKComboBox : UserControl
    {
        private Graphics g;

        private BindingSource _dataSource;
        public BindingSource DataSource
        {
            get => _dataSource;
            set
            {
                _dataSource = value;
                OnDataSourceSet();
            }
        }

        public VKComboBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = mainPanel.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black, 2), mainPanel.ClientRectangle);
            g.DrawLine(new Pen(Color.Black, 1), new Point(Width - arrowBox.Width - 2, 0), new Point(Width - arrowBox.Width - 2, Height));
            selectedItemCaption.BackColor = BackColor;
        }

        private void arrowBox_MouseEnter(object sender, EventArgs e)
        {
            arrowBox.BackColor = Color.LightGray;
            arrowPanel.BackColor = Color.LightGray;
        }

        private void arrowBox_MouseLeave(object sender, EventArgs e)
        {
            arrowBox.BackColor = Color.White;
            arrowPanel.BackColor = Color.White;
        }

        private void OnDataSourceSet()
        {

        }
    }
}
