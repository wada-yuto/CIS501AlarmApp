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
    public delegate void EditButtonClickLogicDel(Alarm editAlarm, int index);
    public partial class EditButton : Form
    {
        /// <summary>
        /// Controller without initializer
        /// </summary>
        Controller controller;

        /// <summary>
        /// alarm that will be changed
        /// </summary>
        Alarm editAlarm;

        /// <summary>
        /// index in alarm list
        /// </summary>
        int index;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="alarm">Alarm that will be edited</param>
        /// <param name="index">index number of the alarm in the list</param>
        public EditButton(Alarm alarm, int index)
        {
            InitializeComponent();
            controller = new Controller(this);
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
            EditButtonClickLogicDel EditButonClickLogicDelegate = new EditButtonClickLogicDel(controller.EditButtonClickLogic);
            EditButonClickLogicDelegate(editAlarm, index);
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
