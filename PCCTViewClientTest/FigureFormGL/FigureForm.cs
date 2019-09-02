using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureFormGL
{
	public delegate void onUpdateData(float[] newData, int height);
	
	public partial class FigureForm : Form
	{
		private static AnalyzerForm analyzer;
		private CustomGLControl.CustomGL view;
		private float[] image;
		private int imHeight;
		private int imWidth;


		public event onUpdateData UpdateImage;
		
		public FigureForm()
		{
			InitializeComponent();

			view = new CustomGLControl.CustomGL(this)
			{
				Location = new Point(0, toolbar.Height),
				Size = new Size(ClientSize.Width, ClientSize.Height - toolbar.Height),
				Name = "GLview"
			};
			Controls.Add(view);
		}

		public void SetNewImage(float[] imData, int height)
		{
			if (imData == null)
				return;
			image = imData;
			if (height < 1)
				height = 1;
			imHeight = height;
			imWidth = image.Length / imHeight;
			UpdateImage?.Invoke(image,imHeight);
		}

		private void FigureForm_Resize(object sender, EventArgs e)
		{
			view.Size = new Size(ClientSize.Width,ClientSize.Height-toolbar.Height);
		}

		private void FigureForm_Activated(object sender, EventArgs e)
		{
			view.ActivateRC();
		}

		private void FigureForm_Deactivate(object sender, EventArgs e)
		{
			view.DeactivateRC();
		}

		private void FigureForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			view.Close();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			view.ResetView();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			view.SetToolMode(1);
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			view.SetToolMode(2);
		}
	}
}
