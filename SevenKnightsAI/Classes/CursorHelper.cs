using System;
using System.Windows.Forms;

namespace SevenKnightsAI.Classes
{
	
	internal class CursorHelper
	{
		
		public static void ChangeCursor(Form form, Cursor cursor)
		{
			try
			{
				form.Invoke(new MethodInvoker(delegate
				{
					form.Cursor = cursor;
					if (cursor == Cursors.WaitCursor)
					{
						Application.DoEvents();
					}
				}));
			}
			catch
			{ }
		}

		
		public static void DefaultCursor(Form form)
		{
			CursorHelper.ChangeCursor(form, Cursors.Default);
		}

		
		public static void WaitCursor(Form form)
		{
			CursorHelper.ChangeCursor(form, Cursors.WaitCursor);
		}
	}
}
