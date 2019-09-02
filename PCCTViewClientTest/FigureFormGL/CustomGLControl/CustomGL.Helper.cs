using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	internal partial class CustomGL
	{
		private void setVPMatrix()
		{
			float cx = viewCenter.X, cy = viewCenter.Y;
			float vw = viewWidth / 2, vh = viewHeight / 2;
			matVP = Matrix4.CreateOrthographicOffCenter(cx - vw, cx + vw, cy - vh, cy + vh, 1, -1);
			matVPInv = matVP.Inverted();
		}

		private Vector3 screenToWorld(int x, int y)
		{
			float w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			Vector4 ndc = new Vector4
			{
				X = x * 2f / w - 1f,
				Y = (h - y) * 2f / h - 1f,
				Z = 0,
				W = 1f
			};
			Vector4 world = ndc * matVPInv;
			return world.Xyz;
		}

		private void resetVPMatrixToImage()
		{
			float aspImg = (float) imHeight / imWidth;
			float w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			float aspView=h/w;
			if (image == null)
			{
				viewWidth = w;
				viewHeight = h;
				PixelsPerUnit = 1f;
				viewCenter=new Vector2(0.5f*w,0.5f*h);
				setVPMatrix();
				return;
			}

			if (aspView > aspImg)
			{
				viewWidth = imWidth;
				viewHeight = viewWidth * aspView;
				PixelsPerUnit = w / imWidth;
			}
			else
			{
				viewHeight = imHeight;
				viewWidth = viewHeight / aspView;
				PixelsPerUnit = h / imHeight;
			}
			viewCenter=new Vector2(0.5f*imWidth,0.5f*imHeight);
			setVPMatrix();
		}

		public void ChangeMagAndVPMat(float multiple)
		{
			int w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			PixelsPerUnit *= multiple;
			viewWidth = w / PixelsPerUnit;
			viewHeight = h / PixelsPerUnit;
			setVPMatrix();
		}

		public void ResetView()
		{
			ActivateRC();
			resetVPMatrixToImage();
			Invalidate();
		}
	}
}