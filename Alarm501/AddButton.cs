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
    public partial class AddButton : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AddButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// uxSetButtonAdd_Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSetButtonAdd_Click(object sender, EventArgs e)
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


            if (File.Exists("..\\..\\Alarm.txt"))
            {
                using (StreamWriter writer = new StreamWriter("..\\..\\Alarm.txt", true))
                {
                    writer.WriteLine(finalString);
                }

            }
            this.Close();


        }

        private void uxCancelButtonAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
