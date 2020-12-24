using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace IntervalTimers
{
    public partial class TimerControl : UserControl
    {
        int _StartTime; //inital time at creation of control
        int _Time;      //current time being counted down
        SoundPlayer alarm;
        public Stream _CustomSountPath
        {
            set
            {
                alarm.Stream = value;
                alarm.Load();
                if (!alarm.IsLoadCompleted)
                {
                    MessageBox.Show("Error Loading File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    E_CloseControl(this);
                }
            }
        }
        public event Action<TimerControl> E_CloseControl; //used to remove the control from the host form
        public TimerControl(int hours, int minutes, int seconds)
        {
            InitializeComponent();
            alarm = new SoundPlayer(Properties.Resources.Alarm2);
            _StartTime = _Time = (hours * 3600) + (minutes * 60) + seconds;
            UpdateTimeLabel();
            timer1.Start();
            
            
        }
        //timer*************************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            _Time--;
            UpdateTimeLabel();

            if(_Time == 0)
            {
                //PlayAlarm
                alarm.Play();
                ResetTime();
            }
        }
        //ButtonClicks******************************************************************************
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTime();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            E_CloseControl(this);
        }
        //Misc**************************************************************************************
        void UpdateTimeLabel()
        {
            lblTime.Text = $"{_Time/3600}:{(_Time % 3600) / 60}:{((_Time % 3600) % 60)}";
        }
        void ResetTime()
        {
            _Time = _StartTime;
            UpdateTimeLabel();
        }
    }
}
