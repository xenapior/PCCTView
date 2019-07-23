namespace PCCTView
{
	partial class WaitWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtMsg = new System.Windows.Forms.Label();
			this.picWaitAni = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picWaitAni)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "正在处理数据";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseWaitCursor = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(4, 94);
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.Size = new System.Drawing.Size(283, 26);
			this.txtMsg.TabIndex = 1;
			this.txtMsg.Text = "Progress";
			this.txtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txtMsg.UseWaitCursor = true;
			// 
			// picWaitAni
			// 
			this.picWaitAni.InitialImage = null;
			this.picWaitAni.Location = new System.Drawing.Point(118, 36);
			this.picWaitAni.Name = "picWaitAni";
			this.picWaitAni.Size = new System.Drawing.Size(48, 48);
			this.picWaitAni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picWaitAni.TabIndex = 2;
			this.picWaitAni.TabStop = false;
			this.picWaitAni.UseWaitCursor = true;
			// 
			// WaitWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 121);
			this.ControlBox = false;
			this.Controls.Add(this.picWaitAni);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WaitWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.UseWaitCursor = true;
			this.Load += new System.EventHandler(this.WaitWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.picWaitAni)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label txtMsg;
		private System.Windows.Forms.PictureBox picWaitAni;
	}
}