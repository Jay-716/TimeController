﻿namespace TimeController {
    partial class FormTimeController {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMainText = new System.Windows.Forms.Label();
            this.domainUpDownInterval = new System.Windows.Forms.DomainUpDown();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxMainText = new System.Windows.Forms.TextBox();
            this.checkBoxAutoLock = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemLastTimeTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLastTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPutOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInterval.Location = new System.Drawing.Point(9, 9);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(65, 20);
            this.labelInterval.TabIndex = 0;
            this.labelInterval.Text = "提醒间隔";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(9, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(65, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "提醒标题";
            // 
            // labelMainText
            // 
            this.labelMainText.AutoSize = true;
            this.labelMainText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMainText.Location = new System.Drawing.Point(9, 70);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(65, 20);
            this.labelMainText.TabIndex = 2;
            this.labelMainText.Text = "提醒内容";
            // 
            // domainUpDownInterval
            // 
            this.domainUpDownInterval.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownInterval.Location = new System.Drawing.Point(164, 8);
            this.domainUpDownInterval.Name = "domainUpDownInterval";
            this.domainUpDownInterval.Size = new System.Drawing.Size(56, 22);
            this.domainUpDownInterval.TabIndex = 3;
            this.domainUpDownInterval.Text = "35";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTitle.Location = new System.Drawing.Point(80, 40);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(140, 23);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.Text = " 久坐提醒";
            // 
            // textBoxMainText
            // 
            this.textBoxMainText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMainText.Location = new System.Drawing.Point(80, 69);
            this.textBoxMainText.Name = "textBoxMainText";
            this.textBoxMainText.Size = new System.Drawing.Size(140, 23);
            this.textBoxMainText.TabIndex = 5;
            this.textBoxMainText.Text = " 久坐提醒";
            // 
            // checkBoxAutoLock
            // 
            this.checkBoxAutoLock.AutoSize = true;
            this.checkBoxAutoLock.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAutoLock.Location = new System.Drawing.Point(13, 102);
            this.checkBoxAutoLock.Name = "checkBoxAutoLock";
            this.checkBoxAutoLock.Size = new System.Drawing.Size(75, 21);
            this.checkBoxAutoLock.TabIndex = 6;
            this.checkBoxAutoLock.Text = "自动锁定";
            this.checkBoxAutoLock.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStart.Location = new System.Drawing.Point(145, 102);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "确定";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "久坐提醒";
            this.notifyIcon.BalloonTipTitle = "久坐提醒";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Text = "00:00:00";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLastTimeTitle,
            this.toolStripMenuItemLastTime,
            this.toolStripSeparator,
            this.toolStripMenuItemPutOff,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(191, 98);
            // 
            // toolStripMenuItemLastTimeTitle
            // 
            this.toolStripMenuItemLastTimeTitle.Enabled = false;
            this.toolStripMenuItemLastTimeTitle.Name = "toolStripMenuItemLastTimeTitle";
            this.toolStripMenuItemLastTimeTitle.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemLastTimeTitle.Text = "Last Time:";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(187, 6);
            // 
            // toolStripMenuItemLastTime
            // 
            this.toolStripMenuItemLastTime.Enabled = false;
            this.toolStripMenuItemLastTime.Name = "toolStripMenuItemLastTime";
            this.toolStripMenuItemLastTime.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemLastTime.Text = "00:00:00 (hh:mm:ss)";
            // 
            // toolStripMenuItemPutOff
            // 
            this.toolStripMenuItemPutOff.Name = "toolStripMenuItemPutOff";
            this.toolStripMenuItemPutOff.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemPutOff.Text = "Put Off";
            this.toolStripMenuItemPutOff.Click += new System.EventHandler(this.toolStripMenuItemPutOff_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // FormTimeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 131);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxAutoLock);
            this.Controls.Add(this.textBoxMainText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.domainUpDownInterval);
            this.Controls.Add(this.labelMainText);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTimeController";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TimeController";
            this.TopMost = true;
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMainText;
        private System.Windows.Forms.DomainUpDown domainUpDownInterval;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxMainText;
        private System.Windows.Forms.CheckBox checkBoxAutoLock;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLastTimeTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLastTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPutOff;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

