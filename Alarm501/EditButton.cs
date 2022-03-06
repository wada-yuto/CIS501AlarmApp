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

        /// <summary>
        /// alarm that will be changed
        /// </summary>
        private Alarm editAlarm;

        /// <summary>
        /// index in alarm list
        /// </summary>
        private int index;

        private EditButtonClickLogicDel EditButtonClickLogicDelegate;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="alarm">Alarm that will be edited</param>
        /// <param name="index">index number of the alarm in the list</param>
        public EditButton(Alarm alarm, int index, EditButtonClickLogicDel EditButtonClickLogicDelegate)
        {
            InitializeComponent();
            //controller = new Controller(this);
            editAlarm = alarm;
            uxTimePickerEdit.Value = editAlarm.GetTime();
            this.index = index;
            this.EditButtonClickLogicDelegate = EditButtonClickLogicDelegate;
            
        }

        private void uxTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EditButton_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// uxCancelButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method that returns time of edited alarm in string
        /// </summary>
        /// <returns>Returns edited time of alarm in string</returns>
        public string GetTimePickerTimeEdit()
        {
            return uxTimePickerEdit.Value.ToLongTimeString();
        }

        /// <summary>
        /// Method that returns sound of alarm in string
        /// </summary>
        /// <returns>Returns sound of alarm in string</returns>
        public string GetComboAlarmSoundEdit()
        {
            return uxAlarmSoundCombo.Text;
        }

        /// <summary>
        /// uxSetButtonEdit_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSetButtonEdit_Click(object sender, EventArgs e)
        {
            string timeForAlarm = uxTimePickerEdit.Value.ToLongTimeString();
            string timeForAlarmWithoutAmPm = timeForAlarm.Split(' ')[0];
            string runningOrNot;
            string amPm;
            string sound = uxAlarmSoundCombo.Text;

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
            string textString = timeForAlarmWithoutAmPm + ":" + runningOrNot + ":" + amPm + ":" + sound;
            EditButtonClickLogicDelegate(textString, index);
            this.Close();

        }
 
        private void uxAlarmSoundCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxAlarmSoundCombo.SelectedItem.ToString() == "Radar")
            {
                editAlarm.sound = Sound.Radar;
            }
            if (uxAlarmSoundCombo.SelectedItem.ToString() == "Beacon")
            {
                editAlarm.sound = Sound.Beacon;
            }
            if (uxAlarmSoundCombo.SelectedItem.ToString() == "Chimes")
            {
                editAlarm.sound = Sound.Chimes;
            }
            if (uxAlarmSoundCombo.SelectedItem.ToString() == "Circuit")
            {
                editAlarm.sound = Sound.Circuit;
            }
            if (uxAlarmSoundCombo.SelectedItem.ToString() == "Reflection")
            {
                editAlarm.sound = Sound.Reflection;
            }

        }
    }
}
