
namespace VKControls.Buttons
{
    partial class FlatButton
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
            this.btnImage = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.BackColor = System.Drawing.Color.Transparent;
            this.btnImage.Location = new System.Drawing.Point(49, 24);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(101, 100);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnImage.TabIndex = 0;
            this.btnImage.TabStop = false;
            this.btnImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseDown);
            this.btnImage.MouseEnter += new System.EventHandler(this.btnImage_MouseEnter);
            this.btnImage.MouseLeave += new System.EventHandler(this.btnImage_MouseLeave);
            this.btnImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseUp);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(15, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseDown);
            this.txtName.MouseEnter += new System.EventHandler(this.btnImage_MouseEnter);
            this.txtName.MouseLeave += new System.EventHandler(this.btnImage_MouseLeave);
            this.txtName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseUp);
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(2, 170);
            this.panelLeft.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(2, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(198, 2);
            this.panelTop.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(2, 168);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(198, 2);
            this.panelBottom.TabIndex = 4;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(198, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2, 166);
            this.panelRight.TabIndex = 5;
            // 
            // FlatButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnImage);
            this.MaximumSize = new System.Drawing.Size(200, 170);
            this.MinimumSize = new System.Drawing.Size(200, 170);
            this.Name = "FlatButton";
            this.Size = new System.Drawing.Size(200, 170);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseDown);
            this.MouseEnter += new System.EventHandler(this.btnImage_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.btnImage_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseUp);
            this.Resize += new System.EventHandler(this.FlatButton_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnImage;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelRight;
    }
}
