
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flatButton1 = new VKControls.Buttons.FlatButton();
            this.flatButton2 = new VKControls.Buttons.FlatButton();
            this.vkCheckBox1 = new VKControls.VKCheckBox.VKCheckBox();
            this.SuspendLayout();
            // 
            // flatButton1
            // 
            this.flatButton1.BorderButtonBrush = System.Drawing.Color.Black;
            this.flatButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("flatButton1.ButtonImage")));
            this.flatButton1.ButtonName = "Wykreuj bazę";
            this.flatButton1.ButtonNameColor = System.Drawing.SystemColors.ButtonFace;
            this.flatButton1.ButtonNameFont = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.FirstGradientColor = System.Drawing.Color.Red;
            this.flatButton1.Location = new System.Drawing.Point(12, 12);
            this.flatButton1.MaximumSize = new System.Drawing.Size(200, 170);
            this.flatButton1.MinimumSize = new System.Drawing.Size(200, 170);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.SecondGradientColor = System.Drawing.Color.Maroon;
            this.flatButton1.Size = new System.Drawing.Size(200, 170);
            this.flatButton1.TabIndex = 11;
            // 
            // flatButton2
            // 
            this.flatButton2.BorderButtonBrush = System.Drawing.Color.Black;
            this.flatButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("flatButton2.ButtonImage")));
            this.flatButton2.ButtonName = "Zarządzaj bazą";
            this.flatButton2.ButtonNameColor = System.Drawing.SystemColors.ButtonFace;
            this.flatButton2.ButtonNameFont = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton2.FirstGradientColor = System.Drawing.Color.Blue;
            this.flatButton2.Location = new System.Drawing.Point(230, 12);
            this.flatButton2.MaximumSize = new System.Drawing.Size(200, 170);
            this.flatButton2.MinimumSize = new System.Drawing.Size(200, 170);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.SecondGradientColor = System.Drawing.Color.MidnightBlue;
            this.flatButton2.Size = new System.Drawing.Size(200, 170);
            this.flatButton2.TabIndex = 10;
            // 
            // vkCheckBox1
            // 
            this.vkCheckBox1.BackColor = System.Drawing.Color.White;
            this.vkCheckBox1.Location = new System.Drawing.Point(117, 338);
            this.vkCheckBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vkCheckBox1.Name = "vkCheckBox1";
            this.vkCheckBox1.Size = new System.Drawing.Size(270, 32);
            this.vkCheckBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vkCheckBox1);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.flatButton2);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);

        }

        #endregion
        private VKControls.Buttons.FlatButton flatButton2;
        private VKControls.Buttons.FlatButton flatButton1;
        private VKControls.VKCheckBox.VKCheckBox vkCheckBox1;
    }
}

