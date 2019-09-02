using System;
using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	class RectSelectTool : UITool
	{
		public int LeftCol, RightCol, TopRow, BottomRow;
		public bool SelectionValid;
		public Vector4 LineColor;
		//logic
		private int startCol, startRow, currCol, currRow;
		//opengl
		private int progGLSL;
		private int vaoQuad;
		private int vboQuadVert;

		public RectSelectTool(CustomGL targetControl) : base(targetControl)
		{
			LineColor = new Vector4(1, 0, 0, 1);
		}

		public override void Initialize()
		{
			string dataVSsrc = @"#version 430
layout(location=0) in vec2 pos;
layout(location=0) uniform mat4 mvp;
void main(){
	gl_Position=mvp*vec4(pos,0,1f);
}";
			string dataFSsrc = @"#version 430
layout(location=1) uniform vec4 linecolor;
out vec4 fragColor;
void main(){
	fragColor=linecolor;
}";
			progGLSL = MakeGLProgram(dataVSsrc, dataFSsrc);
			vaoQuad = GL.GenVertexArray();
			GL.BindVertexArray(vaoQuad);
			{
				vboQuadVert = GL.GenBuffer();
				GL.BindBuffer(BufferTarget.ArrayBuffer, vboQuadVert);
				GL.BufferData(BufferTarget.ArrayBuffer, 8 * sizeof(float), new float[8], BufferUsageHint.DynamicDraw);
				GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 0, 0);
				GL.EnableVertexAttribArray(0);
			}
			GL.BindVertexArray(0);
		}

		public override void Draw()
		{
			if (!SelectionValid)
				return;
			GL.UseProgram(progGLSL);
			GL.BindVertexArray(vaoQuad);
			Matrix4 tmp = targetControl.matVP;
			GL.UniformMatrix4(0, false, ref tmp);
			GL.Uniform4(1, ref LineColor);
			if (NeedRedraw)
			{
				float[] qv = {LeftCol, BottomRow, RightCol + 1, BottomRow, RightCol + 1, TopRow + 1, LeftCol, TopRow + 1};
				GL.BindBuffer(BufferTarget.ArrayBuffer, vboQuadVert);
				GL.BufferSubData(BufferTarget.ArrayBuffer, IntPtr.Zero, 8 * sizeof(float), qv);
				NeedRedraw = false;
				Debug.WriteLine($"({LeftCol},{BottomRow},{RightCol},{TopRow})");
			}
			GL.DrawArrays(PrimitiveType.LineLoop, 0, 4);
		}

		public override void BeginSelect(ref Vector2 point)
		{
			IsSelecting = true;
			NeedRedraw = true;
			startCol = (int)Math.Floor(point.X);
			startRow = (int)Math.Floor(point.Y);
			ChangePoint(ref point);
		}

		public override void EndSelect()
		{
			IsSelecting = false;
		}

		public override void ChangePoint(ref Vector2 point)
		{
			if (!IsSelecting)
				return;
			int newx = (int)Math.Floor(point.X);
			int newy = (int)Math.Floor(point.Y);
			if (newx == currCol && newy == currRow)
				return;
			NeedRedraw = true;
			currCol = newx;
			currRow = newy;
			int l = currCol < startCol ? currCol : startCol;
			int r = currCol > startCol ? currCol : startCol;
			int t = currRow > startRow ? currRow : startRow;
			int b = currRow < startRow ? currRow : startRow;
			// valid horizontal intersection
			int rv = targetControl.imWidth - 1;
			LeftCol = l > 0 ? l : 0;
			RightCol = r < rv ? r : rv;
			if (LeftCol > RightCol)
			{
				SelectionValid = false;
				return;
			}
			// valid horizontal intersection
			int tv = targetControl.imHeight - 1;
			BottomRow = b > 0 ? b : 0;
			TopRow = t < tv ? t : tv;
			if (BottomRow > TopRow)
			{
				SelectionValid = false;
				return;
			}
			// send valid marker rect coordinates
			SelectionValid = true;
		}

		public override void DoCleanup()
		{
			GL.BindVertexArray(0);
			GL.UseProgram(0);
			if (progGLSL != 0)
				GL.DeleteProgram(progGLSL);
			if (vaoQuad != 0)
				GL.DeleteProgram(vaoQuad);
			if (vboQuadVert != 0)
				GL.DeleteBuffer(vboQuadVert);
		}
	}
}