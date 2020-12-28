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
        } //sets the alarm sound
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
            E_CloseControl(this);
        }
        //Misc**************************************************************************************
        private void UpdateTimeLabel()
        {
            lblTime.Text = $"{_Time / 3600:D2}:{_Time % 3600 / 60:D2}:{_Time % 3600 % 60:D2}";
        }

        void ResetTime()
        {
            _Time = _StartTime;
            UpdateTimeLabel();
        }
        private async void PlayAlarmAsync()
        {
            await Task.Run(() => alarm.Play());
            ResetTime();
        }
    }
}
