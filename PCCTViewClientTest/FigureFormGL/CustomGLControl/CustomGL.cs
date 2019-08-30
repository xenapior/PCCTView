using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	internal partial class CustomGL : GLControl
	{
		private bool isActive;
		//cached data
		public float[] image;
		public int imHeight;
		public int imWidth;
		//view settings
		public Vector2 viewCenter;
		public float viewWidth;
		public float viewHeight;
		public Matrix4 matVP;
		public float grayscaleMin, grayscaleMax;
		
		private Matrix4 matVPInv;
		private List<UIToolBase> actions;

		public CustomGL(FigureForm parent) 
		{
			actions=new List<UIToolBase>();
			parent.UpdateImage += SetNewImage;
			Paint += CustomGL_Paint;
			Load += CustomGL_Load;
			Resize += CustomGL_Resize;
			MouseDown += CustomGL_MouseDown;
			MouseWheel += CustomGL_MouseWheel;
			viewCenter = new Vector2(0f, 0f);
		}

		private void CustomGL_Load(object sender, System.EventArgs e)
		{
			GL.ClearColor(Color.Teal);
			prepareProgram();
		}

		private void CustomGL_MouseWheel(object sender, MouseEventArgs e)
		{
			viewWidth *= (1 + e.Delta/480f);
			viewHeight *= (1 + e.Delta/480f);
			setVPMatrix();
			Invalidate();
		}
		
		private void CustomGL_MouseDown(object sender, MouseEventArgs e)
		{
			ActivateRC();
			viewCenter = screenToWorld(e.X, e.Y).Xy;
			setVPMatrix();
			Invalidate();
			Capture = true;
		}

		private void CustomGL_Resize(object sender, System.EventArgs e)
		{
			ActivateRC();
			int w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			GL.Viewport(0, 0, w, h);
			resizeView();
		}

		private void CustomGL_Paint(object sender, PaintEventArgs e)
		{
			ActivateRC();
			GL.Clear(ClearBufferMask.ColorBufferBit);
			renderData();
			SwapBuffers();
		}

		public void SetNewImage(float[] imData, int height)
		{
			if (imData == null)
				return;
			if (imData == image)
				return;
			image = imData;
			if (height < 1)
				height = 1;
			imHeight = height;
			imWidth = image.Length / imHeight;
			grayscaleMin = imData.Min();
			grayscaleMax = imData.Max();

			ActivateRC();
			makeDataAsset();
			resetView();
			Invalidate();
		}

		public void ActivateRC()
		{
			if (isActive)
				return;
			MakeCurrent();
			isActive = true;
		}

		public void DeactivateRC()
		{
			isActive = false;
		}

		public void Close()
		{
			Capture = false;
			ActivateRC();
			doCleanUp();
		}

	}
}