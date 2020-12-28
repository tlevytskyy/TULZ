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
        private List<TimerControl> _timers;
        public IntervalTimersControl()
        {
            InitializeComponent();
            _timers = new List<TimerControl>();
        }
        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            var temptimer = new TimerControl(Convert.ToInt32(numHour.Value),
                Convert.ToInt32(numMin.Value), Convert.ToInt32(numSec.Value));
            temptimer.E_CloseControl += new Action<TimerControl>(EH_RemoveTimer);        //set closing event on control
            temptimer.Size = new Size(flpTimers.Size.Width - 23, temptimer.Size.Height); //set width to fill panel
            flpTimers.Controls.Add(temptimer);                                           //add control to panel
            _timers.Add(temptimer);
        }
        private void EH_RemoveTimer(TimerControl timer)
        {
            flpTimers.Controls.Remove(timer);
        }
    }
}
