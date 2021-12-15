
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
            this.vkRoundedButton5 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton4 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton3 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton2 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton1 = new VKControls.VKButtons.VKRoundedButton();
            this.vkRoundedButton6 = new VKControls.VKButtons.VKRoundedButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vkRoundedButton5
            // 
            this.vkRoundedButton5.BorderColor = System.Drawing.Color.Red;
            this.vkRoundedButton5.ButtonColor = System.Drawing.Color.Empty;
            this.vkRoundedButton5.Caption = "button1";
            this.vkRoundedButton5.CornerRadius = 10;
            this.vkRoundedButton5.Location = new System.Drawing.Point(316, 484);
            this.vkRoundedButton5.Name = "vkRoundedButton5";
            this.vkRoundedButton5.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton5.TabIndex = 4;
            // 
            // vkRoundedButton4
            // 
            this.vkRoundedButton4.BorderColor = System.Drawing.Color.Empty;
            this.vkRoundedButton4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.vkRoundedButton4.Caption = "button1";
            this.vkRoundedButton4.CornerRadius = 20;
            this.vkRoundedButton4.Location = new System.Drawing.Point(395, 341);
            this.vkRoundedButton4.Name = "vkRoundedButton4";
            this.vkRoundedButton4.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton4.TabIndex = 3;
            // 
            // vkRoundedButton3
            // 
            this.vkRoundedButton3.BorderColor = System.Drawing.Color.Empty;
            this.vkRoundedButton3.ButtonColor = System.Drawing.Color.Empty;
            this.vkRoundedButton3.Caption = "button1";
            this.vkRoundedButton3.CornerRadius = 20;
            this.vkRoundedButton3.Location = new System.Drawing.Point(135, 341);
            this.vkRoundedButton3.Name = "vkRoundedButton3";
            this.vkRoundedButton3.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton3.TabIndex = 2;
            // 
            // vkRoundedButton2
            // 
            this.vkRoundedButton2.BorderColor = System.Drawing.Color.Empty;
            this.vkRoundedButton2.ButtonColor = System.Drawing.Color.Empty;
            this.vkRoundedButton2.Caption = "button1";
            this.vkRoundedButton2.CornerRadius = 20;
            this.vkRoundedButton2.Location = new System.Drawing.Point(151, 499);
            this.vkRoundedButton2.Name = "vkRoundedButton2";
            this.vkRoundedButton2.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton2.TabIndex = 1;
            // 
            // vkRoundedButton1
            // 
            this.vkRoundedButton1.BorderColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.ButtonColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.Caption = "button1";
            this.vkRoundedButton1.CornerRadius = 20;
            this.vkRoundedButton1.Location = new System.Drawing.Point(109, 218);
            this.vkRoundedButton1.Name = "vkRoundedButton1";
            this.vkRoundedButton1.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton1.TabIndex = 0;
            // 
            // vkRoundedButton6
            // 
            this.vkRoundedButton6.BorderColor = System.Drawing.Color.Black;
            this.vkRoundedButton6.ButtonColor = System.Drawing.Color.Silver;
            this.vkRoundedButton6.Caption = "button1";
            this.vkRoundedButton6.CornerRadius = 20;
            this.vkRoundedButton6.Location = new System.Drawing.Point(151, 603);
            this.vkRoundedButton6.Name = "vkRoundedButton6";
            this.vkRoundedButton6.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton6.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1089, 696);
            this.Controls.Add(this.vkRoundedButton6);
            this.Controls.Add(this.vkRoundedButton5);
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
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton5;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton6;
    }
}

