using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCTView.Properties;

namespace PCCTView
{
	internal partial class WaitWindow : Form
	{
		public MainForm parentForm;
		private string message;
		private Image waitAnimation;

		public WaitWindow()
		{
			InitializeComponent();
		}

		private void WaitWindow_Load(object sender, EventArgs e)
		{
			waitAnimation=Resources.ResourceManager.GetObject("waitAni") as Image;
			ImageAnimator.Animate(waitAnimation,onAnimate);
			picWaitAni.Image = waitAnimation;
			timer1.Start();
		}

		private void onAnimate(object o, EventArgs e)
		{
			ImageAnimator.UpdateFrames();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (message != parentForm.message)
			{
				message = parentForm.message;
				txtMsg.Text = message;
			}

			if (!parentForm.stopWaiting) 
				return;
			
			timer1.Stop();
			ImageAnimator.StopAnimate(waitAnimation,null);
			Close();
		}
	}
}
