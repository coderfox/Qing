using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Customized using
using System.Media;

namespace Qing_Radio
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
#if DEBUG
            this.label5.Text += "\n发布分支: Debug";
#else
            this.label5.Text += "\n发布分支: Release";
#endif
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HHmmss");
            if (timeLabel.Text == setTimeLabel.Text)
            {
                axWindowsMediaPlayer1.URL = fileLabel.Text;
            }
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            setTimeLabel.Text = timeBox.Text;
            fileLabel.Text = fileBox.Text;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            fileBox.Text = openFileDialog.FileName;
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未实现");
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Enabled = true;
        }
    }
}
