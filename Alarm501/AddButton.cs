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
    public delegate void AddButtonClickLogicDel();
    public partial class AddButton : Form
    {
        Controller controller;

        /// <summary>
        /// Constructor
        /// </summary>
        public AddButton()
        {
            InitializeComponent();
            controller = new Controller(this);
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

        /// <summary>
        /// uxSetButtonAdd_Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSetButtonAdd_Click(object sender, EventArgs e)
        {
            AddButtonClickLogicDel AddButtonClickLogicDelegate = new AddButtonClickLogicDel(controller.AddButtonClickLogic);
            AddButtonClickLogicDelegate();
            this.Close();


        }

        private void uxCancelButtonAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
