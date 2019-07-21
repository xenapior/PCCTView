using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace FigureFormGL
{
	partial class FigureForm : Form
	{
		void InitView()
		{
			glView.MakeCurrent();
			GL.ClearColor(Color.Black);
			GL.Clear(ClearBufferMask.ColorBufferBit);
			glView.SwapBuffers();
		}

		void test1()
		{
			glView.MakeCurrent();
			GL.ClearColor(Color.Red);

			GL.Clear(ClearBufferMask.ColorBufferBit);
			glView.SwapBuffers();
		}

		void test2()
		{
			glView.MakeCurrent();
			GL.ClearColor(Color.GreenYellow);
			GL.Clear(ClearBufferMask.ColorBufferBit);
			glView.SwapBuffers();
		}
	}
}
