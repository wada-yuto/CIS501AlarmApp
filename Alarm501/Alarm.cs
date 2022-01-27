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
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Represent hour in alarm
        /// </summary>
        private int _hour { get; set; }

        /// <summary>
        /// Represent minuets in alarm
        /// </summary>
        private int _minuets { get; set; }

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




        public int Hour
        {
            get => _hour;
            set
            {
                if(_hour != value)
                {
                    _hour = value;
                    OnPropertyChanged(nameof(Minuets));
                    OnPropertyChanged(nameof(Seconds));

                }
            }
        }

        public int Minuets
        {
            get => _minuets;
            set
            {
                if(_minuets != value)
                {
                    _minuets = value;
                    OnPropertyChanged(nameof(Hour));
                    OnPropertyChanged(nameof(Minuets));
                    OnPropertyChanged(nameof(Seconds));
                }
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                if(_seconds != value)
                {
                    _seconds = value;
                    OnPropertyChanged(nameof(Hour));
                    OnPropertyChanged(nameof(Minuets));
                    OnPropertyChanged(nameof(Seconds));
                }
            }
        }

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


        public override string ToString()
        {
            string runningString;
            if (Running) runningString = "Running";
            else runningString = "Not Running";
            return String.Format("{0:D}:{1:00} {2} {3}", Hour, Minuets, AmPm.ToLower(), runningString);

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
            Minuets = minuetsIn;
            Seconds = secondsIn;
            Running = runningIn;
            AmPm = amPm;

        }

        /// <summary>
        /// Used to trigger a PropertyChanged Event
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
