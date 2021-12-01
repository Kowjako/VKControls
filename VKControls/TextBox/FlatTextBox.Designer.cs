
namespace VKControls.TextBox
{
    partial class FlatTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Silver;
            this.panel.Location = new System.Drawing.Point(0, 22);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(284, 2);
            this.panel.TabIndex = 1;
            this.panel.Click += new System.EventHandler(this.textBox1_Click);
            this.panel.Enter += new System.EventHandler(this.txtText_Enter);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseDown);
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.SystemColors.Control;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(1, 2);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(281, 16);
            this.txtText.TabIndex = 2;
            this.txtText.Click += new System.EventHandler(this.textBox1_Click);
            this.txtText.Enter += new System.EventHandler(this.txtText_Enter);
            this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
            this.txtText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseDown);
            // 
            // FlatTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.panel);
            this.Name = "FlatTextBox";
            this.Size = new System.Drawing.Size(286, 27);
            this.Click += new System.EventHandler(this.textBox1_Click);
            this.Enter += new System.EventHandler(this.txtText_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtText;
    }
}
