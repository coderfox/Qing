using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Customized using
using System.Media;
using System.Runtime.InteropServices;

namespace Qing_Radio
{
    public partial class MainForm : Form
    {
        private bool MouseLocked { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]

        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }

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

        private void MainForm_MouseMove(object sender, EventArgs e)
        {
            if (MouseLocked)
            {
                IntPtr awin = GetForegroundWindow(); //获取当前窗口句柄
                RECT rect = new RECT();
                GetWindowRect(awin, ref rect);
                int x = rect.Left;
                int y = rect.Top;
                Cursor.Position = new Point(x+200, y+200);
            }
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
            if (MouseLocked)
            {
                MouseLocked = false;
            }
            else
            {
                MouseLocked = true;
            }
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Enabled = true;
        }
    }
}
