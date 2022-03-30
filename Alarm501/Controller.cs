using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;
using Timers = System.Timers;


namespace Alarm501
{
    //Delegates from AddButton and EditButton
    public delegate void AlarmOffDel(Sound sound);
    public delegate int GetSnoozeTimeDel();
    public class Controller
    {

        private Timers.Timer newTimer = null;
        //List to store alarm time
        private BindingList<Alarm> alarmTime = new BindingList<Alarm>();

        private AlarmOffDel AlarmOffDelegate;
        private GetSnoozeTimeDel GetSnoozeTimeDelegate;

        /// <summary>
        /// Public Constructor for Controller
        /// </summary>
        public Controller(AlarmOffDel alarmOffDelegate, GetSnoozeTimeDel GetSnoozeTimeDelegate)
        {
            this.AlarmOffDelegate = alarmOffDelegate;
            this.GetSnoozeTimeDelegate = GetSnoozeTimeDelegate;
        }


        /// <summary>
        /// Function to change the given lines text in the alarm text file
        /// </summary>
        /// <param name="newText">string newText is the new text that will be written into the text file</param>
        /// <param name="lineNumber">int lineNumber is line number that will be changed in the text file</param>
        public void LineChanger(string newText, int lineNumber)
        {
            string[] arrLine = File.ReadAllLines("..\\..\\Alarm.txt");
            arrLine[lineNumber] = newText;
            File.WriteAllLines("..\\..\\Alarm.txt", arrLine);
        }

        /// <summary>
        /// Function that reads in the Alarm text file
        /// </summary>
        public void ReadFile()
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
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4], sound));


                }
                alarmTime = temp;
                reader.Close();
            }
        }

        /// <summary>
        /// Function that will start reading the alarm text file at given line
        /// </summary>
        /// <param name="lineNumber">int lineNumber is the line that it will start reading at</param>
        public void StartReadingAtLine(int lineNumber)
        {
            using (StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
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
        /// Function that will count line before new line is added
        /// </summary>
        /// <returns>Return the number of line</returns>
        public int CountLine()
        {
            using (StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
            {
                int count = 0;
                while (reader.ReadLine() != null) count++;
                return count;
            }
        }


        /// <summary>
        /// Function that checks to see if alarm is going to go off at current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AlarmCheckLogic()
        {
            DateTime currentTime = DateTime.Now;
            foreach (Alarm alarm in alarmTime)
            {
                DateTime alarmTime = alarm.GetTime();
                if (currentTime.Hour == alarmTime.Hour && currentTime.Minute == alarmTime.Minute && currentTime.Second == alarmTime.Second)
                {
                    AlarmOffDelegate(alarm.sound);
                    alarm.Ringing = true;
                }
                if (alarm.Ringing)
                {
                    if (currentTime.Hour == alarm.SnoozeTime.Hour && currentTime.Minute == alarm.SnoozeTime.Minute)
                    {
                        AlarmOffDelegate(alarm.sound);
                    }
                }
            }
        }

        /// <summary>
        /// Method that that handles logic when snooze button is clicked
        /// </summary>
        public void SnoozeButtonClickLogic()
        {
            foreach (Alarm alarm in alarmTime)
            {
                if (alarm.Ringing)
                {
                    DateTime now = DateTime.Now;
                    alarm.SnoozeTime = now.AddMinutes(GetSnoozeTimeDelegate());
                }
            }
        }

        /// <summary>
        /// Method that handles logic when stop button is clicked
        /// </summary>
        public void StopButtonClickLogic()
        {
            foreach (Alarm alarm in alarmTime)
            {
                if (alarm.Ringing)
                {
                    alarm.Running = false;
                    alarm.Ringing = false;
                }
            }
        }

        /// <summary>
        /// Method that handles EditButtonClickLogic
        /// </summary>
        /// <param name="finalString">finalString that will be written in the file</param>
        /// <param name="index">index where the text will be written at</param>
        public void EditButtonClickLogic(string finalString ,int index)
        {
            LineChanger(finalString, index);
        }

        /// <summary>
        /// Method that handled AddButtonClickLogic
        /// </summary>
        public void AddButtonClickLogic(string finalString)
        {
            if (File.Exists("..\\..\\Alarm.txt"))
            {
                using (StreamWriter writer = new StreamWriter("..\\..\\Alarm.txt", true))
                {
                    writer.WriteLine(finalString);
                }

            }
        }

        /// <summary>
        /// Return the count of alarmTime
        /// </summary>
        /// <returns>Return the count of alarmTime</returns>
        public BindingList<Alarm> GetAlarmTime()
        {
            return alarmTime;
        }

        /*
        public void AlarmUpdate()
        {
            newTimer = new System.Timers.Timer(1000);
            newTimer.Elapsed += AlarmCheckLogic;
            newTimer.SynchronizingObject = this;
            newTimer.AutoReset = true;
            newTimer.Start();
        }
        */
    }
}
