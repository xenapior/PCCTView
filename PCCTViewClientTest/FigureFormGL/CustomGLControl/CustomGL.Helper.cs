using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	internal partial class CustomGL
	{
//		//opengl resources
//		private int progData;
//		private int progSel;
//		private int vboQuadVert;
//		private int vboQuadUv;
//		private int vboSelVert;
//		private int vaoQuad;
//		private int vaoSel;
//		private int texData;
//
//		private void prepareProgram()
//		{
//			string dataVSsrc = @"#version 430
//layout(location=0) in vec2 pos;
//layout(location=1) in vec2 uv;
//layout(location=0) uniform mat4 mvp;
//out vec2 texcoord; 
//void main(){
//	gl_Position=mvp*vec4(pos,0,1f);
//	texcoord=uv;
//}";
//			string dataFSsrc = @"#version 430
//layout(binding=0) uniform sampler2D texdata;
//layout(location=1) uniform float gMin;
//layout(location=2) uniform float gMax;
//in vec2 texcoord;
//out vec4 fragColor;
//void main(){
//	vec4 pix=texture(texdata,texcoord);
//	float g=clamp(pix.r,gMin,gMax);
//	g=(g-gMin)/(gMax-gMin);
//	fragColor=vec4(g,g,g,1f);
//}";
//			progData=  makeGLProgram(dataVSsrc, dataFSsrc);
//		}
//
//		private int makeGLProgram(string vsSrc, string fsSrc)
//		{
//			int vs = GL.CreateShader(ShaderType.VertexShader);
//			int fs = GL.CreateShader(ShaderType.FragmentShader);
//			GL.ShaderSource(vs, vsSrc);
//			GL.ShaderSource(fs, fsSrc);
//			GL.CompileShader(vs);
//			GL.GetShader(vs, ShaderParameter.CompileStatus, out int vsstat);
//			if (vsstat == 0)
//			{
//				GL.GetShaderInfoLog(vs, out string info);
//				Debug.WriteLine("VS:" + info);
//				GL.DeleteShader(vs);
//				return 0;
//			}
//
//			GL.CompileShader(fs);
//			GL.GetShader(fs, ShaderParameter.CompileStatus, out int fsstat);
//			if (fsstat == 0)
//			{
//				GL.GetShaderInfoLog(fs, out string info);
//				Debug.WriteLine("FS:" + info);
//				GL.DeleteShader(vs);
//				GL.DeleteShader(fs);
//				return 0;
//			}
//
//			int program = GL.CreateProgram();
//			GL.AttachShader(program, vs);
//			GL.AttachShader(program, fs);
//			GL.LinkProgram(program);
//			GL.GetProgram(program, GetProgramParameterName.LinkStatus, out int linkstat);
//			if (linkstat == 0)
//			{
//				GL.GetProgramInfoLog(program, out string info);
//				Debug.WriteLine("Program:" + info);
//				GL.DeleteShader(vs);
//				GL.DeleteShader(fs);
//				GL.DeleteProgram(program);
//				return 0;
//			}
//
//			GL.DetachShader(program, vs);
//			GL.DetachShader(program, fs);
//			GL.DeleteShader(vs);
//			GL.DeleteShader(fs);
//			return program;
//		}
//
//		private void makeDataAsset()
//		{
//			float w = imWidth, h = imHeight;
//			float[] qv={0, 0, w, 0, 0, h, w, h};	//tri-strip
//			float[] quv={1, 0, 1, 1, 0, 0, 0, 1};
//
//			vaoQuad = GL.GenVertexArray();
//			GL.BindVertexArray(vaoQuad);
//			{
//				vboQuadVert = GL.GenBuffer();
//				GL.BindBuffer(BufferTarget.ArrayBuffer, vboQuadVert);
//				GL.BufferData(BufferTarget.ArrayBuffer, qv.Length * sizeof(float), qv, BufferUsageHint.StaticDraw);
//				GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 0, 0);
//				GL.EnableVertexAttribArray(0);
//
//				vboQuadUv = GL.GenBuffer();
//				GL.BindBuffer(BufferTarget.ArrayBuffer, vboQuadUv);
//				GL.BufferData(BufferTarget.ArrayBuffer, quv.Length * sizeof(float), quv, BufferUsageHint.StaticDraw);
//				GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, 0, 0);
//				GL.EnableVertexAttribArray(1);
//			}
//			GL.BindVertexArray(0);
//
//			texData=GL.GenTexture();
//			GL.BindTexture(TextureTarget.Texture2D, texData);
//			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureMinFilter,(int)TextureMinFilter.LinearMipmapNearest);
//			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureMagFilter,(int)TextureMagFilter.Nearest);
//			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureWrapS,(int)TextureWrapMode.ClampToEdge);
//			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureWrapT,(int)TextureWrapMode.ClampToEdge);
//			GL.TexImage2D(TextureTarget.Texture2D,0,PixelInternalFormat.R32f,imHeight,imWidth,0,PixelFormat.Red,PixelType.Float,image);
//			GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
//		}

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

//		private void doCleanUp()
//		{
//			GL.BindVertexArray(0);
//			GL.UseProgram(0);
//			if (progData != 0)
//				GL.DeleteProgram(progData);
//			if (progSel != 0)
//				GL.DeleteProgram(progSel);
//			if (vaoQuad != 0)
//				GL.DeleteProgram(vaoQuad);
//			if (vaoSel != 0)
//				GL.DeleteProgram(vaoSel);
//			if (vboQuadVert != 0)
//				GL.DeleteBuffer(vboQuadVert);
//			if (vboQuadUv != 0)
//				GL.DeleteBuffer(vboQuadUv);
//			if (vboSelVert != 0)
//				GL.DeleteBuffer(vboSelVert);
//			if (texData!=0)
//				GL.DeleteTexture(texData);
//		}
//
		private void resetView()
		{
			float aspImg = (float) imHeight / imWidth;
			float w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			float aspView=h/w;

			if (aspView > aspImg)
			{
				viewWidth = imWidth;
				viewHeight = viewWidth * aspView;
			}
			else
			{
				viewHeight = imHeight;
				viewWidth = viewHeight / aspView;
			}
			viewCenter=new Vector2(0.5f*imWidth,0.5f*imHeight);
			setVPMatrix();
		}

		private void resizeView()
		{
			float w = ClientSize.Width, h = ClientSize.Height;
			w = w < 1 ? 1 : w;
			h = h < 1 ? 1 : h;
			if (image == null)
			{
				viewWidth = w;
				viewHeight = h;
				setVPMatrix();
				return;
			}

			float aspView=h/w;
			float aspImg = (float) imHeight / imWidth;
			if (aspView > aspImg)
			{
				viewWidth = imWidth;
				viewHeight = viewWidth * aspView;
			}
			else
			{
				viewHeight = imHeight;
				viewWidth = viewHeight / aspView;
			}
			viewCenter=new Vector2(0.5f*imWidth,0.5f*imHeight);
			setVPMatrix();
		}

//		private void renderData()
//		{
//			GL.UseProgram(progData);
//			GL.BindTexture(TextureTarget.Texture2D,texData);
//			GL.BindVertexArray(vaoQuad);
//			GL.UniformMatrix4(0,false,ref matVP);
//			GL.Uniform1(1,grayscaleMin);
//			GL.Uniform1(2,grayscaleMax);
//			GL.DrawArrays(PrimitiveType.TriangleStrip,0,4);
//		}

	}
}