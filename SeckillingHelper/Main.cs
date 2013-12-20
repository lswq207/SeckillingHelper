using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SeckillingHelper
{
	public partial class Main : Form
	{
		private static bool isRunning = false;
		private static int previouseMouseX = 0;
		private static int previousMouseY = 0;
		private const int DEFAULT_TIMER_INTERVAL = 100;


		//[StructLayout(LayoutKind.Sequential)]
		//private struct NativeRECT
		//{
		//	public int left;
		//	public int top;
		//	public int right;
		//	public int bottom;
		//}

		[Flags]
		private enum MouseEventFlag : uint
		{
			//Move = 0x0001,
			LeftDown = 0x0002,
			LeftUp = 0x0004,
			//RightDown = 0x0008,
			//RightUp = 0x0010,
			//MiddleDown = 0x0020,
			//MiddleUp = 0x0040,
			//XDown = 0x0080,
			//XUp = 0x0100,
			//Wheel = 0x0800,
			//VirtualDesk = 0x4000,
			//Absolute = 0x8000
		}

		//[DllImport("user32.dll")]
		//private static extern bool SetCursorPos(int X, int Y);

		[DllImport("user32.dll")]
		private static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);

		//[DllImport("user32.dll")]
		//private static extern IntPtr FindWindow(string strClass, string strWindow);

		//[DllImport("user32.dll")]
		//private static extern IntPtr FindWindowEx(HandleRef hwndParent, HandleRef hwndChildAfter, string strClass,
		//	string strWindow);

		//[DllImport("user32.dll")]
		//private static extern bool GetWindowRect(HandleRef hwnd, out NativeRECT rect);


		//private const int AnimationCount = 80;

		//private Point endPosition;

		//private int count;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (isRunning == false)
			{
				StartRun();
			}
			else
			{
				EndRun();
			}




		}

		private void StartRun()
		{
			btnStart.Text = "停止运行(&P)";
			tmrClick.Enabled = true;
			previouseMouseX = MousePosition.X;
			previousMouseY = MousePosition.Y;

		}

		private void EndRun()
		{
			btnStart.Text = "开始运行(&S)";
			tmrClick.Enabled = false;
			tmrClick.Interval = DEFAULT_TIMER_INTERVAL;
		}

		private void tmrClick_Tick(object sender, EventArgs e)
		{
			int hour = Convert.ToInt32(txtHour.Text);
			int minute = Convert.ToInt32(txtMinute.Text);
			int second = Convert.ToInt32(txtSecond.Text);
			int millisecond = Convert.ToInt32(txtMilliSecond.Text);

			DateTime targetTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second, millisecond);

			if (DateTime.Now >= targetTime)
			{
				if (MousePosition.X != previouseMouseX || MousePosition.Y != previousMouseY)
				{
					EndRun();
				}

				mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
				mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);

				tmrClick.Interval = Convert.ToInt32(txtClickInterval.Text);

				if (chkKeepClick.Checked == false)
				{
					EndRun();
				}

			}

			previouseMouseX = MousePosition.X;
			previousMouseY = MousePosition.Y;


		}

		private void chkKeepClick_CheckedChanged(object sender, EventArgs e)
		{
			txtClickInterval.Enabled = chkKeepClick.Checked;
			txtClickInterval.Text = string.Empty;
		}


	}
}
