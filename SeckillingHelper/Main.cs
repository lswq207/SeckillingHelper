﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SeckillingHelper
{
	public partial class Main : Form
	{
		private bool isRunning = false;
		private int originalMouseX = 0;
		private int originalMouseY = 0;
		private DateTime targetTime;
		private const int DEFAULT_CLICK_INTERVAL = 200;
		private const double RANDOM_CLICK_INTERVAL_LOWERLIMIT = 0.7;
		private const double RANDOM_CLICK_INTERVAL_UPPERLIMIT = 1.3;

		//#region 仅供测试模拟手动
		//private IList<string> timeStamps = new List<string>();
		//#endregion 


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
			if (ValidateInput())
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
		}

		private void StartRun()
		{
			btnStart.Text = "停止运行(&P)";
			tmrRefresh.Enabled = true;

			if (chkKeepClick.Checked == true)
			{
				tmrClick.Interval = Convert.ToInt32(txtClickInterval.Text);
			}

			int hour = Convert.ToInt32(txtHour.Text);
			int minute = Convert.ToInt32(txtMinute.Text);
			int second = Convert.ToInt32(txtSecond.Text);
			int millisecond = Convert.ToInt32(txtMilliSecond.Text);

			targetTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second, millisecond);
			
			isRunning = true;
			lblLight.BackColor = Color.LightGreen;

			//timeStamps.Clear();
		}

		private void EndRun()
		{
			btnStart.Text = "开始运行(&S)";
			tmrRefresh.Enabled = false;
			tmrClick.Enabled = false;
			isRunning = false;

			lblLight.BackColor = Color.DeepPink;

			if (chkManual.Checked == true)
			{
				tmrClick.Interval = DEFAULT_CLICK_INTERVAL;
			}

			targetTime = DateTime.MaxValue;

			//#region 仅供测试模拟手动
			//string s = "";

			//foreach (var timeStamp in timeStamps)
			//{
			//	s += timeStamp + "\n";
			//}

			//MessageBox.Show(s);
			//#endregion 仅供测试模拟手动
		}

		private void tmrClick_Tick(object sender, EventArgs e)
		{
			
			//如果某次将要点击时鼠标位置不再是开始点击时的位置，则停止运行
			if (MousePosition.X != originalMouseX || MousePosition.Y != originalMouseY)
			{
				EndRun();
			}

			#region 模拟点击鼠标
			mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
			mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
			#endregion

			//timeStamps.Add(DateTime.Now.ToString("H:mm:ss+") + " " + DateTime.Now.Millisecond);

			//如果没选中（保持点击），则再点击一次后就停止运行
			if (chkKeepClick.Checked == false)
			{
				EndRun();
			}

			#region 随机改变点击间隔

			if (chkManual.Checked == true)
			{
				Random random = new Random(Guid.NewGuid().GetHashCode());

				int newInterval = random.Next(Convert.ToInt32(tmrClick.Interval * RANDOM_CLICK_INTERVAL_LOWERLIMIT),
					Convert.ToInt32(tmrClick.Interval * RANDOM_CLICK_INTERVAL_UPPERLIMIT));

				tmrClick.Interval = newInterval;
			}


			#endregion


		}

		private void chkKeepClick_CheckedChanged(object sender, EventArgs e)
		{
			txtClickInterval.Enabled = chkKeepClick.Checked;

			if (txtClickInterval.Enabled == true)
			{
				txtClickInterval.Text = DEFAULT_CLICK_INTERVAL.ToString();
			}
			else
			{
				txtClickInterval.Text = string.Empty;
				chkManual.Checked = false;
			}

			chkManual.Enabled = chkKeepClick.Checked;

		}


		private void tmrRefresh_Tick(object sender, EventArgs e)
		{
			if (DateTime.Now >= targetTime)
			{
				tmrClick.Enabled = true;
				
				#region 保存鼠标开始点击时的位置
				originalMouseX = MousePosition.X;
				originalMouseY = MousePosition.Y;
				#endregion
			}




		}

		private void tmrClock_Tick(object sender, EventArgs e)
		{
			lblClock.Text = DateTime.Now.ToString("H:mm:ss");
		}

		private void txtHour_Enter(object sender, EventArgs e)
		{
			//txtHour.Text = string.Empty;
		}

		private void txtMinute_Enter(object sender, EventArgs e)
		{
			//txtMinute.Text = string.Empty;
		}

		private void txtSecond_Enter(object sender, EventArgs e)
		{
			//txtSecond.Text = string.Empty;
		}

		private void txtClickInterval_Enter(object sender, EventArgs e)
		{
			//txtClickInterval.Text = string.Empty;
		}

		private void txtMilliSecond_Enter(object sender, EventArgs e)
		{
			//txtMilliSecond.Text = string.Empty;
		}

		private void Main_Activated(object sender, EventArgs e)
		{
			
		}

		private bool ValidateInput()
		{
			string regexNumber = "^[0-9]*$";

			string hourText = txtHour.Text.Trim();
			string minuteText = txtMinute.Text.Trim();
			string secondText = txtSecond.Text.Trim();
			string millisecondText = txtMilliSecond.Text.Trim();
			string clickIntervalText = txtClickInterval.Text.Trim();

			if (hourText == string.Empty)
			{
				ShowInputErrorMessageBox("请输入“时”");

				return false;

			}
			else if (!Regex.IsMatch(hourText, regexNumber)
					|| Convert.ToInt32(hourText) < 0
				|| Convert.ToInt32(hourText) >= 24)
			{
				ShowInputErrorMessageBox("“时”应为0~23之间的整数");

				return false;
			}

			else if (minuteText == string.Empty)
			{
				ShowInputErrorMessageBox("请输入“分”");

				return false;
			}
			else if (!Regex.IsMatch(minuteText, regexNumber)
					|| Convert.ToInt32(minuteText) < 0
				|| Convert.ToInt32(minuteText) >= 60)
			{
				ShowInputErrorMessageBox("“分”应为0~59之间的整数");

				return false;
			}

			else if (secondText == string.Empty)
			{
				ShowInputErrorMessageBox("请输入“秒”");

				return false;
			}
			else if (!Regex.IsMatch(secondText, regexNumber)
					|| Convert.ToInt32(secondText) < 0
				|| Convert.ToInt32(secondText) >= 60)
			{
				ShowInputErrorMessageBox("“秒”应为0~59之间的整数");

				return false;
			}

			else if (millisecondText == string.Empty)
			{
				ShowInputErrorMessageBox("请输入“毫秒”");

				return false;
			}
			else if (!Regex.IsMatch(millisecondText, regexNumber)
					|| Convert.ToInt32(millisecondText) < 0
				|| Convert.ToInt32(millisecondText) >= 1000)
			{
				ShowInputErrorMessageBox("“毫秒”应为0~999之间的整数");

				return false;
			}
			else if (Convert.ToInt32(txtHour.Text) <= DateTime.Now.Hour
			         && Convert.ToInt32(txtMinute.Text) <= DateTime.Now.Minute
			         && Convert.ToInt32(txtSecond.Text) <= DateTime.Now.Second)
			{
				ShowInputErrorMessageBox("只允许输入未来的时间点");
				return false;
			}

			if (chkKeepClick.Checked == true)
			{
				if (clickIntervalText == string.Empty)
				{
					ShowInputErrorMessageBox("请输入“间隔”");

					return false;
				}
				else if (!Regex.IsMatch(clickIntervalText, regexNumber)
					|| Convert.ToInt32(clickIntervalText) < 0
				|| Convert.ToInt32(clickIntervalText) >= 1000)
				{
					ShowInputErrorMessageBox("“间隔”应为0~999之间的整数");

					return false;
				}

			}
			
			return true;


		}

		private void ShowInputErrorMessageBox(string text)
		{
			MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void lblClock_Click(object sender, EventArgs e)
		{

		}

		private void Main_Shown(object sender, EventArgs e)
		{
			//txtHour.Focus();
		}


	}
}
