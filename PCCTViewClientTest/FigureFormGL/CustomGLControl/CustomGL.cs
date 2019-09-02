using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	public enum Tools { None, RectSelect, LineSelect }
	internal partial class CustomGL : GLControl
	{
		public bool isActive;
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

		private float PixelsPerUnit = 1f;
		//tool settings
		public UITool CurrentTool;

		private Matrix4 matVPInv;
		private DataDisplayTool dataLayer;
		private RectSelectTool rectSelector;

		public CustomGL(FigureForm parent)
		{
			viewCenter = new Vector2(0f, 0f);
			parent.UpdateImage += SetNewImage;
			Paint += CustomGL_Paint;
			Load += CustomGL_Load;
			Resize += CustomGL_Resize;
			MouseDown += CustomGL_MouseDown;
			MouseMove += CustomGL_MouseMove;
			MouseUp += CustomGL_MouseUp;
			MouseWheel += CustomGL_MouseWheel;
		}

		private void CustomGL_MouseDown(object sender, MouseEventArgs e)
		{
			if (CurrentTool == null)
				return;
			Vector2 p = screenToWorld(e.X, e.Y).Xy;
			CurrentTool.BeginSelect(ref p);
			if (CurrentTool.NeedRedraw)
				Invalidate();
		}

		private void CustomGL_MouseMove(object sender, MouseEventArgs e)
		{
			if (CurrentTool == null)
				return;
			Vector2 point = screenToWorld(e.X, e.Y).Xy;
			CurrentTool.ChangePoint(ref point);
			if (CurrentTool.NeedRedraw)
				Invalidate();
		}

		private void CustomGL_MouseUp(object sender, MouseEventArgs e)
		{
			CurrentTool?.EndSelect();
		}

		private void CustomGL_Load(object sender, System.EventArgs e)
		{
			GL.ClearColor(Color.Teal);
			dataLayer = new DataDisplayTool(this);
			dataLayer.Initialize();
			rectSelector = new RectSelectTool(this);
			rectSelector.Initialize();
		}

		private void CustomGL_MouseWheel(object sender, MouseEventArgs e)
		{
			ChangeMagAndVPMat(1 + e.Delta / 480f);
			Invalidate();
		}

		private void CustomGL_Resize(object sender, System.EventArgs e)
		{
			int w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			ChangeMagAndVPMat(1f);
			GL.Viewport(0, 0, w, h);
		}

		private void CustomGL_Paint(object sender, PaintEventArgs e)
		{
			ActivateRC();
			GL.Clear(ClearBufferMask.ColorBufferBit);
			dataLayer.Draw();
			if (CurrentTool != dataLayer)
				CurrentTool?.Draw();
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
			dataLayer.SetImage();
			ResetView();
		}

		public void SetToolMode(int n)
		{
			switch (n)
			{
					case 0:
						CurrentTool = null;
						break;
					case 1:
						CurrentTool = dataLayer;
						break;
					case 2:
						CurrentTool = rectSelector;
						break;
			}
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
			ActivateRC();
			dataLayer.DoCleanup();
			rectSelector.DoCleanup();
		}
	}
}