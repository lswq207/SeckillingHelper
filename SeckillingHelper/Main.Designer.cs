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
			this.tmrClick = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtHour = new System.Windows.Forms.TextBox();
			this.txtMinute = new System.Windows.Forms.TextBox();
			this.txtSecond = new System.Windows.Forms.TextBox();
			this.txtMilliSecond = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chkKeepClick = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtClickInterval = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrClick
			// 
			this.tmrClick.Interval = 50;
			this.tmrClick.Tick += new System.EventHandler(this.tmrClick_Tick);
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
			this.tableLayoutPanel1.Controls.Add(this.txtHour, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtMinute, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtSecond, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtMilliSecond, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 8, 0);
			this.tableLayoutPanel1.Controls.Add(this.chkKeepClick, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 6, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtClickInterval, 8, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 66);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtHour
			// 
			this.txtHour.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtHour.Location = new System.Drawing.Point(23, 3);
			this.txtHour.Name = "txtHour";
			this.txtHour.Size = new System.Drawing.Size(39, 22);
			this.txtHour.TabIndex = 0;
			// 
			// txtMinute
			// 
			this.txtMinute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMinute.Location = new System.Drawing.Point(113, 3);
			this.txtMinute.Name = "txtMinute";
			this.txtMinute.Size = new System.Drawing.Size(39, 22);
			this.txtMinute.TabIndex = 1;
			// 
			// txtSecond
			// 
			this.txtSecond.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSecond.Location = new System.Drawing.Point(203, 3);
			this.txtSecond.Name = "txtSecond";
			this.txtSecond.Size = new System.Drawing.Size(39, 22);
			this.txtSecond.TabIndex = 2;
			// 
			// txtMilliSecond
			// 
			this.txtMilliSecond.Location = new System.Drawing.Point(293, 3);
			this.txtMilliSecond.Name = "txtMilliSecond";
			this.txtMilliSecond.Size = new System.Drawing.Size(39, 22);
			this.txtMilliSecond.TabIndex = 3;
			// 
			// btnStart
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnStart, 3);
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Location = new System.Drawing.Point(23, 33);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(129, 30);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "开始运行(&S)";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(68, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "点";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(158, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 30);
			this.label2.TabIndex = 5;
			this.label2.Text = "分";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(248, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 30);
			this.label3.TabIndex = 6;
			this.label3.Text = "秒";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(338, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 30);
			this.label4.TabIndex = 7;
			this.label4.Text = "毫秒";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkKeepClick
			// 
			this.chkKeepClick.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.chkKeepClick, 2);
			this.chkKeepClick.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkKeepClick.Location = new System.Drawing.Point(158, 33);
			this.chkKeepClick.Name = "chkKeepClick";
			this.chkKeepClick.Size = new System.Drawing.Size(84, 30);
			this.chkKeepClick.TabIndex = 8;
			this.chkKeepClick.Text = "保持点击";
			this.chkKeepClick.UseVisualStyleBackColor = true;
			this.chkKeepClick.CheckedChanged += new System.EventHandler(this.chkKeepClick_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(248, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 36);
			this.label5.TabIndex = 9;
			this.label5.Text = "间隔（毫秒）";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtClickInterval
			// 
			this.txtClickInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtClickInterval.Enabled = false;
			this.txtClickInterval.Location = new System.Drawing.Point(338, 33);
			this.txtClickInterval.Name = "txtClickInterval";
			this.txtClickInterval.Size = new System.Drawing.Size(39, 22);
			this.txtClickInterval.TabIndex = 10;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 66);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrClick;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtHour;
		private System.Windows.Forms.TextBox txtMinute;
		private System.Windows.Forms.TextBox txtSecond;
		private System.Windows.Forms.TextBox txtMilliSecond;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkKeepClick;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtClickInterval;

	}
}

