using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureFormGL
{
	public partial class FigureForm : Form
	{
		public float[] image;
		public int imHeight;
		public int imWidth;

		//todo: global mutex context test
		private static bool isCurrent;	// whether opengl context is current

		public FigureForm()
		{
			InitializeComponent();
		}

		public void PlotImage(float[] imData, int width)
		{
			image = imData ?? throw new ArgumentNullException("图像数据为空。");
			if (width < 1)
				width = 1;
			imWidth = width;
			imHeight = image.Length / imWidth;
			//todo: add glview handling proc
		}

		private void glView_Load(object sender, EventArgs e)
		{

		}

		private void glView_Resize(object sender, EventArgs e)
		{

		}

		private void glView_Paint(object sender, PaintEventArgs e)
		{
			
		}
	}
}
