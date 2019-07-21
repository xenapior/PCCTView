using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCTView
{
	internal partial class MainForm : Form
	{
		public volatile bool SettingReady;
		public volatile bool serverDataReady;
		public string message;

		public Setting settings = new Setting();

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			saveSetting();
			SettingReady = true;
			serverDataReady = false;
			message = "计算中";

			WaitWindow waitForm = new WaitWindow();
			waitForm.parentForm = this;
			waitForm.StartPosition = FormStartPosition.Manual;
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
			var res = MessageBox.Show("您确定要退出程序吗？", "退出", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if (res == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		private void saveSetting()
		{
			settings.teststr = "This is a setting item.";
		}
	}
}
