using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace FigureFormGL.CustomGLControl
{
	internal abstract class UIToolBase
	{
		public CustomGL targetControl;
		public bool Enabled;

		protected UIToolBase(CustomGL targetControl, bool enabled = false)
		{
			this.targetControl = targetControl;
			this.Enabled = enabled;
		}
		public abstract void Initialize();
		public abstract void Draw(ref Vector2 point);
		public abstract void DoCleanup();

		protected int MakeGLProgram(string vsSrc, string fsSrc)
		{
			int vs = GL.CreateShader(ShaderType.VertexShader);
			int fs = GL.CreateShader(ShaderType.FragmentShader);
			GL.ShaderSource(vs, vsSrc);
			GL.ShaderSource(fs, fsSrc);
			GL.CompileShader(vs);
			GL.GetShader(vs, ShaderParameter.CompileStatus, out int vsstat);
			if (vsstat == 0)
			{
				GL.GetShaderInfoLog(vs, out string info);
				Debug.WriteLine("VS:" + info);
				GL.DeleteShader(vs);
				return 0;
			}

			GL.CompileShader(fs);
			GL.GetShader(fs, ShaderParameter.CompileStatus, out int fsstat);
			if (fsstat == 0)
			{
				GL.GetShaderInfoLog(fs, out string info);
				Debug.WriteLine("FS:" + info);
				GL.DeleteShader(vs);
				GL.DeleteShader(fs);
				return 0;
			}

			int program = GL.CreateProgram();
			GL.AttachShader(program, vs);
			GL.AttachShader(program, fs);
			GL.LinkProgram(program);
			GL.GetProgram(program, GetProgramParameterName.LinkStatus, out int linkstat);
			if (linkstat == 0)
			{
				GL.GetProgramInfoLog(program, out string info);
				Debug.WriteLine("Program:" + info);
				GL.DeleteShader(vs);
				GL.DeleteShader(fs);
				GL.DeleteProgram(program);
				return 0;
			}

			GL.DetachShader(program, vs);
			GL.DetachShader(program, fs);
			GL.DeleteShader(vs);
			GL.DeleteShader(fs);
			return program;
		}

	}
}
