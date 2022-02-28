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
        //List to store alarm time
        public BindingList<Alarm> alarmTime = new BindingList<Alarm>();

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
        /// Function that will count line before new line is added
        /// </summary>
        /// <returns>Return the number of line</returns>
        private int CountLine()
        {
            using(StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
            {
                int count = 0;
                while (reader.ReadLine() !=null) count++ ;
                return count;
            }
        }

        /// <summary>
        /// Function that will start reading the alarm text file at given line
        /// </summary>
        /// <param name="lineNumber">int lineNumber is the line that it will start reading at</param>
        private void StartReadingAtLine(int lineNumber)
        {
            using(StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
            {
                for (int i = 0; i < lineNumber - 1; i++)
                {
                    reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {
                    string[] timeFromText = reader.ReadLine().Split(':');
                    bool running;
                    if (timeFromText.Contains("Running")) running = true;
                    else running = false;
                    Sound sound;
                    if (timeFromText[5] == "Radar") sound = Sound.Radar;
                    else if (timeFromText[5] == "Beacon") sound = Sound.Beacon;
                    else if (timeFromText[5] == "Chimes") sound = Sound.Chimes;
                    else if (timeFromText[5] == "Circuit") sound = Sound.Circuit;
                    else sound = Sound.Reflection;
                    alarmTime.Add(new Alarm(Convert.ToInt32(timeFromText[0]),
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4], sound));

                }

                reader.Close();
            }
        }

        /// <summary>
        /// Function that checks to see if alarm is going to go off at current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmCheck(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            foreach(Alarm alarm in alarmTime)
            {
                DateTime alarmTime = alarm.GetTime();
                if(currentTime.Hour == alarmTime.Hour && currentTime.Minute == alarmTime.Minute && currentTime.Second == alarmTime.Second)
                {
                    AlarmOff();
                    alarm.Ringing = true;
                    uxSoundLabel.Text = alarm.sound.ToString();
                }
                if (alarm.Ringing)
                {
                    if(currentTime.Hour == alarm.SnoozeTime.Hour && currentTime.Minute == alarm.SnoozeTime.Minute)
                    {
                        AlarmOff();
                    }
                }
                
            }
        }

        /// <summary>
        /// Function that changes textbox when alarm goes off
        /// </summary>
        private void AlarmOff()
        {
            uxAlarmOffTextBox.Text = "Alarm is going off!";
            uxSnoozeButton.Enabled = true;
            uxStopButton.Enabled = true;
            uxSnoozeLongerButton.Enabled = true;
        }

        /// <summary>
        /// uxSnoozeButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnoozeButton_Click(object sender, EventArgs e)
        {
            foreach(Alarm alarm in alarmTime)
            {
                if (alarm.Ringing)
                {
                    DateTime now = DateTime.Now;
                    alarm.SnoozeTime = now.AddSeconds(3);
                }
            }
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxSoundLabel.Text = " ";

        }

        /// <summary>
        /// uxStopButton_Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStopButton_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Function that reads in the Alarm text file
        /// </summary>
        private void ReadFile()
        {
            BindingList<Alarm> temp = new BindingList<Alarm>();
            if (File.Exists("..\\..\\Alarm.txt"))
            {
                StreamReader reader = new StreamReader("..\\..\\Alarm.txt");
                while (!reader.EndOfStream)
                {
                    string[] timeFromText = reader.ReadLine().Split(':');
                    bool running;
                    if (timeFromText.Contains("Running")) running = true;
                    else running = false;

                    Sound sound;
                    if (timeFromText[5] == "Radar") sound = Sound.Radar;
                    else if (timeFromText[5] == "Beacon") sound = Sound.Beacon;
                    else if (timeFromText[5] == "Chimes") sound = Sound.Chimes;
                    else if (timeFromText[5] == "Circuit") sound = Sound.Circuit;
                    else sound = Sound.Reflection;
                    temp.Add(new Alarm(Convert.ToInt32(timeFromText[0]),
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4],sound));


                }
                alarmTime = temp;
                reader.Close();
            }
        }

        private void uxSoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uxSnoozeLongerButton_Click(object sender, EventArgs e)
        {
            SnoozeButton snooze = new SnoozeButton();
            snooze.ShowDialog();
            uxAlarmList.DataSource = alarmTime;
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxSoundLabel.Text = " ";
        }
    }
}
