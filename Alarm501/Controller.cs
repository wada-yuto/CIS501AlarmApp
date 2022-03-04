using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Timers;

namespace Alarm501
{
    public class Controller
    {
        //List to store alarm time
        public BindingList<Alarm> alarmTime = new BindingList<Alarm>();


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
        private void StartReadingAtLine(int lineNumber)
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
        private int CountLine()
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
        private void AlarmCheck(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            foreach (Alarm alarm in alarmTime)
            {
                DateTime alarmTime = alarm.GetTime();
                if (currentTime.Hour == alarmTime.Hour && currentTime.Minute == alarmTime.Minute && currentTime.Second == alarmTime.Second)
                {
                    AlarmOff(alarm.sound); //Pass this as a delegate from views
                    alarm.Ringing = true;
                }
                if (alarm.Ringing)
                {
                    if (currentTime.Hour == alarm.SnoozeTime.Hour && currentTime.Minute == alarm.SnoozeTime.Minute)
                    {
                        AlarmOff(alarm.sound);
                    }
                }

            }
        }
    }
}
