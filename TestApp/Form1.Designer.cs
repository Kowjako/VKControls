
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
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vkComboBox1 = new VKControls.VKComboBox.VKComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // vkComboBox1
            // 
            this.vkComboBox1.DataSource = null;
            this.vkComboBox1.Items = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("vkComboBox1.Items")));
            this.vkComboBox1.Location = new System.Drawing.Point(257, 167);
            this.vkComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.vkComboBox1.Name = "vkComboBox1";
            this.vkComboBox1.SelectedIndex = 0;
            this.vkComboBox1.SelectedItem = null;
            this.vkComboBox1.Size = new System.Drawing.Size(246, 31);
            this.vkComboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vkComboBox1);
            this.Name = "Form1";
            this.Text = "Testowa platforma";
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton1;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton2;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton3;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton4;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton5;
        private VKControls.VKButtons.VKRoundedButton vkRoundedButton6;
        private System.Windows.Forms.BindingSource bsData;
        private VKControls.VKComboBox.VKComboBox vkComboBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

