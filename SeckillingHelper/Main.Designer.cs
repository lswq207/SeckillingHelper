namespace SeckillingHelper
{
	partial class Main
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtMinute = new System.Windows.Forms.TextBox();
			this.txtSecond = new System.Windows.Forms.TextBox();
			this.txtMilliSecond = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtClickInterval = new System.Windows.Forms.TextBox();
			this.lblLight = new System.Windows.Forms.Label();
			this.lblClock = new System.Windows.Forms.Label();
			this.txtHour = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.chkKeepClick = new System.Windows.Forms.CheckBox();
			this.chkManual = new System.Windows.Forms.CheckBox();
			this.tmrClick = new System.Windows.Forms.Timer(this.components);
			this.tmrClock = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrRefresh
			// 
			this.tmrRefresh.Interval = 50;
			this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 10;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel1.Controls.Add(this.txtMinute, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtSecond, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtMilliSecond, 7, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 6, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 8, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 6, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtClickInterval, 8, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblLight, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblClock, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtHour, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 143);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtMinute
			// 
			this.txtMinute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMinute.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtMinute.Location = new System.Drawing.Point(113, 37);
			this.txtMinute.MaxLength = 2;
			this.txtMinute.Name = "txtMinute";
			this.txtMinute.Size = new System.Drawing.Size(39, 23);
			this.txtMinute.TabIndex = 1;
			this.txtMinute.Enter += new System.EventHandler(this.txtMinute_Enter);
			// 
			// txtSecond
			// 
			this.txtSecond.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSecond.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtSecond.Location = new System.Drawing.Point(203, 37);
			this.txtSecond.MaxLength = 2;
			this.txtSecond.Name = "txtSecond";
			this.txtSecond.Size = new System.Drawing.Size(39, 23);
			this.txtSecond.TabIndex = 2;
			this.txtSecond.Enter += new System.EventHandler(this.txtSecond_Enter);
			// 
			// txtMilliSecond
			// 
			this.txtMilliSecond.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtMilliSecond.Location = new System.Drawing.Point(293, 37);
			this.txtMilliSecond.MaxLength = 3;
			this.txtMilliSecond.Name = "txtMilliSecond";
			this.txtMilliSecond.Size = new System.Drawing.Size(39, 23);
			this.txtMilliSecond.TabIndex = 4;
			this.txtMilliSecond.Text = "0";
			this.txtMilliSecond.Enter += new System.EventHandler(this.txtMilliSecond_Enter);
			// 
			// btnStart
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnStart, 3);
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnStart.Location = new System.Drawing.Point(23, 71);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(129, 69);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "开始运行(&S)";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(68, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 34);
			this.label1.TabIndex = 4;
			this.label1.Text = "时";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(158, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 34);
			this.label2.TabIndex = 5;
			this.label2.Text = "分";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(248, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 34);
			this.label3.TabIndex = 6;
			this.label3.Text = "秒";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(338, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 34);
			this.label4.TabIndex = 7;
			this.label4.Text = "毫秒";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(248, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 75);
			this.label5.TabIndex = 9;
			this.label5.Text = "间隔（毫秒）";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtClickInterval
			// 
			this.txtClickInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtClickInterval.Enabled = false;
			this.txtClickInterval.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtClickInterval.Location = new System.Drawing.Point(338, 94);
			this.txtClickInterval.MaxLength = 3;
			this.txtClickInterval.Name = "txtClickInterval";
			this.txtClickInterval.Size = new System.Drawing.Size(39, 23);
			this.txtClickInterval.TabIndex = 10;
			this.txtClickInterval.Enter += new System.EventHandler(this.txtClickInterval_Enter);
			// 
			// lblLight
			// 
			this.lblLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLight.AutoSize = true;
			this.lblLight.BackColor = System.Drawing.Color.DeepPink;
			this.lblLight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblLight.Location = new System.Drawing.Point(3, 97);
			this.lblLight.Name = "lblLight";
			this.lblLight.Size = new System.Drawing.Size(14, 17);
			this.lblLight.TabIndex = 11;
			// 
			// lblClock
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.lblClock, 8);
			this.lblClock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblClock.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblClock.Location = new System.Drawing.Point(23, 0);
			this.lblClock.Name = "lblClock";
			this.lblClock.Size = new System.Drawing.Size(354, 34);
			this.lblClock.TabIndex = 12;
			this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
			// 
			// txtHour
			// 
			this.txtHour.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtHour.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtHour.Location = new System.Drawing.Point(23, 37);
			this.txtHour.MaxLength = 2;
			this.txtHour.Name = "txtHour";
			this.txtHour.Size = new System.Drawing.Size(39, 23);
			this.txtHour.TabIndex = 0;
			this.txtHour.Enter += new System.EventHandler(this.txtHour_Enter);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.chkKeepClick, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.chkManual, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 71);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(84, 69);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// chkKeepClick
			// 
			this.chkKeepClick.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.chkKeepClick, 2);
			this.chkKeepClick.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkKeepClick.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.chkKeepClick.Location = new System.Drawing.Point(3, 3);
			this.chkKeepClick.Name = "chkKeepClick";
			this.chkKeepClick.Size = new System.Drawing.Size(78, 28);
			this.chkKeepClick.TabIndex = 9;
			this.chkKeepClick.Text = "保持点击";
			this.chkKeepClick.UseVisualStyleBackColor = true;
			this.chkKeepClick.CheckedChanged += new System.EventHandler(this.chkKeepClick_CheckedChanged);
			// 
			// chkManual
			// 
			this.chkManual.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.chkManual, 2);
			this.chkManual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkManual.Enabled = false;
			this.chkManual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.chkManual.Location = new System.Drawing.Point(3, 37);
			this.chkManual.Name = "chkManual";
			this.chkManual.Size = new System.Drawing.Size(78, 29);
			this.chkManual.TabIndex = 11;
			this.chkManual.Text = "模拟手动";
			this.chkManual.UseVisualStyleBackColor = true;
			// 
			// tmrClick
			// 
			this.tmrClick.Interval = 200;
			this.tmrClick.Tick += new System.EventHandler(this.tmrClick_Tick);
			// 
			// tmrClock
			// 
			this.tmrClock.Enabled = true;
			this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
			// 
			// Main
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 143);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "SecKilling Clicker";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.Main_Activated);
			this.Shown += new System.EventHandler(this.Main_Shown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrRefresh;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtMinute;
		private System.Windows.Forms.TextBox txtSecond;
		private System.Windows.Forms.TextBox txtMilliSecond;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtClickInterval;
		private System.Windows.Forms.Label lblLight;
		private System.Windows.Forms.Timer tmrClick;
		private System.Windows.Forms.Label lblClock;
		private System.Windows.Forms.Timer tmrClock;
		private System.Windows.Forms.TextBox txtHour;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.CheckBox chkKeepClick;
		private System.Windows.Forms.CheckBox chkManual;

	}
}

