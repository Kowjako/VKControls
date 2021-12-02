
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flatButton1 = new VKControls.Buttons.FlatButton();
            this.flatTextBox1 = new VKControls.TextBox.FlatTextBox();
            this.flatTextBox2 = new VKControls.TextBox.FlatTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // flatButton1
            // 
            this.flatButton1.BorderButtonBrush = System.Drawing.Color.Red;
            this.flatButton1.ButtonImage = null;
            this.flatButton1.ButtonName = "";
            this.flatButton1.ButtonNameColor = System.Drawing.SystemColors.ControlText;
            this.flatButton1.ButtonNameFont = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.FirstGradientColor = System.Drawing.Color.Black;
            this.flatButton1.Location = new System.Drawing.Point(12, 3);
            this.flatButton1.MaximumSize = new System.Drawing.Size(200, 170);
            this.flatButton1.MinimumSize = new System.Drawing.Size(200, 170);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.SecondGradientColor = System.Drawing.Color.White;
            this.flatButton1.Size = new System.Drawing.Size(200, 170);
            this.flatButton1.TabIndex = 0;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.AutoSize = true;
            this.flatTextBox1.LabelFont = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTextBox1.Location = new System.Drawing.Point(172, 354);
            this.flatTextBox1.MinimumSize = new System.Drawing.Size(100, 21);
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.Size = new System.Drawing.Size(458, 21);
            this.flatTextBox1.TabIndex = 9;
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.AutoSize = true;
            this.flatTextBox2.LabelFont = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTextBox2.Location = new System.Drawing.Point(172, 381);
            this.flatTextBox2.MinimumSize = new System.Drawing.Size(100, 21);
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.Size = new System.Drawing.Size(458, 21);
            this.flatTextBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flatTextBox2);
            this.Controls.Add(this.flatTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flatButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VKControls.Buttons.FlatButton flatButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VKControls.TextBox.FlatTextBox flatTextBox1;
        private VKControls.TextBox.FlatTextBox flatTextBox2;
    }
}

