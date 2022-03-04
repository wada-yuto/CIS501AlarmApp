using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;

namespace Alarm501
{
    public delegate void AlarmOffDel(Sound sound);
    public delegate int GetSnoozeTimeDel();
    public delegate string GetTimePickerTimeEditDel();
    public delegate string GetComboAlarmSoundEditDel();
    public delegate string GetTimePickerTimeAddDel();
    public delegate string GetComboAlarmSoundAddDel();
    public class Controller
    {
        /// <summary>
        /// Object form1
        /// </summary>
        Form form;

        //List to store alarm time
        public BindingList<Alarm> alarmTime = new BindingList<Alarm>();

        /// <summary>
        /// Public Constructor for Controller
        /// </summary>
        public Controller(Form form)
        {
            this.form = form;
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
                    AlarmOffDel AlarmOffDelegate = new AlarmOffDel(((Form1)this.form).AlarmOff);
                    AlarmOffDelegate(alarm.sound);
                    //AlarmOff(alarm.sound); //Pass this as a delegate from views
                    alarm.Ringing = true;
                }
                if (alarm.Ringing)
                {
                    if (currentTime.Hour == alarm.SnoozeTime.Hour && currentTime.Minute == alarm.SnoozeTime.Minute)
                    {
                        AlarmOffDel AlarmOffDelegate = new AlarmOffDel(((Form1)this.form).AlarmOff);
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
            GetSnoozeTimeDel GetSnoozeTimeDelegate = new GetSnoozeTimeDel(((Form1)this.form).GetSnoozeTime);
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
        /// 
        /// </summary>
        /// <param name="editAlarm"></param>
        public void EditButtonClickLogic(Alarm editAlarm ,int index)
        {
            GetTimePickerTimeEditDel GetTimePickerTimeDelegate = new GetTimePickerTimeEditDel(((EditButton)this.form).GetTimePickerTimeEdit);
            GetComboAlarmSoundEditDel GetComboAlarmSoundDelegate = new GetComboAlarmSoundEditDel(((EditButton)this.form).GetComboAlarmSoundEdit);
            string timeForAlarm = GetTimePickerTimeDelegate();
            string timeForAlarmWithoutAmPm = timeForAlarm.Split(' ')[0];
            string runningOrNot;
            string amPm;
            string sound = GetComboAlarmSoundDelegate();

            if (timeForAlarm.Contains("AM"))
            {
                amPm = "AM";
                editAlarm.AmPm = amPm;
            }
            else
            {
                amPm = "PM";
                editAlarm.AmPm = amPm;
            }

            bool running;

            if (((EditButton)this.form).uxOnCheckBoxEdit.Checked == true)
            {
                running = true;
                editAlarm.Running = true;
            }
            else
            {
                running = false;
                editAlarm.Running = false;
            }

            if (running) runningOrNot = "Running";
            else runningOrNot = "No";

            //String to write to the text file
            string textString = timeForAlarmWithoutAmPm + ":" + runningOrNot + ":" + amPm + ":" + sound;
            LineChanger(textString, index);
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddButtonClickLogic()
        {
            GetTimePickerTimeAddDel GetTimePickerTimeAddDelegate = new GetTimePickerTimeAddDel(((AddButton)this.form).GetTimePickerTimeAdd);
            GetComboAlarmSoundAddDel GetComboAlarmSoundAddDelegate = new GetComboAlarmSoundAddDel(((AddButton)this.form).GetComboAlarmSoundAdd);

            string timeForAlarm = GetTimePickerTimeAddDelegate();
            string timeForAlarmWithoutAmPm = timeForAlarm.Split(' ')[0];
            string runningOrNot;
            string amPm;
            string sound = GetComboAlarmSoundAddDelegate();

            if (timeForAlarm.Contains("AM")) amPm = "AM";
            else amPm = "PM";

            bool running;

            if (((AddButton)this.form).uxOnCheckBoxAdd.Checked == true) running = true;
            else running = false;

            if (running) runningOrNot = "Running";
            else runningOrNot = "No";

            string finalString = timeForAlarmWithoutAmPm + ":" + runningOrNot + ":" + amPm + ":" + sound;


            if (File.Exists("..\\..\\Alarm.txt"))
            {
                using (StreamWriter writer = new StreamWriter("..\\..\\Alarm.txt", true))
                {
                    writer.WriteLine(finalString);
                }

            }
        }
    }
}
