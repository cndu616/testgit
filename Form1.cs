using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _7_闹钟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime timeForTick;
        private void Form1_Load(object sender, EventArgs e)
        {
            //闹钟时间
            timeForTick = new DateTime(2020, 7, 23, 9, 10, 0);
            label1.Text = string.Format("闹钟时间：{0}", timeForTick.ToString());
            //设置定时打开的对象
            musicPlayer.settings.autoStart = false;
            musicPlayer.URL = @"C:\CloudMusic\Candy - Bila.mp3";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            label2.Text = time.ToString();

            if (DateTime.Compare(time, timeForTick) > 0)
            {
                musicPlayer.Ctlcontrols.play();
                label3.Text = musicPlayer.Ctlcontrols.currentItem.name;
                timer1.Enabled = false;



            }
        }
    }
}
