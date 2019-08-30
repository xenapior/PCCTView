using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	internal sealed class DataDisplayTool : UIToolBase
	{
		private int progData;
		private int vboQuadVert;
		private int vboQuadUv;
		private int vaoQuad;
		private int texData;

		public DataDisplayTool(CustomGL targetControl, bool enabled = true) : base(targetControl, enabled)
		{
		}

		public void SetImage()
		{
			float w = targetControl.imWidth, h = targetControl.imHeight;
			float[] qv={0, 0, w, 0, 0, h, w, h};	//tri-strip
			float[] quv={1, 0, 1, 1, 0, 0, 0, 1};

			vaoQuad = GL.GenVertexArray();
			GL.BindVertexArray(vaoQuad);
			{
				vboQuadVert = GL.GenBuffer();
				GL.BindBuffer(BufferTarget.ArrayBuffer, vboQuadVert);
				GL.BufferData(BufferTarget.ArrayBuffer, qv.Length * sizeof(float), qv, BufferUsageHint.StaticDraw);
				GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 0, 0);
				GL.EnableVertexAttribArray(0);

				vboQuadUv = GL.GenBuffer();
				GL.BindBuffer(BufferTarget.ArrayBuffer, vboQuadUv);
				GL.BufferData(BufferTarget.ArrayBuffer, quv.Length * sizeof(float), quv, BufferUsageHint.StaticDraw);
				GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, 0, 0);
				GL.EnableVertexAttribArray(1);
			}
			GL.BindVertexArray(0);

			texData=GL.GenTexture();
			GL.BindTexture(TextureTarget.Texture2D, texData);
			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureMinFilter,(int)TextureMinFilter.LinearMipmapNearest);
			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureMagFilter,(int)TextureMagFilter.Nearest);
			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureWrapS,(int)TextureWrapMode.ClampToEdge);
			GL.TexParameter(TextureTarget.Texture2D,TextureParameterName.TextureWrapT,(int)TextureWrapMode.ClampToEdge);
			GL.TexImage2D(TextureTarget.Texture2D,0,PixelInternalFormat.R32f,targetControl.imHeight,targetControl.imWidth,0,PixelFormat.Red,PixelType.Float,targetControl.image);
			GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
		}

		public override void Initialize()
		{
			string dataVSsrc = @"#version 430
layout(location=0) in vec2 pos;
layout(location=1) in vec2 uv;
layout(location=0) uniform mat4 mvp;
out vec2 texcoord; 
void main(){
	gl_Position=mvp*vec4(pos,0,1f);
	texcoord=uv;
}";
			string dataFSsrc = @"#version 430
layout(binding=0) uniform sampler2D texdata;
layout(location=1) uniform float gMin;
layout(location=2) uniform float gMax;
in vec2 texcoord;
out vec4 fragColor;
void main(){
	vec4 pix=texture(texdata,texcoord);
	float g=clamp(pix.r,gMin,gMax);
	g=(g-gMin)/(gMax-gMin);
	fragColor=vec4(g,g,g,1f);
}";
			progData=  MakeGLProgram(dataVSsrc, dataFSsrc);
		}

		public override void Draw(ref Vector2 point)
		{
			GL.UseProgram(progData);
			GL.BindTexture(TextureTarget.Texture2D,texData);
			GL.BindVertexArray(vaoQuad);
			GL.UniformMatrix4(0,false,ref targetControl.matVP);
			GL.Uniform1(1,targetControl.grayscaleMin);
			GL.Uniform1(2,targetControl.grayscaleMax);
			GL.DrawArrays(PrimitiveType.TriangleStrip,0,4);

		}

		public override void DoCleanup()
		{
			GL.BindVertexArray(0);
			GL.UseProgram(0);
			if (progData != 0)
				GL.DeleteProgram(progData);
			if (vaoQuad != 0)
				GL.DeleteProgram(vaoQuad);
			if (vboQuadVert != 0)
				GL.DeleteBuffer(vboQuadVert);
			if (vboQuadUv != 0)
				GL.DeleteBuffer(vboQuadUv);
			if (texData!=0)
				GL.DeleteTexture(texData);
		}
	}
}