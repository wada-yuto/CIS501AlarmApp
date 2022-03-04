using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timers = System.Timers;
using System.IO;
using System.Timers;

namespace Alarm501
{
    public partial class Form1 : Form
    {

        Timers.Timer newTimer = null;


        /// <summary>
        /// Constructor for Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            if(alarmTime.Count != 0) uxEditButton.Enabled = true;

            ReadFile();
           
            uxAlarmList.DataSource = alarmTime;

            newTimer = new System.Timers.Timer(1000);
            newTimer.Elapsed += AlarmCheck;
            newTimer.SynchronizingObject = this;
            newTimer.AutoReset = true;
            newTimer.Start();

            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;

        }



        /// <summary>
        /// xAddButton_Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddButton_Click(object sender, EventArgs e)
        {
            
            AddButton ad = new AddButton();
            ad.ShowDialog();
            int after = CountLine();
            StartReadingAtLine(CountLine());
            uxAlarmList.DataSource = alarmTime;
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;


        }

        /// <summary>
        /// uxEditButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEditButton_Click(object sender, EventArgs e)
        {
            EditButton ed = new EditButton(alarmTime[uxAlarmList.SelectedIndex], uxAlarmList.SelectedIndex);
            ed.ShowDialog();
            ReadFile();
            uxAlarmList.DataSource = alarmTime;
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;

        }


        


        /// <summary>
        /// Function that changes textbox when alarm goes off
        /// </summary>
        private void AlarmOff(Sound sound)
        {
            uxAlarmOffTextBox.Text = "Alarm is going off!";
            uxSoundLabel.Text = sound.ToString();
            uxSnoozeButton.Enabled = true;
            uxStopButton.Enabled = true;
            uxSnoozeTimeUpDown.Enabled = true;
        }

        /// <summary>
        /// uxSnoozeButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnoozeButton_Click(object sender, EventArgs e)
        {
            //Create method in controller for this part of the logic
            foreach(Alarm alarm in alarmTime)
            {
                if (alarm.Ringing)
                {
                    DateTime now = DateTime.Now;
                    alarm.SnoozeTime = now.AddMinutes(Convert.ToInt32(uxSnoozeTimeUpDown.Value));
                }
            }
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxSoundLabel.ResetText();
            uxSnoozeTimeUpDown.ResetText();

        }

        /// <summary>
        /// uxStopButton_Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStopButton_Click(object sender, EventArgs e)
        {
            //Create method for this part of the logic
            foreach (Alarm alarm in alarmTime)
            {
                if (alarm.Ringing)
                {
                    alarm.Running = false;
                    alarm.Ringing = false;
                }
            }
            uxSoundLabel.Text = " ";
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxAlarmList.DataSource = null;
            uxAlarmList.DataSource = alarmTime;


        }

       

        private void uxSoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
