using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace FigureFormGL
{
	/// <summary>
	/// Wrap OpenGL operations for GLControl
	/// </summary>
	internal class Canvas
	{
		private readonly GLControl rc;

		public Canvas(GLControl renderContext) => rc = renderContext;

		private void GetRC()
		{
			if (RCManager.CurrentRC != rc)
			{
				lock (rc)
				{
					rc.MakeCurrent();
					RCManager.CurrentRC = rc;
				}
			}
		}

		public void ClearCanvas()
		{
			GetRC();
			GL.ClearColor(1, 1, 0, 1);
			GL.Clear(ClearBufferMask.ColorBufferBit);
			rc.SwapBuffers();
		}

		public void Paint()
		{

		}
	}
}
