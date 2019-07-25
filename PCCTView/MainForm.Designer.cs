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
			this.edtFend = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.spnNN = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.edtNbin = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.edtROImin = new System.Windows.Forms.TextBox();
			this.edtROImax = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtRAP = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnOpenBrightFile = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.edtCurrentmax = new System.Windows.Forms.TextBox();
			this.edtCurrentmin = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spnNN)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.edtFend);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.spnNN);
			this.groupBox1.Location = new System.Drawing.Point(12, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(163, 207);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "数据采集参数";
			// 
			// edtFend
			// 
			this.edtFend.Location = new System.Drawing.Point(103, 61);
			this.edtFend.Name = "edtFend";
			this.edtFend.Size = new System.Drawing.Size(51, 21);
			this.edtFend.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "每周帧数Fend";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "相位步进步数NN";
			// 
			// spnNN
			// 
			this.spnNN.Location = new System.Drawing.Point(103, 24);
			this.spnNN.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.spnNN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.spnNN.Name = "spnNN";
			this.spnNN.Size = new System.Drawing.Size(51, 21);
			this.spnNN.TabIndex = 0;
			this.spnNN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.spnNN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnOpenBrightFile);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.edtSampFile);
			this.groupBox2.Controls.Add(this.btnOpenDarkFile);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnOpenSampFile);
			this.groupBox2.Controls.Add(this.edtDarkFile);
			this.groupBox2.Location = new System.Drawing.Point(12, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(608, 127);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "数据文件路径";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.edtCurrentmax);
			this.groupBox3.Controls.Add(this.edtCurrentmin);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.edtRAP);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.edtROImax);
			this.groupBox3.Controls.Add(this.edtROImin);
			this.groupBox3.Controls.Add(this.edtNbin);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(195, 141);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(425, 207);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "图像处理参数";
			// 
			// edtNbin
			// 
			this.edtNbin.Location = new System.Drawing.Point(103, 61);
			this.edtNbin.Name = "edtNbin";
			this.edtNbin.Size = new System.Drawing.Size(51, 21);
			this.edtNbin.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 12);
			this.label5.TabIndex = 13;
			this.label5.Text = "角度合并数Nbin";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "成像区域ROI";
			// 
			// edtROImin
			// 
			this.edtROImin.Location = new System.Drawing.Point(103, 24);
			this.edtROImin.Name = "edtROImin";
			this.edtROImin.Size = new System.Drawing.Size(51, 21);
			this.edtROImin.TabIndex = 15;
			// 
			// edtROImax
			// 
			this.edtROImax.Location = new System.Drawing.Point(177, 24);
			this.edtROImax.Name = "edtROImax";
			this.edtROImax.Size = new System.Drawing.Size(51, 21);
			this.edtROImax.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(160, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 12);
			this.label7.TabIndex = 17;
			this.label7.Text = "-";
			// 
			// edtRAP
			// 
			this.edtRAP.Location = new System.Drawing.Point(103, 100);
			this.edtRAP.Name = "edtRAP";
			this.edtRAP.Size = new System.Drawing.Size(51, 21);
			this.edtRAP.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 103);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 12);
			this.label8.TabIndex = 18;
			this.label8.Text = "虚拟转轴RAP";
			// 
			// btnOpenBrightFile
			// 
			this.btnOpenBrightFile.Location = new System.Drawing.Point(527, 94);
			this.btnOpenBrightFile.Name = "btnOpenBrightFile";
			this.btnOpenBrightFile.Size = new System.Drawing.Size(75, 21);
			this.btnOpenBrightFile.TabIndex = 13;
			this.btnOpenBrightFile.Text = "浏览";
			this.btnOpenBrightFile.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 12);
			this.label9.TabIndex = 12;
			this.label9.Text = "明场数据文件";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(89, 94);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(432, 21);
			this.textBox3.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(160, 139);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(11, 12);
			this.label10.TabIndex = 23;
			this.label10.Text = "-";
			// 
			// edtCurrentmax
			// 
			this.edtCurrentmax.Location = new System.Drawing.Point(177, 136);
			this.edtCurrentmax.Name = "edtCurrentmax";
			this.edtCurrentmax.Size = new System.Drawing.Size(51, 21);
			this.edtCurrentmax.TabIndex = 22;
			// 
			// edtCurrentmin
			// 
			this.edtCurrentmin.Location = new System.Drawing.Point(103, 136);
			this.edtCurrentmin.Name = "edtCurrentmin";
			this.edtCurrentmin.Size = new System.Drawing.Size(51, 21);
			this.edtCurrentmin.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 139);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(77, 12);
			this.label11.TabIndex = 20;
			this.label11.Text = "电流校正区域";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 438);
			this.Controls.Add(this.groupBox3);
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
			((System.ComponentModel.ISupportInitialize)(this.spnNN)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
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
		private System.Windows.Forms.TextBox edtFend;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown spnNN;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnOpenBrightFile;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox edtCurrentmax;
		private System.Windows.Forms.TextBox edtCurrentmin;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox edtRAP;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtROImax;
		private System.Windows.Forms.TextBox edtROImin;
		private System.Windows.Forms.TextBox edtNbin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}