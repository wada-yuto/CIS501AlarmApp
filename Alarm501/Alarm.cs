using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace Alarm501
{
    /// <summary>
    /// Class representing one alarm being set
    /// </summary>
    public class Alarm : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// DateTime representing time after snooze
        /// </summary>
        public DateTime SnoozeTime;


        /// <summary>
        /// Represent hour in alarm
        /// </summary>
        private int _hour { get; set; }

        /// <summary>
        /// Represent minuets in alarm
        /// </summary>
        private int _minutes { get; set; }

        /// <summary>
        /// Represent seconds in alarm
        /// </summary>
        private int _seconds { get; set; }

        /// <summary>
        /// Represent whether alarm clock is running for not
        /// </summary>
        private bool _running { get; set; }

        /// <summary>
        /// Represent whether time is am or pm
        /// </summary>
        private string _amPM { get; set; }

        /// <summary>
        /// Represents if alarm is ringing or not
        /// </summary>
        public bool Ringing { get; set; } = false;



        /// <summary>
        /// Hour of the alarm
        /// </summary>
        public int Hour
        {
            get => _hour;
            set
            {
                if(_hour != value)
                {
                    _hour = value;
                    OnPropertyChanged(nameof(Minutes));
                    OnPropertyChanged(nameof(Seconds));

                }
            }
        }

        /// <summary>
        /// Minuets of the alarm
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                if(_minutes != value)
                {
                    _minutes = value;
                    OnPropertyChanged(nameof(Hour));
                    OnPropertyChanged(nameof(Minutes));
                    OnPropertyChanged(nameof(Seconds));
                }
            }
        }

        /// <summary>
        /// Seconds of the alarm
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                if(_seconds != value)
                {
                    _seconds = value;
                    OnPropertyChanged(nameof(Hour));
                    OnPropertyChanged(nameof(Minutes));
                    OnPropertyChanged(nameof(Seconds));
                }
            }
        }

        /// <summary>
        /// Boolean representing if the alarm is running or not
        /// </summary>
        public bool Running
        {
            get => _running;
            set
            {
                if(_running != value)
                {
                    _running = value;

                }
            }
        }

        /// <summary>
        /// Stirng representing if alarm is in AM or PM
        /// </summary>
        public string AmPm
        {
            get => _amPM;
            set
            {
                if(_amPM != value)
                {
                    _amPM = value;
                }
            }
        }

        /// <summary>
        /// Overriden ToString that returns alarm string in a certain format
        /// </summary>
        /// <returns>Returns alarm string</returns>
        public override string ToString()
        {
            string runningString;
            if (Running) runningString = "Running";
            else runningString = "Not Running";
            return String.Format("{0:D}:{1:00} {2} {3}", Hour, Minutes, AmPm.ToLower(), runningString);

        }


        /// <summary>
        /// Constructor of Alarm class
        /// </summary>
        /// <param name="hourIn">hour of the alarm clock being set</param>
        /// <param name="minuetsIn">minuets of alarm clock being set</param>
        /// <param name="secondsIn">seconds of alarm clock being set</param>
        /// <param name="runningIn">boolean value of whether alarm clock is runnign or not</param>
        public Alarm(int hourIn, int minuetsIn, int secondsIn, bool runningIn, string amPm)
        {
            Hour = hourIn;
            Minutes = minuetsIn;
            Seconds = secondsIn;
            Running = runningIn;
            AmPm = amPm;
            SnoozeTime = GetTime();

        }

        /// <summary>
        /// Used to trigger a PropertyChanged Event
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Convert time into DateTime object
        /// </summary>
        /// <returns>Returns current time</returns>
        public DateTime GetTime()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Hour.ToString());
            builder.Append(":");
            builder.Append(Minutes.ToString());
            builder.Append(" ");
            builder.Append(AmPm);
            return DateTime.Parse(builder.ToString());
        }



    }
}
