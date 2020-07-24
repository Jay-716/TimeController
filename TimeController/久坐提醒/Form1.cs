using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 久坐提醒
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002086 File Offset: 0x00000286
		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002090 File Offset: 0x00000290
		private void button1_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.BalloonTipTitle = this.txtTitle.Text;
			this.notifyIcon1.BalloonTipText = this.txtContent.Text;
			this.minuteinterval = decimal.ToInt32(this.numericUpDown1.Value);
			this.title = this.txtTitle.Text;
			this.nextTime = DateTime.Now.AddMinutes((double)this.minuteinterval);
			this.notifyIcon1.Icon = SystemIcons.Warning;
			this.notifyIcon1.Visible = true;
			this.timer1.Enabled = true;
			base.Visible = false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002140 File Offset: 0x00000340
		private void timer1_Tick(object sender, EventArgs e)
		{
			TimeSpan t = this.nextTime - DateTime.Now;
			bool flag = t < TimeSpan.Zero;
			if (flag)
			{
				this.nextTime = DateTime.Now.AddMinutes((double)this.minuteinterval);
				this.notifyIcon1.ShowBalloonTip(int.MaxValue);
				MessageBox.Show("60秒后自动锁屏", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				(new Task(() => {
					Thread.Sleep(60000);
					LockWorkStation();
				})).Start();
			}
			this.notifyIcon1.Text = this.title + t.ToString("\\(hh\\:mm\\:ss\\)");
			this.lblTimer.Text = this.notifyIcon1.Text;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D8 File Offset: 0x000003D8
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.nextTime = DateTime.Now.AddMinutes((double)this.minuteinterval);
		}

		// Token: 0x04000001 RID: 1
		private int minuteinterval = 35;

		// Token: 0x04000002 RID: 2
		private string title = "";

		// Token: 0x04000003 RID: 3
		private DateTime nextTime = DateTime.Now;

		[DllImport("user32.dll")]
		public static extern bool LockWorkStation();
	}
}
