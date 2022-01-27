using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timers = System.Timers;
using System.IO;

namespace Alarm501
{
    public partial class Form1 : Form

    {
        //List to store alarm time
        BindingList<Alarm> alarmTime = new BindingList<Alarm>();

        Timers.Timer newTimer = null;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists("..\\..\\Alarm.txt"))
            {
                StreamReader reader = new StreamReader("..\\..\\Alarm.txt");
                while (!reader.EndOfStream)
                {
                    string[] timeFromText = reader.ReadLine().Split(':');
                    bool running;
                    if (timeFromText.Contains("Running")) running = true;
                    else running = false;
                    alarmTime.Add(new Alarm(Convert.ToInt32(timeFromText[0]),
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4]));


                }
                reader.Close();
            }
            uxAlarmList.DataSource = alarmTime;

            newTimer = new System.Timers.Timer(1000);

        } 




        private void uxAddButton_Click(object sender, EventArgs e)
        {
            int before = CountLine();
            AddButton ad = new AddButton();
            ad.ShowDialog();
            int after = CountLine();
            StartReadingAtLine(CountLine());
            uxAlarmList.DataSource = alarmTime;


        }

        private void uxEditButton_Click(object sender, EventArgs e)
        {
            EditButton ed = new EditButton();
            ed.ShowDialog();
       
        }


        private int CountLine()
        {
            using(StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
            {
                int count = 0;
                while (reader.ReadLine() !=null) count++ ;
                return count;
            }
        }

        private void StartReadingAtLine(int lineNumber)
        {
            using(StreamReader reader = new StreamReader("..\\..\\Alarm.txt"))
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
                    alarmTime.Add(new Alarm(Convert.ToInt32(timeFromText[0]),
                        Convert.ToInt32(timeFromText[1]), Convert.ToInt32(timeFromText[2]), running, timeFromText[4]));

                }

                reader.Close();
            }
            


        }

        private void Check(object sender, Timers.ElapsedEventArgs e)
        {
            AlarmStatus.
        }

    }
}
