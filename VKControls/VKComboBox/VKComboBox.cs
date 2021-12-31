using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private BindingList<object> DataSourceBindingList = new BindingList<object>();
        public object SelectedItem { get; set; }
        public int SelectedIndex { get; set; }

        private Collection<string> _items = new Collection<string>();
        public Collection<string> Items
        {
            get => _items;
            set
            {
                if(value != null && value.Any())
                {
                    _items = value;
                    OnItemsSet();
                }
            }
        }

        public VKComboBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 5), mainPanel.ClientRectangle);
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
            SelectedIndex = 0;
            //selectedItemCaption.Text = (_dataSource.DataSource as IList<object>).First().ToString();
        }

        private void OnItemsSet()
        {
            selectedItemCaption.Text = Items.First();
        }

        private void SelectedItemChanged(object itemKey)
        {
            selectedItemCaption.Text = Items[(itemKey as int?).Value];
        }

        private void arrowBox_Click(object sender, EventArgs e)
        {
            var flp = new Panel();
            flp.Name = "DropDownList";
            flp.BorderStyle = BorderStyle.FixedSingle;
            flp.Left = Left;
            flp.Top = Top + Height;
            flp.Width = selectItemPanel.Width + 4;
            //flp.FlowDirection = FlowDirection.TopDown;
            //flp.WrapContents = false;
            flp.MaximumSize = new Size(Width, 22 * 5);
            


            var counter = 0; /* counter for Tag property */
            foreach(var item in Items)
            {
                var panelItem = new Panel();
                panelItem.Tag = counter++;
                panelItem.Padding = new Padding(0);
                panelItem.Margin = new Padding(0);
                panelItem.Height = 22;
                panelItem.Width = flp.Width;

                panelItem.Dock = DockStyle.Top;

                var labelItem = new Label();
                labelItem.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular);
                labelItem.Text = item.ToString();
                labelItem.AutoSize = true;
                panelItem.Controls.Add(labelItem);

                /* Initialize events for all drop-down items */
                panelItem.MouseEnter += delegate (object s, EventArgs args)
                {
                    panelItem.BackColor = Color.LightGray;
                };
                labelItem.MouseEnter += delegate (object s, EventArgs args)
                {
                    panelItem.BackColor = Color.LightGray;
                };
                panelItem.MouseLeave += delegate (object s, EventArgs args)
                {
                    panelItem.BackColor = flp.BackColor;
                };
                labelItem.MouseLeave += delegate (object s, EventArgs args)
                {
                    panelItem.BackColor = flp.BackColor;
                };
                panelItem.Click += delegate (object s, EventArgs args)
                {
                    SelectedItemChanged(panelItem.Tag);
                    Parent.Controls.RemoveByKey("DropDownList");
                };
                labelItem.Click += delegate (object s, EventArgs args)
                {
                    SelectedItemChanged(panelItem.Tag);
                    Parent.Controls.RemoveByKey("DropDownList");
                };

                flp.Height += 22;
                flp.Controls.Add(panelItem);
            }

            Parent.Controls.Add(flp);
            flp.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            /* Bedzie wywolane z OnPaint bo powoduje przerysowac caly Control */
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(Width - arrowBox.Width - 2, 0), new Point(Width - arrowBox.Width - 2, Height));
        }
    }
}
