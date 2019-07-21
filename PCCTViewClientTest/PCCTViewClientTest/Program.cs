using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PCCTView;

using static System.Console;
namespace PCCTViewClientTest
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("ML start.");
			MLInterface.InitMainWindow();

Repeat:		do
			{
				Thread.Sleep(0);
				if (!MLInterface.IsWindowExist())
					return;
			}
			while (!MLInterface.IsSettingReady());
			var a = MLInterface.GetSetting();

			// MATLAB function dataprocess()
			WriteLine("Setting is received: " + a.teststr);
			var rl = ReadLine();
			MLInterface.SendTextMsg(rl);	// optional
			Thread.Sleep(1000);
			WriteLine("Complete!");
			MLInterface.SetServerDataReady();	// neccesary
			MLInterface.PlotImage(null,0);	// final data
			// MATLAB end

			goto Repeat;
		}
	}
}
