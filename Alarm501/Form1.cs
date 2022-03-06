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
    public delegate BindingList<Alarm> GetAlarmTimeDel();
    public delegate void AddButtonClickLogicDel(string finalString);
    public delegate void EditButtonClickLogicDel(string finalString, int index);
    public partial class Form1 : Form
    {
        //private Controller controller;

        private Timers.Timer newTimer = null;

        ReadFileDel ReadFileDelegate;
        CountLineDel CountLineDelegate;
        StartReadingAtLineDel StartReadingAtLineDelegate;
        AlarmCheckDel AlarmCheckDelegate;
        SnoozeButtonClickLogicDel SnoozeButtonClickLogicDelegate;
        StopButtonClickDel StopButtonClickDelegate;
        GetAlarmTimeDel GetAlarmTimeDelegate;
        AddButtonClickLogicDel AddButtonClickLogicDelegate;
        EditButtonClickLogicDel EditButtonClickLogicDelegate;

        /// <summary>
        /// Constructor for Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
  
        }

        /// <summary>
        /// Function that checks to see if alarm is going to go off at current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmCheck(object sender, ElapsedEventArgs e)
        {
            AlarmCheckDelegate();
        }



        /// <summary>
        /// xAddButton_Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddButton_Click(object sender, EventArgs e)
        {
            
            AddButton ad = new AddButton(AddButtonClickLogicDelegate);
            ad.ShowDialog();
            StartReadingAtLineDelegate(CountLineDelegate());
            uxAlarmList.DataSource = GetAlarmTimeDelegate();
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;


        }

        /// <summary>
        /// uxEditButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEditButton_Click(object sender, EventArgs e)
        {
            EditButton ed = new EditButton(GetAlarmTimeDelegate()[uxAlarmList.SelectedIndex], uxAlarmList.SelectedIndex, EditButtonClickLogicDelegate);
            ed.ShowDialog();
            ReadFileDelegate(); //Call ReadFile from controller
            uxAlarmList.DataSource = GetAlarmTimeDelegate();
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
            StopButtonClickDelegate();

            uxSoundLabel.Text = " ";
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxAlarmList.DataSource = null;
            uxAlarmList.DataSource = GetAlarmTimeDelegate();

        }

        public void SetUp(ReadFileDel ReadFileDelegate,CountLineDel CountLineDelegate,StartReadingAtLineDel StartReadingAtLineDelegate,
        AlarmCheckDel AlarmCheckDelegate,SnoozeButtonClickLogicDel SnoozeButtonClickLogicDelegate,StopButtonClickDel StopButtonClickDelegate,
        GetAlarmTimeDel GetAlarmTimeDelegate, AddButtonClickLogicDel AddButtonClickLogicDelegate, EditButtonClickLogicDel EditButtonClickLogicDelegate)
        {
            this.ReadFileDelegate = ReadFileDelegate;
            this.CountLineDelegate = CountLineDelegate;
            this.StartReadingAtLineDelegate = StartReadingAtLineDelegate;
            this.AlarmCheckDelegate = AlarmCheckDelegate;
            this.SnoozeButtonClickLogicDelegate = SnoozeButtonClickLogicDelegate;
            this.StopButtonClickDelegate = StopButtonClickDelegate;
            this.GetAlarmTimeDelegate = GetAlarmTimeDelegate;
            this.AddButtonClickLogicDelegate = AddButtonClickLogicDelegate;
            this.EditButtonClickLogicDelegate = EditButtonClickLogicDelegate;

            if (GetAlarmTimeDelegate().Count() != 0) uxEditButton.Enabled = true;

            ReadFileDelegate(); //Call ReadFile from controller

            uxAlarmList.DataSource = GetAlarmTimeDelegate();

            newTimer = new System.Timers.Timer(1000);
            newTimer.Elapsed += AlarmCheck;
            newTimer.SynchronizingObject = this;
            newTimer.AutoReset = true;
            newTimer.Start();

            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;
        }

       

        private void uxSoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
