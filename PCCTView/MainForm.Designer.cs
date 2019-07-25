namespace PCCTView
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
			this.btnStart = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnNewFigure = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.edtSampFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpenSampFile = new System.Windows.Forms.Button();
			this.btnOpenDarkFile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.edtDarkFile = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.spnSteps = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spnSteps)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnStart.Location = new System.Drawing.Point(16, 11);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(146, 47);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "读入数据处理";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(522, 354);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(98, 70);
			this.btnQuit.TabIndex = 1;
			this.btnQuit.Text = "退出";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// btnNewFigure
			// 
			this.btnNewFigure.Location = new System.Drawing.Point(331, 11);
			this.btnNewFigure.Name = "btnNewFigure";
			this.btnNewFigure.Size = new System.Drawing.Size(146, 47);
			this.btnNewFigure.TabIndex = 2;
			this.btnNewFigure.Text = "新建空白图像窗口";
			this.btnNewFigure.UseVisualStyleBackColor = true;
			this.btnNewFigure.Click += new System.EventHandler(this.btnNewFigure_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(168, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 47);
			this.button1.TabIndex = 3;
			this.button1.Text = "改变参数再次处理";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.btnNewFigure);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Location = new System.Drawing.Point(12, 354);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(494, 70);
			this.panel1.TabIndex = 4;
			// 
			// edtSampFile
			// 
			this.edtSampFile.Location = new System.Drawing.Point(89, 20);
			this.edtSampFile.Name = "edtSampFile";
			this.edtSampFile.Size = new System.Drawing.Size(432, 21);
			this.edtSampFile.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "样品数据文件";
			// 
			// btnOpenSampFile
			// 
			this.btnOpenSampFile.Location = new System.Drawing.Point(527, 20);
			this.btnOpenSampFile.Name = "btnOpenSampFile";
			this.btnOpenSampFile.Size = new System.Drawing.Size(75, 21);
			this.btnOpenSampFile.TabIndex = 7;
			this.btnOpenSampFile.Text = "浏览";
			this.btnOpenSampFile.UseVisualStyleBackColor = true;
			// 
			// btnOpenDarkFile
			// 
			this.btnOpenDarkFile.Location = new System.Drawing.Point(527, 56);
			this.btnOpenDarkFile.Name = "btnOpenDarkFile";
			this.btnOpenDarkFile.Size = new System.Drawing.Size(75, 21);
			this.btnOpenDarkFile.TabIndex = 10;
			this.btnOpenDarkFile.Text = "浏览";
			this.btnOpenDarkFile.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "暗场数据文件";
			// 
			// edtDarkFile
			// 
			this.edtDarkFile.Location = new System.Drawing.Point(89, 56);
			this.edtDarkFile.Name = "edtDarkFile";
			this.edtDarkFile.Size = new System.Drawing.Size(432, 21);
			this.edtDarkFile.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.spnSteps);
			this.groupBox1.Location = new System.Drawing.Point(12, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(303, 236);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "采集参数";
			// 
			// spnSteps
			// 
			this.spnSteps.Location = new System.Drawing.Point(89, 25);
			this.spnSteps.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.spnSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.spnSteps.Name = "spnSteps";
			this.spnSteps.Size = new System.Drawing.Size(51, 21);
			this.spnSteps.TabIndex = 0;
			this.spnSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.spnSteps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "相位步进步数";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.edtSampFile);
			this.groupBox2.Controls.Add(this.btnOpenDarkFile);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnOpenSampFile);
			this.groupBox2.Controls.Add(this.edtDarkFile);
			this.groupBox2.Location = new System.Drawing.Point(12, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(608, 89);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "数据文件路径";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "每周帧数";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 61);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(51, 21);
			this.textBox1.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 438);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnQuit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "相衬CT数据处理程序 PCCT Viewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spnSteps)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnNewFigure;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox edtSampFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOpenSampFile;
		private System.Windows.Forms.Button btnOpenDarkFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtDarkFile;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown spnSteps;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}