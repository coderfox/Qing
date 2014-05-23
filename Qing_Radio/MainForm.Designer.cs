namespace Qing_Radio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerButton = new System.Windows.Forms.Button();
            this.setTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "下一个时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件路径";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(110, 12);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(353, 29);
            this.timeBox.TabIndex = 2;
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(110, 48);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(315, 29);
            this.fileBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(431, 48);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(32, 29);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(18, 83);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(445, 29);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "写入设置";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "当前时间";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(233, 119);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(230, 75);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "当前文件";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileLabel.Location = new System.Drawing.Point(105, 266);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(38, 25);
            this.fileLabel.TabIndex = 9;
            this.fileLabel.Text = "C:\\";
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(18, 294);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(445, 33);
            this.pauseButton.TabIndex = 10;
            this.pauseButton.Text = "暂停/播放";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // lockButton
            // 
            this.lockButton.Location = new System.Drawing.Point(18, 333);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(445, 33);
            this.lockButton.TabIndex = 11;
            this.lockButton.Text = "锁定/解锁";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "清_广播室智能控制终端\r\nversion 1, build 0013-rebuild";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "清_选择音乐文件";
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(18, 372);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(445, 33);
            this.timerButton.TabIndex = 13;
            this.timerButton.Text = "校对Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // setTimeLabel
            // 
            this.setTimeLabel.AutoSize = true;
            this.setTimeLabel.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTimeLabel.Location = new System.Drawing.Point(233, 189);
            this.setTimeLabel.Name = "setTimeLabel";
            this.setTimeLabel.Size = new System.Drawing.Size(230, 75);
            this.setTimeLabel.TabIndex = 15;
            this.setTimeLabel.Text = "000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "设定时间";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(469, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(457, 462);
            this.axWindowsMediaPlayer1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 486);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.setTimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "清_广播室智能控制终端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Label setTimeLabel;
        private System.Windows.Forms.Label label7;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

