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
		public volatile bool serverDataReady;
		public string message;

		private int figureCount = 1;

		public MainForm()
		{
			InitializeComponent();
		}

		public void NewFigure(float[] data, int width, string title = null)
		{
			if (title == null)
			{
				title = "";
			}
			else
			{
				title = "-" + title;
			}
			if (width < 1)
				width = 1;

			FigureForm figure = new FigureForm();
			figure.image = data;
			figure.imWidth = width;
			if (data != null)
				figure.imHeight = data.Length / width;
			figure.Text = string.Format($"图像{figureCount}{title}");
			Invoke(new Action(()=>figure.Show(this)));
			figureCount++;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			saveSetting();
			SettingReady = true;
			serverDataReady = false;
			message = "计算中";

			WaitWindow waitForm = new WaitWindow {parentForm = this, StartPosition = FormStartPosition.Manual};
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

		private void saveSetting()
		{
			settings.teststr = "This is a setting item.";
		}

		private void btnNewFigure_Click(object sender, EventArgs e)
		{
			NewFigure(null, 1);
		}
	}
}
