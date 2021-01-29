using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTimers
{
    public partial class IntervalTimersControl : UserControl
    {
        public IntervalTimersControl()
        {
            InitializeComponent();
        }
        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            var temptimer = new TimerControl(Convert.ToInt32(numHour.Value),
                Convert.ToInt32(numMin.Value), Convert.ToInt32(numSec.Value),true);
            temptimer.E_CloseControl += new Action<TimerControl>(EH_RemoveTimer);        //set closing event on control
            temptimer.Size = new Size(flpTimers.Size.Width - 23, temptimer.Size.Height); //set width to fill panel
            flpTimers.Controls.Add(temptimer);                                           //add control to panel
        }
        private void EH_RemoveTimer(TimerControl timer)
        {
            flpTimers.Controls.Remove(timer);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach(TimerControl t in flpTimers.Controls)
            {
                t.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            foreach (TimerControl t in flpTimers.Controls)
            {
                t.Stop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TimerControl t in flpTimers.Controls)
            {
                t.Reset();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            flpTimers.Controls.Clear();
        }

        private void flpTimers_SizeChanged(object sender, EventArgs e)
        {
            foreach(TimerControl c in flpTimers.Controls)
            {
                c.Size = new Size(flpTimers.Size.Width - 23, c.Size.Height);
            }
        }
    }
}
