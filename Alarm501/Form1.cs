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
    public delegate void ReadFileDel();
    public delegate int CountLineDel();
    public delegate void StartReadingAtLineDel(int line);
    public delegate void AlarmCheckDel();
    public delegate void SnoozeButtonClickLogicDel();
    public delegate void StopButtonClickDel();
    public partial class Form1 : Form
    {
        Controller controller;

        Timers.Timer newTimer = null;


        /// <summary>
        /// Constructor for Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            controller = new Controller(this);
            if (controller.alarmTime.Count != 0) uxEditButton.Enabled = true;

            ReadFileDel ReadFileDelegate= new ReadFileDel(controller.ReadFile);
            ReadFileDelegate(); //Call ReadFile from controller
           
            uxAlarmList.DataSource = controller.alarmTime;

            newTimer = new System.Timers.Timer(1000);
            newTimer.Elapsed += AlarmCheck; 
            newTimer.SynchronizingObject = this;
            newTimer.AutoReset = true;
            newTimer.Start();

            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;

        }

        /// <summary>
        /// Function that checks to see if alarm is going to go off at current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmCheck(object sender, ElapsedEventArgs e)
        {
            AlarmCheckDel AlarmCheckDelegate = new AlarmCheckDel(controller.AlarmCheckLogic);
            AlarmCheckDelegate();
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
            StartReadingAtLineDel StartReadingAtLineDelegate = new StartReadingAtLineDel(controller.StartReadingAtLine);
            CountLineDel CountLineDelegate = new CountLineDel(controller.CountLine);
            StartReadingAtLineDelegate(CountLineDelegate());
            uxAlarmList.DataSource = controller.alarmTime;
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;


        }

        /// <summary>
        /// uxEditButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEditButton_Click(object sender, EventArgs e)
        {
            EditButton ed = new EditButton(controller.alarmTime[uxAlarmList.SelectedIndex], uxAlarmList.SelectedIndex);
            ed.ShowDialog();
            ReadFileDel ReadFileDelegate = new ReadFileDel(controller.ReadFile);
            ReadFileDelegate(); //Call ReadFile from controller
            uxAlarmList.DataSource = controller.alarmTime;
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;

        }


        


        /// <summary>
        /// Function that changes textbox when alarm goes off
        /// </summary>
        public void AlarmOff(Sound sound)
        {
            uxAlarmOffTextBox.Text = "Alarm is going off!";
            uxSoundLabel.Text = sound.ToString();
            uxSnoozeButton.Enabled = true;
            uxStopButton.Enabled = true;
            uxSnoozeTimeUpDown.Enabled = true;
        }

        /// <summary>
        /// Gets the time for snooze and return the time
        /// </summary>
        /// <returns>Returns the time for snooze</returns>
        public int GetSnoozeTime()
        {
            return Convert.ToInt32(uxSnoozeTimeUpDown.Value);
        }

        /// <summary>
        /// uxSnoozeButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnoozeButton_Click(object sender, EventArgs e)
        {
            //Create method in controller for this part of the logic
            SnoozeButtonClickLogicDel SnoozeButtonClickLogicDelegate = new SnoozeButtonClickLogicDel(controller.SnoozeButtonClickLogic);
            SnoozeButtonClickLogicDelegate();

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
            StopButtonClickDel StopButtonClickDelegate = new StopButtonClickDel(controller.StopButtonClickLogic);
            StopButtonClickDelegate();

            uxSoundLabel.Text = " ";
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxAlarmList.DataSource = null;
            uxAlarmList.DataSource = controller.alarmTime;


        }

       

        private void uxSoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
