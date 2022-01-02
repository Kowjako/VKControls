
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
            this.vkPanelHeader1 = new VKControls.VKPanelHeader.VKPanelHeader();
            this.vkFlatButtonWithImage1 = new VKControls.VKButtons.VKFlatButtonWithImage();
            this.vkRoundedButton1 = new VKControls.VKButtons.VKRoundedButton();
            this.vkCheckBox1 = new VKControls.VKCheckBox.VKCheckBox();
            this.vkCheckBox2 = new VKControls.VKCheckBox.VKCheckBox();
            this.vkComboBox1 = new VKControls.VKComboBox.VKComboBox();
            this.vkProgressBar1 = new VKControls.VKProgressBar.VKProgressBar();
            this.vkProgressBar2 = new VKControls.VKProgressBar.VKProgressBar();
            this.vkSwitch1 = new VKControls.VKSwitch.VKSwitch();
            this.vkSwitch2 = new VKControls.VKSwitch.VKSwitch();
            this.vkFlatTextBox1 = new VKControls.VKTextBox.VKFlatTextBox();
            this.vkFlatTextBox2 = new VKControls.VKTextBox.VKFlatTextBox();
            this.vkStepProgressBar1 = new VKControls.VKStepProgressBar.VKStepProgressBar();
            this.SuspendLayout();
            // 
            // vkPanelHeader1
            // 
            this.vkPanelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.vkPanelHeader1.HeaderColor = System.Drawing.Color.Green;
            this.vkPanelHeader1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vkPanelHeader1.HeaderText = "DemoApplication by VKControls";
            this.vkPanelHeader1.Location = new System.Drawing.Point(2, 0);
            this.vkPanelHeader1.Name = "vkPanelHeader1";
            this.vkPanelHeader1.Size = new System.Drawing.Size(460, 50);
            this.vkPanelHeader1.TabIndex = 5;
            this.vkPanelHeader1.MenuClick += new System.EventHandler(this.vkPanelHeader1_MenuClick);
            // 
            // vkFlatButtonWithImage1
            // 
            this.vkFlatButtonWithImage1.BorderButtonBrush = System.Drawing.Color.Black;
            this.vkFlatButtonWithImage1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("vkFlatButtonWithImage1.ButtonImage")));
            this.vkFlatButtonWithImage1.ButtonName = "Order";
            this.vkFlatButtonWithImage1.ButtonNameColor = System.Drawing.SystemColors.ControlText;
            this.vkFlatButtonWithImage1.ButtonNameFont = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkFlatButtonWithImage1.FirstGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vkFlatButtonWithImage1.Location = new System.Drawing.Point(12, 56);
            this.vkFlatButtonWithImage1.MaximumSize = new System.Drawing.Size(200, 170);
            this.vkFlatButtonWithImage1.MinimumSize = new System.Drawing.Size(200, 170);
            this.vkFlatButtonWithImage1.Name = "vkFlatButtonWithImage1";
            this.vkFlatButtonWithImage1.SecondGradientColor = System.Drawing.Color.Yellow;
            this.vkFlatButtonWithImage1.Size = new System.Drawing.Size(200, 170);
            this.vkFlatButtonWithImage1.TabIndex = 15;
            this.vkFlatButtonWithImage1.Click += new System.EventHandler(this.vkRoundedButton1_Load);
            // 
            // vkRoundedButton1
            // 
            this.vkRoundedButton1.BorderColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.ButtonColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.Caption = "Pay";
            this.vkRoundedButton1.CornerRadius = 20;
            this.vkRoundedButton1.EnterColor = System.Drawing.Color.Empty;
            this.vkRoundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vkRoundedButton1.Location = new System.Drawing.Point(12, 232);
            this.vkRoundedButton1.Name = "vkRoundedButton1";
            this.vkRoundedButton1.Size = new System.Drawing.Size(200, 45);
            this.vkRoundedButton1.TabIndex = 16;
            this.vkRoundedButton1.Load += new System.EventHandler(this.vkRoundedButton1_Load);
            // 
            // vkCheckBox1
            // 
            this.vkCheckBox1.BackColor = System.Drawing.Color.White;
            this.vkCheckBox1.Location = new System.Drawing.Point(218, 56);
            this.vkCheckBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vkCheckBox1.Name = "vkCheckBox1";
            this.vkCheckBox1.Size = new System.Drawing.Size(194, 30);
            this.vkCheckBox1.TabIndex = 17;
            this.vkCheckBox1.Title = "Male";
            // 
            // vkCheckBox2
            // 
            this.vkCheckBox2.BackColor = System.Drawing.Color.White;
            this.vkCheckBox2.Location = new System.Drawing.Point(299, 56);
            this.vkCheckBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vkCheckBox2.Name = "vkCheckBox2";
            this.vkCheckBox2.Size = new System.Drawing.Size(150, 30);
            this.vkCheckBox2.TabIndex = 18;
            this.vkCheckBox2.Title = "Female";
            // 
            // vkComboBox1
            // 
            this.vkComboBox1.AutoSize = true;
            this.vkComboBox1.Items = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("vkComboBox1.Items")));
            this.vkComboBox1.Location = new System.Drawing.Point(218, 89);
            this.vkComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.vkComboBox1.Name = "vkComboBox1";
            this.vkComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.vkComboBox1.SelectedIndex = 0;
            this.vkComboBox1.Size = new System.Drawing.Size(230, 27);
            this.vkComboBox1.TabIndex = 19;
            // 
            // vkProgressBar1
            // 
            this.vkProgressBar1.AutoSize = true;
            this.vkProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.vkProgressBar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vkProgressBar1.FillingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vkProgressBar1.Location = new System.Drawing.Point(218, 119);
            this.vkProgressBar1.MaxValue = 100;
            this.vkProgressBar1.MinValue = 0;
            this.vkProgressBar1.Name = "vkProgressBar1";
            this.vkProgressBar1.Size = new System.Drawing.Size(110, 107);
            this.vkProgressBar1.TabIndex = 20;
            this.vkProgressBar1.Value = 35;
            // 
            // vkProgressBar2
            // 
            this.vkProgressBar2.AutoSize = true;
            this.vkProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.vkProgressBar2.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vkProgressBar2.FillingColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.vkProgressBar2.Location = new System.Drawing.Point(339, 119);
            this.vkProgressBar2.MaxValue = 100;
            this.vkProgressBar2.MinValue = 0;
            this.vkProgressBar2.Name = "vkProgressBar2";
            this.vkProgressBar2.Size = new System.Drawing.Size(110, 107);
            this.vkProgressBar2.TabIndex = 21;
            this.vkProgressBar2.Value = 75;
            // 
            // vkSwitch1
            // 
            this.vkSwitch1.BorderColor = System.Drawing.Color.Green;
            this.vkSwitch1.ButtonColor = System.Drawing.Color.Brown;
            this.vkSwitch1.CornerRadius = 10;
            this.vkSwitch1.EnabledColor = System.Drawing.Color.Lime;
            this.vkSwitch1.Location = new System.Drawing.Point(12, 283);
            this.vkSwitch1.Name = "vkSwitch1";
            this.vkSwitch1.Size = new System.Drawing.Size(63, 26);
            this.vkSwitch1.TabIndex = 22;
            // 
            // vkSwitch2
            // 
            this.vkSwitch2.BorderColor = System.Drawing.Color.Green;
            this.vkSwitch2.ButtonColor = System.Drawing.Color.White;
            this.vkSwitch2.CornerRadius = 10;
            this.vkSwitch2.EnabledColor = System.Drawing.Color.Lime;
            this.vkSwitch2.Location = new System.Drawing.Point(92, 283);
            this.vkSwitch2.Name = "vkSwitch2";
            this.vkSwitch2.Size = new System.Drawing.Size(63, 26);
            this.vkSwitch2.TabIndex = 23;
            // 
            // vkFlatTextBox1
            // 
            this.vkFlatTextBox1.AutoSize = true;
            this.vkFlatTextBox1.LabelFont = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkFlatTextBox1.LabelText = "";
            this.vkFlatTextBox1.Location = new System.Drawing.Point(228, 232);
            this.vkFlatTextBox1.MinimumSize = new System.Drawing.Size(100, 21);
            this.vkFlatTextBox1.Name = "vkFlatTextBox1";
            this.vkFlatTextBox1.PasswordChar = '\0';
            this.vkFlatTextBox1.Size = new System.Drawing.Size(220, 28);
            this.vkFlatTextBox1.TabIndex = 24;
            // 
            // vkFlatTextBox2
            // 
            this.vkFlatTextBox2.AutoSize = true;
            this.vkFlatTextBox2.LabelFont = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkFlatTextBox2.LabelText = "";
            this.vkFlatTextBox2.Location = new System.Drawing.Point(228, 270);
            this.vkFlatTextBox2.MinimumSize = new System.Drawing.Size(100, 21);
            this.vkFlatTextBox2.Name = "vkFlatTextBox2";
            this.vkFlatTextBox2.PasswordChar = '\0';
            this.vkFlatTextBox2.Size = new System.Drawing.Size(220, 28);
            this.vkFlatTextBox2.TabIndex = 25;
            // 
            // vkStepProgressBar1
            // 
            this.vkStepProgressBar1.DoneStateColor = System.Drawing.Color.Purple;
            this.vkStepProgressBar1.EllipseColor = System.Drawing.Color.Gray;
            this.vkStepProgressBar1.LineColor = System.Drawing.Color.Gray;
            this.vkStepProgressBar1.Location = new System.Drawing.Point(12, 315);
            this.vkStepProgressBar1.Name = "vkStepProgressBar1";
            this.vkStepProgressBar1.Size = new System.Drawing.Size(436, 83);
            this.vkStepProgressBar1.StateNames = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("vkStepProgressBar1.StateNames")));
            this.vkStepProgressBar1.StatesCount = 4;
            this.vkStepProgressBar1.SuccessLineColor = System.Drawing.Color.Green;
            this.vkStepProgressBar1.TabIndex = 26;
            this.vkStepProgressBar1.WaitingStateColor = System.Drawing.Color.Green;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 410);
            this.Controls.Add(this.vkStepProgressBar1);
            this.Controls.Add(this.vkFlatTextBox2);
            this.Controls.Add(this.vkFlatTextBox1);
            this.Controls.Add(this.vkSwitch2);
            this.Controls.Add(this.vkSwitch1);
            this.Controls.Add(this.vkProgressBar2);
            this.Controls.Add(this.vkProgressBar1);
            this.Controls.Add(this.vkComboBox1);
            this.Controls.Add(this.vkCheckBox2);
            this.Controls.Add(this.vkCheckBox1);
            this.Controls.Add(this.vkRoundedButton1);
            this.Controls.Add(this.vkFlatButtonWithImage1);
            this.Controls.Add(this.vkPanelHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private VKControls.VKPanelHeader.VKPanelHeader vkPanelHeader1;
        private VKControls.VKButtons.VKFlatButtonWithImage vkFlatButtonWithImage1;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton1;
        private VKControls.VKCheckBox.VKCheckBox vkCheckBox1;
        private VKControls.VKCheckBox.VKCheckBox vkCheckBox2;
        private VKControls.VKComboBox.VKComboBox vkComboBox1;
        private VKControls.VKProgressBar.VKProgressBar vkProgressBar1;
        private VKControls.VKProgressBar.VKProgressBar vkProgressBar2;
        private VKControls.VKSwitch.VKSwitch vkSwitch1;
        private VKControls.VKSwitch.VKSwitch vkSwitch2;
        private VKControls.VKTextBox.VKFlatTextBox vkFlatTextBox1;
        private VKControls.VKTextBox.VKFlatTextBox vkFlatTextBox2;
        private VKControls.VKStepProgressBar.VKStepProgressBar vkStepProgressBar1;
    }
}

