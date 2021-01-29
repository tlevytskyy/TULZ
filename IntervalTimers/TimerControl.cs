using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading.Tasks;

namespace IntervalTimers
{
    public partial class TimerControl : UserControl
    {
        int _StartTime; //inital time at creation of control
        int _Time;      //current time being counted down
        SoundPlayer alarm; // stream of alarm sound
        private int _increment;     //determines if the clock is incremented up or down
        bool _repeat;   //timers runs in a loop if true
        public Stream _CustomSountPath
        {
            set
            {
                alarm.Stream = value;
                alarm.Load();
                if (!alarm.IsLoadCompleted)
                {
                    MessageBox.Show("Error Loading File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (E_CloseControl != null) E_CloseControl(this);
                }
            }
        } //sets the alarm sound
        public event Action<TimerControl> E_CloseControl; //used to remove the control from the host form

        public TimerControl()
        {
            InitializeComponent();
            alarm = new SoundPlayer(Properties.Resources.Alarm2);
            _StartTime = _Time = 0;
            UpdateTimeLabel();
            _increment = 1;
            _repeat = false;
            
        }
        public TimerControl(int hours, int minutes, int seconds,bool repeat)
        {
            InitializeComponent();
            alarm = new SoundPlayer(Properties.Resources.Alarm2);
            _StartTime = _Time = (hours * 3600) + (minutes * 60) + seconds;
            UpdateTimeLabel();
            _increment = -1;
            timer1.Start();
            _repeat = repeat;
        }
        //timer*************************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            _Time += _increment;
            UpdateTimeLabel();

            if(_Time == 0)
            {
                //PlayAlarm
                PlayAlarmAsync();
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
            if (E_CloseControl != null) E_CloseControl(this);
        }
        //Misc**************************************************************************************
        private void UpdateTimeLabel()
        {
            lblTime.Text = $"{_Time / 3600:D2}:{_Time % 3600 / 60:D2}:{_Time % 3600 % 60:D2}";
        }

        private void ResetTime()
        {
            _Time = _StartTime;
            UpdateTimeLabel();
        }
        private void ResetTimeStop()
        {
            _Time = _StartTime;
            UpdateTimeLabel();
            timer1.Stop();
        }
        private async void PlayAlarmAsync()
        {
            await Task.Run(() => alarm.Play());
            if (_repeat) ResetTime();
            else ResetTimeStop();
            
        }
        //Public Exposed Methods*******************************************************************
        public void Start()
        {
            timer1.Start();
        }
        public void Stop()
        {
            timer1.Stop();
        }
        public void Reset()
        {
            ResetTime();
        }
        public void Close()
        {
            if (E_CloseControl != null) E_CloseControl(this);
        }
    }
}
