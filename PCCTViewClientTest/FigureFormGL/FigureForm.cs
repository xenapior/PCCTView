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
	public partial class FigureForm : Form
	{
		private Canvas canvas;
		private float[] image;
		private int imHeight;
		private int imWidth;

		public FigureForm()
		{
			InitializeComponent();
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
			if (Visible)
			{
				glView.Invalidate();
			}
		}

		private void glView_Load(object sender, EventArgs e)
		{
			canvas=new Canvas(glView);
			canvas.ClearCanvas();
		}

		private void glView_Resize(object sender, EventArgs e)
		{
			
		}

		private void glView_Paint(object sender, PaintEventArgs e)
		{
			canvas.Paint();
		}

	}
}
