
namespace VKControls.VKComboBox
{
    partial class VKComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VKComboBox));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.selectItemPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.arrowBox = new System.Windows.Forms.PictureBox();
            this.arrowPanel = new System.Windows.Forms.Panel();
            this.selectedItemCaption = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.selectItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).BeginInit();
            this.arrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.arrowPanel);
            this.mainPanel.Controls.Add(this.selectItemPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(1);
            this.mainPanel.Size = new System.Drawing.Size(246, 31);
            this.mainPanel.TabIndex = 0;
            // 
            // selectItemPanel
            // 
            this.selectItemPanel.Controls.Add(this.selectedItemCaption);
            this.selectItemPanel.Controls.Add(this.bottomPanel);
            this.selectItemPanel.Controls.Add(this.topPanel);
            this.selectItemPanel.Controls.Add(this.rightPanel);
            this.selectItemPanel.Controls.Add(this.leftPanel);
            this.selectItemPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectItemPanel.Location = new System.Drawing.Point(1, 1);
            this.selectItemPanel.Name = "selectItemPanel";
            this.selectItemPanel.Size = new System.Drawing.Size(208, 29);
            this.selectItemPanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(1, 28);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(206, 1);
            this.bottomPanel.TabIndex = 3;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(1, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(206, 1);
            this.topPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(207, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1, 29);
            this.rightPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1, 29);
            this.leftPanel.TabIndex = 0;
            // 
            // arrowBox
            // 
            this.arrowBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrowBox.Image = ((System.Drawing.Image)(resources.GetObject("arrowBox.Image")));
            this.arrowBox.Location = new System.Drawing.Point(0, 0);
            this.arrowBox.Margin = new System.Windows.Forms.Padding(0);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(33, 29);
            this.arrowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowBox.TabIndex = 0;
            this.arrowBox.TabStop = false;
            this.arrowBox.MouseEnter += new System.EventHandler(this.arrowBox_MouseEnter);
            this.arrowBox.MouseLeave += new System.EventHandler(this.arrowBox_MouseLeave);
            // 
            // arrowPanel
            // 
            this.arrowPanel.Controls.Add(this.arrowBox);
            this.arrowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.arrowPanel.Location = new System.Drawing.Point(212, 1);
            this.arrowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.arrowPanel.Name = "arrowPanel";
            this.arrowPanel.Size = new System.Drawing.Size(33, 29);
            this.arrowPanel.TabIndex = 2;
            // 
            // selectedItemCaption
            // 
            this.selectedItemCaption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedItemCaption.Enabled = false;
            this.selectedItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedItemCaption.Location = new System.Drawing.Point(5, 5);
            this.selectedItemCaption.Name = "selectedItemCaption";
            this.selectedItemCaption.ReadOnly = true;
            this.selectedItemCaption.Size = new System.Drawing.Size(200, 19);
            this.selectedItemCaption.TabIndex = 4;
            // 
            // VKComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VKComboBox";
            this.Size = new System.Drawing.Size(246, 31);
            this.mainPanel.ResumeLayout(false);
            this.selectItemPanel.ResumeLayout(false);
            this.selectItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).EndInit();
            this.arrowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox arrowBox;
        private System.Windows.Forms.Panel selectItemPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel arrowPanel;
        private System.Windows.Forms.TextBox selectedItemCaption;
    }
}
