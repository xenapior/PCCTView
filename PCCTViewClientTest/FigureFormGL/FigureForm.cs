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
		public int imWidth;
		public int imHeight;

		public FigureForm()
		{
			InitializeComponent();
		}

		private void glView_Load(object sender, EventArgs e)
		{
			if (image == null)
			{
				glView.Enabled = false;
				return;
			}
		}

		private void glView_Resize(object sender, EventArgs e)
		{
		}

		private void glView_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
