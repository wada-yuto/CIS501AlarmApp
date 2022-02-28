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
using System.Collections;

namespace Alarm501
{
    public partial class SnoozeButton : Form
    {
        public SnoozeButton()
        {
            InitializeComponent();

        }

        private void uxSetButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            BindingList<Alarm> alarmTime = form.alarmTime;
            
            foreach (Alarm alarm in alarmTime)
            {
                if (alarm.Ringing)
                {
                    DateTime now = DateTime.Now;
                    alarm.SnoozeTime = now.AddMinutes((int)uxSnoozeTimeUpDown.Value);
                }
            }

            this.Close();
            
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
