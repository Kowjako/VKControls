
namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vkComboBox1 = new VKControls.VKComboBox.VKComboBox();
            this.SuspendLayout();
            // 
            // vkComboBox1
            // 
            this.vkComboBox1.Location = new System.Drawing.Point(163, 282);
            this.vkComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.vkComboBox1.Name = "vkComboBox1";
            this.vkComboBox1.Size = new System.Drawing.Size(691, 31);
            this.vkComboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 696);
            this.Controls.Add(this.vkComboBox1);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);

        }

        #endregion
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton1;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton2;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton3;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton4;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton5;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton6;
        private VKControls.VKComboBox.VKComboBox vkComboBox1;
    }
}

