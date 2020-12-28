using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntervalTimers;

namespace TULZ
{
    public partial class panelSideMenu : Form
    {   
        int mov;
        int movX;
        int movY;

        IntervalTimersControl _interval;
        public panelSideMenu()
        {
            InitializeComponent();
            InitializeMenus();
            _interval = new IntervalTimersControl();
        }

        private void InitializeMenus()
        {
            panelTimerSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelTimerSubMenu.Visible == true)
                panelTimerSubMenu.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTimerSubMenu);
        }

        private void btnTimer_MouseEnter(object sender, EventArgs e)
        {
        }
        //----Move Form Args----------------------------------------------------------------------------------
        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if  (mov == 1) this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
        //----TopBarButtons----------------------------------------------------------------------------------
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIntervalTimer_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            _interval.Dock = DockStyle.Fill;
            panelMain.Controls.Add(_interval);
        }
        //----------------------------------------------------------------------------------------------------
    }
}
