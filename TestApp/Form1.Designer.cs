
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vkFlatButtonWithImage1 = new VKControls.VKButtons.VKFlatButtonWithImage();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vkFlatButtonWithImage1
            // 
            this.vkFlatButtonWithImage1.BorderButtonBrush = System.Drawing.Color.Black;
            this.vkFlatButtonWithImage1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("vkFlatButtonWithImage1.ButtonImage")));
            this.vkFlatButtonWithImage1.ButtonName = "Angular 6";
            this.vkFlatButtonWithImage1.ButtonNameColor = System.Drawing.SystemColors.ControlText;
            this.vkFlatButtonWithImage1.ButtonNameFont = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkFlatButtonWithImage1.FirstGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vkFlatButtonWithImage1.Location = new System.Drawing.Point(12, 12);
            this.vkFlatButtonWithImage1.MaximumSize = new System.Drawing.Size(200, 170);
            this.vkFlatButtonWithImage1.MinimumSize = new System.Drawing.Size(200, 170);
            this.vkFlatButtonWithImage1.Name = "vkFlatButtonWithImage1";
            this.vkFlatButtonWithImage1.SecondGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vkFlatButtonWithImage1.Size = new System.Drawing.Size(200, 170);
            this.vkFlatButtonWithImage1.TabIndex = 0;
            this.vkFlatButtonWithImage1.Click += new System.EventHandler(this.vkFlatButtonWithImage1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 696);
            this.Controls.Add(this.vkFlatButtonWithImage1);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private VKControls.VKButtons.VKFlatButtonWithImage vkFlatButtonWithImage1;
    }
}

