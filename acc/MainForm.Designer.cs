using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing; 
namespace acc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 163);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(349, 45);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 167);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "解析器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(8, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "显示up主头像";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "洗脑循环";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(207, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 16);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "bilisound";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "当前状态：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 21);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "唱吧试听地址：";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(149, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "5sing";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(97, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "唱吧";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "来源解析模式：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "试听";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "关于";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "Github项目首页";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "本程序仅供学习使用，使用此程序导致的一切纠纷与作者无关。";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "bilibili解析来自bilisound";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "作者：qwe7002";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "v1.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "exsound解析器";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "作者博客";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 210);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exsond解析器";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }
		private Thread th1;
        private SaveFileDialog saveFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        string name = "";
        Form1 f = new Form1();
        bool 解析禁止=false;
		void MainFormLoad(object sender, System.EventArgs e)
        {
            checkBox2.Checked = Properties.Settings.Default.picopen;
            int x=this.Location.X-f.Size.Width-20;
            int y=this.Location.Y;
            f.Location = new Point(x, y);
            label10.Text = "您已经使用exsound成功解析" + Properties.Settings.Default.loop + "次";
            axWindowsMediaPlayer1.URL = Application.StartupPath + "/error.wma";
            输出("初恋旧爱新欢 感谢RAINBOW计划提供版权！");
		}

        void 计次() {
            int intloop=Convert.ToInt32(Properties.Settings.Default.loop);
            intloop = intloop + 1;
            Properties.Settings.Default.loop = Convert.ToString(intloop);
            Properties.Settings.Default.Save();

            label10.Text = "您已经使用exsound成功解析" + Convert.ToString(intloop) + "次";
        }
         void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "视频番号/地址：";
        }
		void RadioButton1CheckedChanged(object sender, System.EventArgs e)
		{
			label2.Text="唱吧试听地址：";
		}
		
		void TextBox1TextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void Button1_Click(object sender, System.EventArgs e)
		{
            自动判断();
            /*试听*/
            if (解析禁止 == false)
            {
                th1 = new Thread(new ThreadStart(试听));
                th1.SetApartmentState(ApartmentState.STA);
                th1.Start();
            }
            else {
                输出("检测到一条线程正在解析，请不要重复提交。");
            }
			 
		}
		
		void Button2_Click(object sender, System.EventArgs e)
        {
            自动判断();
             if (解析禁止 == false)
            {
			//下载
            th1 = new Thread(new ThreadStart(下载));
            th1.SetApartmentState(ApartmentState.STA);
            th1.Start();
            }
             else
             {
                 输出("检测到一条线程正在解析，请不要重复提交。");
             }

		}
		
		void RadioButton2CheckedChanged(object sender, System.EventArgs e)
		{
			label2.Text="5sing试听地址：";
			
		}
        void 自动判断() {
            string doma=取域名(textBox1.Text);
            if (doma == "changba.com")
            {
                radioButton1.Checked = true;
            }
            if (doma == "fc.5sing.com" || doma == "yc.5sing.com" || doma == "bz.5sing.com")
            {
                radioButton2.Checked = true;
            }
            if (doma == "www.bilibili.tv" || doma == "bilibili.kankanews.com")
            {
                radioButton3.Checked = true;
            }

        }
		void 输出(string text)
		{
			label3.Text="当前状态："+text;
            
		}
		public void 试听(){
            string mp3url=解析(textBox1.Text);
            if (mp3url != "error")
            {
                axWindowsMediaPlayer1.URL = mp3url;
                输出(name);
                if (checkBox2.Checked)
                {
                    Thread thread = new Thread(new ThreadStart(() =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            checkBox2.Enabled = true;
                            f.Visible = true;
                        }));
                    }));
                    thread.Start();
                }
            }
            else {
                MessageBox.Show("解析失败!");
                输出("解析失败!请检查地址正确性");
            }
		}

        public void 下载()
        {
            string mp3url = 解析(textBox1.Text);
            if (mp3url != "error")
            {
                输出("开始收集下载信息");
                saveFileDialog1.Filter = "音乐文件（*.mp3）|*.mp3";
                saveFileDialog1.FileName = name;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    下载模块(mp3url, saveFileDialog1.FileName.ToString());
                    输出("下载完成!");
                }
                else { 
                    输出("下载操作被取消"); 
                }
            }
            else
            {
                MessageBox.Show("解析失败!");
                输出("解析失败!请检查地址正确性");

            }
        }
		
		string 解析(string url){
			string inurl = url;
			string backurl = "";
			if(url==""){
				MessageBox.Show("请输入您要试听的录音地址。","错误！");
				输出("请输入您要试听的录音地址!");
				return("error");
			}else{
                解析禁止 = true;
                if (radioButton2.Checked && radioButton1.Checked && inurl.Contains("http") == false)
                {
                    return("error"); }
				输出("解析中……");
				if(radioButton3.Checked){
            inurl=inurl.Replace("#", "");
				}
                if (radioButton3.Checked) {
                    if (inurl.Contains("http")) {
                        inurl=取出中间文本(inurl, "http://"+取域名(inurl)+"/video/", "/");
                    }
                    inurl = "https://bilibili.fm/" + inurl + "/1.mp3";
                }


				string backstring=网页访问(inurl);
                输出调试文本(backurl);
				if(backstring==""){
                    解析禁止 = false;
                    return ("error");
                    
				}else{
					if(radioButton1.Checked){
						backurl=取出中间文本(backstring,"Media\", {mp3:\"","\"})");
						输出调试文本(backurl);
                        if (backurl == "")
                        {
                            解析禁止 = false;
                            return ("error");
                            
                        }
                        else {
                            name = 取出中间文本(backstring, "<title>", "唱吧,最时尚的手机KTV</title>");
                            this.Text = name;
                            f.pictureBox1.ImageLocation = 取出中间文本(backstring, "width=\"460px\" height=\"460px\" src=\"", "\" />");
                            backurl = 编码唱吧(backurl); 
                        }
					}else if (radioButton2.Checked){
                        backurl = 取出中间文本(backstring, "file: \"", "\"");
                        
                        if (backurl == "")
                        {
                            解析禁止 = false;
                            return ("error");
                            
                        }
                        else
                        {
                            f.pictureBox1.ImageLocation = 取出中间文本(backstring, "target=\"_blank\"><img src=\"", "\" width=\"180\"");
                            name = 取出中间文本(backstring, "<title>", "歌曲,歌词");
                            this.Text = name;
                        }
                    }else {
                            backurl = 取出中间文本(backstring, "content=0;url=", ">");
                            
                            if (backurl == "")
                            {
                                解析禁止 = false;
                                return ("error");
                            }
                            else
                            {
                                inurl = url;
                                if (inurl.Contains("http"))
                                {
                                    inurl = 取出中间文本(inurl, "http://" + 取域名(inurl) + "/video/", "/");
                                }
                                inurl = "https://bilibili.fm/" + inurl;
                                backstring = 网页访问(inurl);
                                f.pictureBox1.ImageLocation = 取出中间文本(backstring, "[cthumb] => ", "[ptime]");
                                name = 取出中间文本(backstring, "<title>", "</title>");
                                this.Text = name;
                            }
                        }
                   
				}
                计次();
                解析禁止 = false;
				输出("解析完毕！");
				return(backurl);
				
				
				
			}
		}


      

        string 编码唱吧(string backurl)
        {
            if (取域名(backurl) != "upuwmp3.changba.com")
            {
                if (取域名(backurl) == "mp3.changba.com")
                {
                    string temp = 取出中间文本(backurl, "userwork/", "/");
                    if (temp.Substring(0, 1) == "c")
                    {
                        输出("编码地址");
                        string a1 = 取出中间文本(backurl, "userwork/c", "/");
                        输出调试文本(a1);
                        string a2 = Convert.ToString(Convert.ToInt32(a1, 8));
                        输出调试文本(a2);
                        string a3 = 取出中间文本(backurl, a1 + "/", "/");
                        输出调试文本(a3);
                        string a4 = 取出中间文本(backurl, a3 + "/", ".mp3");
                        Int64 f = Convert.ToInt64(a4, 16) / Convert.ToInt32(a2) / Convert.ToInt32(a2);
                        输出调试文本(a4);
                        backurl = "http://aliuwmp3.changba.com/userdata/userwork/" + f + ".mp3";
                        return (backurl);
                    }
                    else
                    {
                        输出("编码地址");
                        string a1 = 取出中间文本(backurl, "userwork/a", "/");
                        输出调试文本(a1);
                        if (a1 == "")
                        {
                            a1 = 取出中间文本(backurl, "userwork/b", "/");
                        }
                        string a2 = Convert.ToString(Convert.ToInt32(a1, 8));
                        输出调试文本(a2);
                        string a3 = 取出中间文本(backurl, a1 + "/", "/");
                        输出调试文本(a3);
                        string i = Convert.ToString(Convert.ToInt32(a3, 16) / Convert.ToInt32(a2) / Convert.ToInt32(a2));
                        string a4 = 取出中间文本(backurl, a3 + "/", ".mp3");
                        Int64 f = Convert.ToInt64(a4, 16) / Convert.ToInt32(a2) / Convert.ToInt32(a2);
                        输出调试文本(a4);
                        backurl = "http://a" + a2 + "mp3.changba.com/userdata/userwork/" + i + "/" + f + ".mp3";
                    }

                }
                输出("解析编码完成！");
                return (backurl);
            }
            return (backurl);
        }
		
		
    private string 网页访问(string url)
{

    try
    {
        System.Net.WebRequest wReq = System.Net.WebRequest.Create(url);
        System.Net.WebResponse wResp = wReq.GetResponse();
        System.IO.Stream respStream = wResp.GetResponseStream();
        using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream, Encoding.UTF8))
        {
            return reader.ReadToEnd();
        }
    }
    catch (System.Exception)
    {
        
    }
    return "";


}

    public string 取出中间文本(string str, string str1, string str2)
{
int leftlocation;
int rightlocation;
    int strmidlength; ;
string strmid; 
    leftlocation = str.IndexOf(str1);
    if (leftlocation == -1)
{
return "";
}
leftlocation = leftlocation + str1.Length;
rightlocation = str.IndexOf(str2, leftlocation);
    if (rightlocation == -1 || leftlocation > rightlocation)
{
return "";
}
strmidlength = rightlocation - leftlocation;
    strmid = str.Substring(leftlocation, strmidlength);
    return strmid;
}
    
		void 输出调试文本(string TEXT){
			System.Diagnostics.Debug.WriteLine(TEXT);
		}
		
		
		
					
		private string  取域名(string url)     
   {     
       string text = url;     
       string pattern = @"(?<=http://)[\w\.]+[^/]";
       string s = "";     
       MatchCollection mc = Regex.Matches(text, pattern);  
       foreach (Match match in mc)     
       {     
           s = match.ToString();     
       }     
       return s;     
        
   }

        void 下载模块(string url, string name) {
            写到文本(url, "d:/download.txt");
            写到文本(name, "d:/name.txt");
            var proc = System.Diagnostics.Process.Start(Application.StartupPath + "/httpDown.exe");
            proc.WaitForExit(); 
            File.Delete("d:/download.txt");
            File.Delete("d:/name.txt");
        }

        void 写到文本(string 内容,string 文件名) {
            FileStream fs = new FileStream(文件名, FileMode.OpenOrCreate);
            string test = 内容;
            byte[] bytes = Encoding.Default.GetBytes(test);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

        }

        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RadioButton radioButton3;
        public Label label3;
        private TextBox textBox1;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TabPage tabPage2;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckBox checkBox1;
        public CheckBox checkBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        
	}
}
