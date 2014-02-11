
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace acc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Control.CheckForIllegalCrossThreadCalls =false;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Properties.Settings.Default.picopen = true;
                Properties.Settings.Default.Save();
                    f.Visible = true;
            }
            else {
                Properties.Settings.Default.picopen = false;
                Properties.Settings.Default.Save();
                    f.Visible = false;

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/qwe7002/exsound/");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://huangjianghua.cn");
        }















	}
}
