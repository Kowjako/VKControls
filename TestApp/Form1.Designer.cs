
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
            this.vkRoundedButton1 = new VKControls.VKButtons.VKRoundedButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vkRoundedButton1
            // 
            this.vkRoundedButton1.BorderColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.ButtonColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.Caption = "button1";
            this.vkRoundedButton1.CornerRadius = 20;
            this.vkRoundedButton1.EnterColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vkRoundedButton1.Location = new System.Drawing.Point(126, 436);
            this.vkRoundedButton1.Name = "vkRoundedButton1";
            this.vkRoundedButton1.Size = new System.Drawing.Size(207, 45);
            this.vkRoundedButton1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 696);
            this.Controls.Add(this.vkRoundedButton1);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton1;
    }
}

