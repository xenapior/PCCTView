using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FigureFormGL;

namespace PCCTView
{
	internal partial class MainForm : Form
	{
		public volatile bool SettingReady;
		public Setting settings = new Setting();
		public volatile bool stopWaiting;
		public string message;

		private int figureCount;

		private int Fend { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}

		public void PlotNewFigure(float[] data, int height, string title = null)
		{
			if (title == null)
				title = "";
			else
				title = "-" + title;

			figureCount++;
			FigureForm figure = new FigureForm {Text = string.Format($"图像{figureCount}{title}")};
			Invoke(new Action(() =>
			{
				figure.Show();
				figure.SetNewImage(data, height);
			}));
		}

		private bool validateAllSettings()
		{
			//todo: add verification to all settings
			return true;
		}

		private void saveSetting()
		{
			settings.teststr = "This is a setting item.";
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!validateAllSettings())
				return;
			saveSetting();
			SettingReady = true;
			stopWaiting = false;
			message = "计算中";

			WaitWindow waitForm = new WaitWindow { parentForm = this, StartPosition = FormStartPosition.Manual };
			waitForm.Left = Left + (Width - waitForm.Width) / 2;
			waitForm.Top = Top + (Height - waitForm.Height) / 2;
			waitForm.ShowDialog();
			waitForm.Dispose();
		}
		
		private void btnQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var res = MessageBox.Show("您确定要退出吗？", "退出程序", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			if (res == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		private void btnNewFigure_Click(object sender, EventArgs e)
		{
			PlotNewFigure(new float[]{0,1,2,3,4,5},2);
		}
	}
}
