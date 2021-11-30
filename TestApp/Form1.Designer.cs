
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
            this.flatTextBox1 = new VKControls.TextBox.FlatTextBox();
            this.SuspendLayout();
            // 
            // flatButton1
            // 
            this.flatButton1.BorderButtonBrush = System.Drawing.Color.Black;
            this.flatButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("flatButton1.ButtonImage")));
            this.flatButton1.ButtonName = "Paragony";
            this.flatButton1.ButtonNameColor = System.Drawing.Color.White;
            this.flatButton1.ButtonNameFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flatButton1.FirstGradientColor = System.Drawing.Color.Blue;
            this.flatButton1.Location = new System.Drawing.Point(29, 12);
            this.flatButton1.MaximumSize = new System.Drawing.Size(200, 170);
            this.flatButton1.MinimumSize = new System.Drawing.Size(200, 170);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.SecondGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flatButton1.Size = new System.Drawing.Size(200, 170);
            this.flatButton1.TabIndex = 0;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.Location = new System.Drawing.Point(55, 232);
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.Size = new System.Drawing.Size(284, 38);
            this.flatTextBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flatTextBox1);
            this.Controls.Add(this.flatButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private VKControls.Buttons.FlatButton flatButton1;
        private VKControls.TextBox.FlatTextBox flatTextBox1;
    }
}

