using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alarm501
{
    public partial class EditButton : Form
    {

        Alarm editAlarm;

        int index;

        public EditButton(Alarm alarm, int index)
        {
            InitializeComponent();
            editAlarm = alarm;
            uxTimePickerEdit.Value = editAlarm.GetTime();
            this.index = index;
            
        }

        private void uxTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EditButton_Load(object sender, EventArgs e)
        {

        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxSetButtonEdit_Click(object sender, EventArgs e)
        {
            string timeForAlarm = uxTimePickerEdit.Value.ToLongTimeString();
            string timeForAlarmWithoutAmPm = timeForAlarm.Split(' ')[0];
            string runningOrNot;
            string amPm;

            if (timeForAlarm.Contains("AM"))
            {
                amPm = "AM";
                editAlarm.AmPm = amPm;
            }
            else {
                amPm = "PM";
                editAlarm.AmPm = amPm;
            }

            bool running;

            if (uxOnCheckBoxEdit.Checked == true)
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
            string textString = timeForAlarmWithoutAmPm + ":" + runningOrNot + ":" + amPm;
            LineChanger(textString, index);
            this.Close();



        }

        /// <summary>
        /// Function to change the given lines text in the alarm text file
        /// </summary>
        /// <param name="newText">string newText is the new text that will be written into the text file</param>
        /// <param name="lineNumber">int index is line number that will be changed in the text file</param>
        public void LineChanger(string newText, int lineNumber)
        {
            string[] arrLine = File.ReadAllLines("..\\..\\Alarm.txt");
            arrLine[lineNumber] = newText;
            File.WriteAllLines("..\\..\\Alarm.txt", arrLine);
        }


    }
}
