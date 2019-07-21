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
	internal partial class WaitWindow : Form
	{
		public MainForm parentForm;
		private string message;

		public WaitWindow()
		{
			InitializeComponent();
		}

		private void WaitWindow_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (message != parentForm.message)
			{
				message = parentForm.message;
				txtMsg.Text = message;
			}

			if (!parentForm.serverDataReady) return;
			timer1.Stop();
			Close();
		}
	}
}
