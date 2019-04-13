using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Shutdown_2
{
    public partial class FormMain : Form
    {
        public FormMain()//form ititilisation
        {
            InitializeComponent();
        }
        bool timedShutdownActive = false;
        DateTime shutdownTime = new DateTime();
        DateTime currentTime = new DateTime();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddSeconds(5);
            timer.Start();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }
        public void UpdateLabel()
        {
            shutdownTime = dateTimePicker1.Value;
            currentTime = DateTime.Now;
            int timeRelation = shutdownTime.CompareTo(currentTime);
            if (timeRelation >= 0 ||(shutdownTime.Hour == currentTime.Hour && shutdownTime.Minute == currentTime.Minute))//happening in the future
            {
                labelDate.Text = DateTime.Now.ToString("D");
            }
            else
            {
                labelDate.Text = DateTime.Now.AddDays(1).ToString("D");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;
            int hourToShutdown = shutdownTime.Hour;
            int minToShutdown = shutdownTime.Minute;
            if (timedShutdownActive)
            {
                if (currentHour == hourToShutdown)
                {
                    if (currentMinute == minToShutdown)
                    {
                        ShutdownComputer();
                    }
                }
            }
        }

        private void ShutdownComputer()
        {
            System.Diagnostics.Process.Start("shutdown","/s /t 0");
        }

        private void ButtonTimedShutdown_Click(object sender, EventArgs e)
        {
            timedShutdownActive = true;//
            buttonTimedShutdown.Enabled = false;
            buttonCancelShutdown.Enabled = true;
        }

        private void ButtonCancelShutdown_Click(object sender, EventArgs e)
        {
            timedShutdownActive = false;
            buttonTimedShutdown.Enabled = true;
            buttonCancelShutdown.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShutdownComputer();
        }
    }
}
