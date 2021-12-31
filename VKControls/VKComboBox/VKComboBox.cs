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

        private object _dataSource;

        /* Ten atrybut pozwala podpinac BindingSource do DataSource */
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get => _dataSource;
            set
            {
                if (value != null)
                {
                    _dataSource = value;
                    OnDataSourceSet();
                }
            }
        }

        [Browsable(false)]
        public object SelectedItem => (_dataSource as IEnumerable<object>).ElementAt(SelectedIndex);
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

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                selectedItemCaption.Font = value;
            }
        }

        public VKComboBox()
        {
            InitializeComponent();
            DataSource = new BindingSource();
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
            /* Pattern-matching */
            if(_dataSource is IEnumerable<object> var)
            {
                Items = new Collection<string>(var.Select(x => x.ToString()).ToList());
                SelectedIndex = 0;
                selectedItemCaption.Text = var.First().ToString();
            }
        }

        private void OnItemsSet()
        {
            selectedItemCaption.Text = Items.First().ToString();
        }

        private void SelectedItemChanged(Panel item)
        {
            selectedItemCaption.Text = Items[(item.Tag as int?).Value].ToString();
            SelectedIndex = (item.Tag as int?).Value;
        }

        private void arrowBox_Click(object sender, EventArgs e)
        {
            var flp = new Panel();
            flp.Name = "DropDownList";
            flp.BorderStyle = BorderStyle.FixedSingle;
            flp.Left = Left;
            flp.Top = Top + Height - 1;
            flp.Width = selectItemPanel.Width + 4;
            flp.Height = 0;

            flp.MaximumSize = new Size(Width, 22 * 5);
            flp.HorizontalScroll.Enabled = false;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;

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
                    SelectedItemChanged(panelItem);
                    Parent.Controls.RemoveByKey("DropDownList");
                };
                labelItem.Click += delegate (object s, EventArgs args)
                {
                    SelectedItemChanged(panelItem);
                    Parent.Controls.RemoveByKey("DropDownList");
                };

                flp.Height += 22;
                flp.Controls.Add(panelItem);
            }

            Parent.Controls.Add(flp);
            Parent.Controls.SetChildIndex(flp, -1);
            flp.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            /* Bedzie wywolane z OnPaint bo powoduje przerysowac caly Control */
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(Width - arrowBox.Width - 2, 0), new Point(Width - arrowBox.Width - 2, Height));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            arrowPanel.Size = new Size(Height, Height);
            selectItemPanel.Size = new Size(Width - arrowPanel.Width - 5, Height);
            selectedItemCaption.Left = 5;
            selectedItemCaption.Top = Math.Abs(selectItemPanel.Height - selectedItemCaption.Height) / 2;
        }
    }
}
