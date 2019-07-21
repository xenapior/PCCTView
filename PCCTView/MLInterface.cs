using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCTView
{
	public static class MLInterface
	{
		private static volatile MainForm form;

		/// <summary>
		/// Start a Winform window in a new thread.
		/// </summary>
		public static void InitMainWindow()
		{
			Thread t = new Thread(uiThread);
			t.SetApartmentState(ApartmentState.STA);
			t.Start();
			while (true)
			{
				if (form != null)
					break;
				Thread.Sleep(0);
			}
		}

		// UI thread
		private static void uiThread()
		{
			// check duplicate main window
			if (form != null)
				return;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			form = new MainForm();
			Application.Run(form);
			form.Dispose();
			form = null;
		}

		public static bool IsWindowExist()
		{
			return form != null;
		}
		
		/// <summary>
		/// Query ready-state of all settings for next steps.
		/// If ready, a subsequent call to GetSetting() will retrieve parameters.
		/// </summary>
		public static bool IsSettingReady()
		{
			if (form == null)
				throw new NullReferenceException("主窗口不存在");
			return form.SettingReady;
		}

		/// <summary>
		/// Get all settings.
		/// </summary>
		/// <returns></returns>
		public static Setting GetSetting()
		{
			if (form == null)
				throw new NullReferenceException("主窗口不存在");
			form.SettingReady = false;
			return form.settings;
		}

		/******************************************/
		/* Followings are respondings to MainForm */
		/******************************************/

		/// <summary>
		/// Must call this when data is ready to be sent to MainWindow.
		/// </summary>
		public static void SetServerDataReady()
		{
			if (form == null)
				throw new NullReferenceException("主窗口不存在");
			form.serverDataReady = true;
		}

		public static void SendTextMsg(string s)
		{
			if (form == null)
				throw new NullReferenceException("主窗口不存在");
			form.message = s;
		}

		public static void PlotImage(float[] mat, int width, string title=null)
		{
			if (form == null)
				throw new NullReferenceException("主窗口不存在");

			form.NewFigure(mat,width,title);
			//todo: add conversion to linear F32 array -> request MainForm to start a new FigureForm and buffer
		}

//		public static void Send3DArray(double[,,] arr, string title=null)
//		{
//			if (form == null)
//				throw new NullReferenceException("主窗口不存在");
//
//		}
	}
}
