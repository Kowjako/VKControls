
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vkRoundedButton3 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton2 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton1 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton4 = new VKControls.VKButtons.VKRoundedButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vkRoundedButton3
            // 
            this.vkRoundedButton3.Caption = "button1";
            this.vkRoundedButton3.CornerRadius = 10;
            this.vkRoundedButton3.Location = new System.Drawing.Point(232, 408);
            this.vkRoundedButton3.Name = "vkRoundedButton3";
            this.vkRoundedButton3.Size = new System.Drawing.Size(357, 150);
            this.vkRoundedButton3.TabIndex = 2;
            // 
            // vkRoundedButton2
            // 
            this.vkRoundedButton2.Caption = "button1";
            this.vkRoundedButton2.CornerRadius = 10;
            this.vkRoundedButton2.Location = new System.Drawing.Point(194, 317);
            this.vkRoundedButton2.Name = "vkRoundedButton2";
            this.vkRoundedButton2.Size = new System.Drawing.Size(226, 33);
            this.vkRoundedButton2.TabIndex = 1;
            // 
            // vkRoundedButton1
            // 
            this.vkRoundedButton1.Caption = "button1";
            this.vkRoundedButton1.CornerRadius = 10;
            this.vkRoundedButton1.Location = new System.Drawing.Point(232, 395);
            this.vkRoundedButton1.Name = "vkRoundedButton1";
            this.vkRoundedButton1.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton1.TabIndex = 0;
            // 
            // vkRoundedButton4
            // 
            this.vkRoundedButton4.Caption = "button1";
            this.vkRoundedButton4.CornerRadius = 20;
            this.vkRoundedButton4.Location = new System.Drawing.Point(382, 305);
            this.vkRoundedButton4.Name = "vkRoundedButton4";
            this.vkRoundedButton4.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1060, 696);
            this.Controls.Add(this.vkRoundedButton4);
            this.Controls.Add(this.vkRoundedButton3);
            this.Controls.Add(this.vkRoundedButton2);
            this.Controls.Add(this.vkRoundedButton1);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton1;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton2;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton3;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton4;
    }
}

