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
        protected const short offset = 1;
        protected const short txtOffset = 2;

        private int prevTextBoxHeight;

        public FlatTextBox()
        {
            InitializeComponent();
            prevTextBoxHeight = txtText.Height;
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

        public Font LabelFont
        {
            get => txtText.Font;
            set
            {
                txtText.Font = value;
                OnLabelFontChanged();
            }
        }

        private void txtText_MouseDown(object sender, MouseEventArgs e)
        {
            panel.BackColor = Color.Purple;
        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            panel.BackColor = Color.Silver;
        }

        private void txtText_Enter(object sender, EventArgs e)
        {
            panel.BackColor = Color.Purple;
        }

        private void OnLabelFontChanged()
        {
            this.panel.Top = txtText.Height + txtOffset;
            this.Height = this.panel.Top + this.panel.Height + offset;
            prevTextBoxHeight = txtText.Height;
        }
    }
}
