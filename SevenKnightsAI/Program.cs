using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SevenKnightsAI.Classes;

namespace SevenKnightsAI
{
	
	internal static class Program
	{
		
		[STAThread]
		private static void Main()
		{
			AppDomain.CurrentDomain.ProcessExit += new EventHandler(Program.OnProcessExit);
			Application.ThreadException += new ThreadExceptionEventHandler(Program.OnThreadException);
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Program.OnUnhandledException);
			if (Program.mutex.WaitOne(TimeSpan.Zero, true))
			{
				Dictionary<int, int> obj = new Dictionary<int, int>
				{
					{
						1105,
						1157
					},
					{
						2114,
						2401
					},
					{
						1057,
						2052
					},
					{
						1297,
						1910
					}
				};
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
				Program.mutex.ReleaseMutex();
				return;
			}
			MessageBox.Show("Seven Knights AI is already running.", "Seven Knights AI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Environment.Exit(-1);
		}

		
		private static void OnProcessExit(object sender, EventArgs e)
		{ }

		
		private static void OnThreadException(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.ToString(), "Fatal Thread Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		
		private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show(e.ExceptionObject.ToString(), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		
		private static readonly Mutex mutex = new Mutex(true, "{085A54AC-580E-4BE1-8651-7DE1B1D21410}");
	}
}
