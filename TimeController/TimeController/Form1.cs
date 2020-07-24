using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeController {
    public partial class FormTimeController : Form {
        private DateTime NextTime = DateTime.Now;
        private System.Timers.Timer Timer = new System.Timers.Timer();
        private double Interval;
        private bool AutoLock;

        public FormTimeController() {
            InitializeComponent();
            this.NextTime = DateTime.Now.AddMinutes(Convert.ToDouble(this.domainUpDownInterval.Text));
            this.Timer.Interval = Convert.ToDouble(this.domainUpDownInterval.Text);
            this.Timer.Interval = 1000;
            this.Timer.Elapsed += Timer_Tick;
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            this.NextTime = DateTime.Now.AddMinutes(Convert.ToDouble(this.domainUpDownInterval.Text));
            if(Convert.ToDouble(this.domainUpDownInterval.Text) <= 0) {
                MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.domainUpDownInterval.Text = "35";
            }
            this.notifyIcon.Icon = SystemIcons.Warning;
            this.notifyIcon.BalloonTipTitle = this.textBoxTitle.Text;
            this.notifyIcon.BalloonTipText = this.textBoxMainText.Text;
            this.notifyIcon.Visible = true;
            this.Interval = Convert.ToDouble(this.domainUpDownInterval.Text);
            this.AutoLock = this.checkBoxAutoLock.Checked;
            this.Timer.Enabled = true;
            base.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            TimeSpan lastTime = this.NextTime - DateTime.Now;
            if(lastTime < TimeSpan.Zero) {
                this.NextTime = DateTime.Now.AddMinutes(this.Interval);
                this.notifyIcon.ShowBalloonTip(60000);
                if (AutoLock) {
                    MessageBox.Show("Windows will lock in 10 seconds!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    (new Task(() => {
                        Thread.Sleep(10000);
                        LockWorkStation();
                    })).Start();
                }
            }
            this.notifyIcon.Text = lastTime.ToString().Substring(0, 8) + " (hh:mm:ss)";
            this.toolStripMenuItemLastTime.Text = notifyIcon.Text;
        }

        private void toolStripMenuItemPutOff_Click(object sender, EventArgs e) {
            this.NextTime = DateTime.Now.AddMinutes(this.Interval);
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e) {
            this.Timer.Stop();
            Application.Exit();
        }

        [DllImport("user32.dll")]
        private static extern bool LockWorkStation();
    }
}
