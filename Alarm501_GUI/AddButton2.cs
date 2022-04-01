using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alarm501;

namespace Alarm501_GUI
{
    
    public partial class AddButton2 : Form
    {
        private AddButtonClickLogicDel AddButtonClickLogicDelegate;
        public AddButton2(AddButtonClickLogicDel AddButtonClickLogicDelegate)
        {
            InitializeComponent();
            this.AddButtonClickLogicDelegate = AddButtonClickLogicDelegate;
            
        }

        /// <summary>
        /// Returns time for the alarm in string
        /// </summary>
        /// <returns>Returns the alarm time set in string</returns>
        public string GetTimePickerTimeAdd()
        {
            return uxTimePickerAdd.Value.ToLongTimeString();
        }

        /// <summary>
        /// Method to return the text inside uxSoundCombo
        /// </summary>
        /// <returns>Returns the sound in string</returns>
        public string GetComboAlarmSoundAdd()
        {
            return uxSoundCombo.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string timeForAlarm = uxTimePickerAdd.Value.ToLongTimeString();
            string timeForAlarmWithoutAmPm = timeForAlarm.Split(' ')[0];
            string runningOrNot;
            string amPm;
            string sound = uxSoundCombo.Text;

            if (timeForAlarm.Contains("AM")) amPm = "AM";
            else amPm = "PM";

            bool running;

            if (uxOnCheckBoxAdd.Checked == true) running = true;
            else running = false;

            if (running) runningOrNot = "Running";
            else runningOrNot = "No";

            string finalString = timeForAlarmWithoutAmPm + ":" + runningOrNot + ":" + amPm + ":" + sound;
            AddButtonClickLogicDelegate(finalString);
            this.Close();
        }

        private void uxCancelButtonAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxSoundCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
