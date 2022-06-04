namespace Draw
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DrawRectangleSpeedButtonClick = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawRectangleSpeedButtonClick});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1730, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DrawRectangleSpeedButtonClick
            // 
            this.DrawRectangleSpeedButtonClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawRectangleSpeedButtonClick.Image = ((System.Drawing.Image)(resources.GetObject("DrawRectangleSpeedButtonClick.Image")));
            this.DrawRectangleSpeedButtonClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawRectangleSpeedButtonClick.Name = "DrawRectangleSpeedButtonClick";
            this.DrawRectangleSpeedButtonClick.Size = new System.Drawing.Size(34, 33);
            this.DrawRectangleSpeedButtonClick.Text = "toolStripButton1";
            this.DrawRectangleSpeedButtonClick.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Location = new System.Drawing.Point(0, 38);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1730, 38);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // viewPort
            // 
            this.viewPort.Location = new System.Drawing.Point(13, 54);
            this.viewPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1659, 623);
            this.viewPort.TabIndex = 2;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.viewPort_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 775);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DrawRectangleSpeedButtonClick;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DoubleBufferedPanel viewPort;
    }
}

