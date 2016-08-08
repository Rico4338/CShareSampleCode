using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSleepTest
{
    public partial class Form1 : Form
    {
        int mTimerNo = 0;
        int mThreadSleepNo = 0;
        int mNotBlockNo = 0;
        int mTenSleepNo = 0;
        int mTenNotBlockNo = 0;
        readonly int mDelayTime = 5000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThreadSleep_Click(object sender, EventArgs e)
        {
            SetLabelAdd(UILabelType.ThreadSleep);
        }

        private void btn_notBlock_Click(object sender, EventArgs e)
        {
            SetLabelAdd(UILabelType.NotBlock);
        }

        private void btn_TenSleep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    Thread.Sleep(mDelayTime);
                }).ContinueWith(t =>
                {
                    mTenSleepNo++;
                });
            }
        }

        private void btn_TenNotBlock_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(async () =>
                {
                    await Task.Delay(mDelayTime);
                }).ContinueWith(t =>
                {
                    mTenNotBlockNo++;
                });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetLabelAdd(UILabelType.Timer);
        }

        async void SetLabelAdd(UILabelType gLabelType)
        {
            switch (gLabelType)
            {
                case UILabelType.ThreadSleep:
                    UIAddThreadSleep();
                    break;
                case UILabelType.NotBlock:
                    await UIAddNotBlock();
                    break;
                case UILabelType.Timer:
                    UIAddTimer();
                    break;
            }
        }

        void UIAddTimer()
        {
            mTimerNo++;
            lbl_Timer.Text = mTimerNo.ToString();

            lbl_TenNotBlock.Text = "NonBlock Run : " + mTenNotBlockNo.ToString();
            lbl_TenSleep.Text = "Sleep Run : " + mTenSleepNo.ToString();
        }

        async Task UIAddNotBlock()
        {
            mNotBlockNo++;
            lbl_NonBlock.Text = mNotBlockNo.ToString();
            await Task.Delay(mDelayTime);

        }

        void UIAddThreadSleep()
        {
            mThreadSleepNo++;
            lbl_ThreadSleep.Text = mThreadSleepNo.ToString();
            Thread.Sleep(mDelayTime);
        }
    }

    enum UILabelType
    {
        ThreadSleep,
        NotBlock,
        Timer
    }
}
