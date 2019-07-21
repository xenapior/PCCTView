namespace FigureFormGL
{
	partial class FigureForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureForm));
			this.toolbar = new System.Windows.Forms.ToolStrip();
			this.btnOpen = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRectROI = new System.Windows.Forms.ToolStripButton();
			this.btnLinROI = new System.Windows.Forms.ToolStripButton();
			this.glView = new OpenTK.GLControl();
			this.toolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolbar
			// 
			this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnRectROI,
            this.btnLinROI});
			this.toolbar.Location = new System.Drawing.Point(0, 0);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(436, 25);
			this.toolbar.TabIndex = 0;
			this.toolbar.Text = "toolStrip1";
			// 
			// btnOpen
			// 
			this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
			this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(23, 22);
			this.btnOpen.Text = "打开";
			// 
			// btnSave
			// 
			this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(23, 22);
			this.btnSave.Text = "另存为";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnRectROI
			// 
			this.btnRectROI.CheckOnClick = true;
			this.btnRectROI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRectROI.Image = ((System.Drawing.Image)(resources.GetObject("btnRectROI.Image")));
			this.btnRectROI.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRectROI.Name = "btnRectROI";
			this.btnRectROI.Size = new System.Drawing.Size(23, 22);
			this.btnRectROI.Text = "划出矩形ROI";
			this.btnRectROI.Click += new System.EventHandler(this.btnRectROI_Click);
			// 
			// btnLinROI
			// 
			this.btnLinROI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnLinROI.Image = ((System.Drawing.Image)(resources.GetObject("btnLinROI.Image")));
			this.btnLinROI.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLinROI.Name = "btnLinROI";
			this.btnLinROI.Size = new System.Drawing.Size(23, 22);
			this.btnLinROI.Text = "划出直线ROI";
			this.btnLinROI.Click += new System.EventHandler(this.btnLinROI_Click);
			// 
			// glView
			// 
			this.glView.BackColor = System.Drawing.Color.Black;
			this.glView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glView.Location = new System.Drawing.Point(0, 25);
			this.glView.Name = "glView";
			this.glView.Size = new System.Drawing.Size(436, 299);
			this.glView.TabIndex = 1;
			this.glView.VSync = false;
			this.glView.Load += new System.EventHandler(this.glView_Load);
			this.glView.Paint += new System.Windows.Forms.PaintEventHandler(this.glView_Paint);
			this.glView.Resize += new System.EventHandler(this.glView_Resize);
			// 
			// FigureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 324);
			this.Controls.Add(this.glView);
			this.Controls.Add(this.toolbar);
			this.Name = "FigureForm";
			this.Text = "FigureForm";
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolbar;
		private System.Windows.Forms.ToolStripButton btnOpen;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnRectROI;
		private OpenTK.GLControl glView;
		private System.Windows.Forms.ToolStripButton btnLinROI;
	}
}