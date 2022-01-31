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
        BindingList<Alarm> alarmTime = new BindingList<Alarm>();

        Timers.Timer newTimer = null;



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




        private void uxAddButton_Click(object sender, EventArgs e)
        {
            
            AddButton ad = new AddButton();
            ad.ShowDialog();
            int after = CountLine();
            StartReadingAtLine(CountLine());
            uxAlarmList.DataSource = alarmTime;
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;


        }

        private void uxEditButton_Click(object sender, EventArgs e)
        {
            EditButton ed = new EditButton(alarmTime[uxAlarmList.SelectedIndex], uxAlarmList.SelectedIndex);
            ed.ShowDialog();
            ReadFile();
            uxAlarmList.DataSource = alarmTime;
            if (uxAlarmList.SelectedItem != null) uxEditButton.Enabled = true;

        }


        private int CountLine()
        {
            using(StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
            {
                int count = 0;
                while (reader.ReadLine() !=null) count++ ;
                return count;
            }
        }

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
                    alarmTime.Add(new Alarm(Convert.ToInt32(timeFromText[0]),
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4]));

                }

                reader.Close();
            }
        }

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
                }
                if (alarm.Ringing)
                {
                    if(currentTime.Hour == alarm.SnoozeTime.Hour && currentTime.Minute == alarm.SnoozeTime.Minute && currentTime.Second == alarm.SnoozeTime.Second)
                    {
                        AlarmOff();
                    }
                }
                
            }
        }

        private void AlarmOff()
        {
            uxAlarmOffTextBox.Text = "Alarm is going off!";
            uxSnoozeButton.Enabled = true;
            uxStopButton.Enabled = true;
        }

        /// <summary>
        /// 
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

        }

        /// <summary>
        /// 
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
            uxSnoozeButton.Enabled = false;
            uxStopButton.Enabled = false;
            uxAlarmOffTextBox.Text = " ";
            uxAlarmList.DataSource = null;
            uxAlarmList.DataSource = alarmTime;


        }

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
                    temp.Add(new Alarm(Convert.ToInt32(timeFromText[0]),
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4]));


                }
                alarmTime = temp;
                reader.Close();
            }
        }

        

    }
}
