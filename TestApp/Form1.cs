using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vkPanelHeader1_MenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO WORLD");
        }

        private void vkRoundedButton1_Load(object sender, EventArgs e)
        {
            vkStepProgressBar1.SetStepState(VKControls.VKStepProgressBar.StepState.Waiting);
            vkStepProgressBar1.SetStepState(VKControls.VKStepProgressBar.StepState.Done);
        }
    }
}
