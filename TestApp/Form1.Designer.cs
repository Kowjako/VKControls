
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vkFlatTextBox1 = new VKControls.TextBox.VKFlatTextBox();
            this.vkFlatButton1 = new VKControls.Buttons.VKFlatButton();
            this.vkCheckBox3 = new VKControls.VKCheckBox.VKCheckBox();
            this.vkCheckBox2 = new VKControls.VKCheckBox.VKCheckBox();
            this.vkCheckBox1 = new VKControls.VKCheckBox.VKCheckBox();
            this.vkProgressBar1 = new VKControls.VKProgressBar.VKProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vkFlatTextBox1
            // 
            this.vkFlatTextBox1.AutoSize = true;
            this.vkFlatTextBox1.LabelFont = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkFlatTextBox1.LabelText = "";
            this.vkFlatTextBox1.Location = new System.Drawing.Point(478, 29);
            this.vkFlatTextBox1.MinimumSize = new System.Drawing.Size(100, 21);
            this.vkFlatTextBox1.Name = "vkFlatTextBox1";
            this.vkFlatTextBox1.PasswordChar = '\0';
            this.vkFlatTextBox1.Size = new System.Drawing.Size(275, 21);
            this.vkFlatTextBox1.TabIndex = 16;
            // 
            // vkFlatButton1
            // 
            this.vkFlatButton1.BorderButtonBrush = System.Drawing.Color.Black;
            this.vkFlatButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("vkFlatButton1.ButtonImage")));
            this.vkFlatButton1.ButtonName = "Wykreuj bazę";
            this.vkFlatButton1.ButtonNameColor = System.Drawing.SystemColors.ControlText;
            this.vkFlatButton1.ButtonNameFont = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vkFlatButton1.FirstGradientColor = System.Drawing.Color.Maroon;
            this.vkFlatButton1.Location = new System.Drawing.Point(241, 12);
            this.vkFlatButton1.MaximumSize = new System.Drawing.Size(200, 170);
            this.vkFlatButton1.MinimumSize = new System.Drawing.Size(200, 170);
            this.vkFlatButton1.Name = "vkFlatButton1";
            this.vkFlatButton1.SecondGradientColor = System.Drawing.Color.Red;
            this.vkFlatButton1.Size = new System.Drawing.Size(200, 170);
            this.vkFlatButton1.TabIndex = 15;
            // 
            // vkCheckBox3
            // 
            this.vkCheckBox3.BackColor = System.Drawing.Color.White;
            this.vkCheckBox3.Location = new System.Drawing.Point(21, 138);
            this.vkCheckBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vkCheckBox3.Name = "vkCheckBox3";
            this.vkCheckBox3.Size = new System.Drawing.Size(263, 30);
            this.vkCheckBox3.TabIndex = 14;
            // 
            // vkCheckBox2
            // 
            this.vkCheckBox2.BackColor = System.Drawing.Color.White;
            this.vkCheckBox2.Location = new System.Drawing.Point(21, 100);
            this.vkCheckBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vkCheckBox2.Name = "vkCheckBox2";
            this.vkCheckBox2.Size = new System.Drawing.Size(263, 30);
            this.vkCheckBox2.TabIndex = 13;
            // 
            // vkCheckBox1
            // 
            this.vkCheckBox1.BackColor = System.Drawing.Color.White;
            this.vkCheckBox1.Location = new System.Drawing.Point(21, 62);
            this.vkCheckBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vkCheckBox1.Name = "vkCheckBox1";
            this.vkCheckBox1.Size = new System.Drawing.Size(263, 30);
            this.vkCheckBox1.TabIndex = 12;
            // 
            // vkProgressBar1
            // 
            this.vkProgressBar1.AutoSize = true;
            this.vkProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.vkProgressBar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vkProgressBar1.FillingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.vkProgressBar1.Location = new System.Drawing.Point(101, 274);
            this.vkProgressBar1.MaxValue = 100;
            this.vkProgressBar1.MinValue = 0;
            this.vkProgressBar1.Name = "vkProgressBar1";
            this.vkProgressBar1.Size = new System.Drawing.Size(91, 87);
            this.vkProgressBar1.TabIndex = 19;
            this.vkProgressBar1.Value = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1060, 696);
            this.Controls.Add(this.vkProgressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vkFlatTextBox1);
            this.Controls.Add(this.vkFlatButton1);
            this.Controls.Add(this.vkCheckBox3);
            this.Controls.Add(this.vkCheckBox2);
            this.Controls.Add(this.vkCheckBox1);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VKControls.VKCheckBox.VKCheckBox vkCheckBox1;
        private VKControls.VKCheckBox.VKCheckBox vkCheckBox2;
        private VKControls.VKCheckBox.VKCheckBox vkCheckBox3;
        private VKControls.Buttons.VKFlatButton vkFlatButton1;
        private VKControls.TextBox.VKFlatTextBox vkFlatTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private VKControls.VKProgressBar.VKProgressBar vkProgressBar1;
    }
}

