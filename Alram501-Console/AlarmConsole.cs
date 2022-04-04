using System;
using Alarm501;
using Alram501_Console;



namespace Alram501_Console
{
    public class AlarmConsole
    {


       
        public static void Main(string[] args)
        {
            Controller c = new Controller(AlarmSoundOff);
            string option;
            bool setting = true;
            while (setting)
            {
                c.ReadFile();
                int countnumberinfile = 1;
                foreach(Alarm a in c.alarmTime)
                {
                    Console.WriteLine($"{countnumberinfile}) {a.ToString()}");
                    countnumberinfile++;
                }
                Console.WriteLine("Add (a), Edit(e), Stop(s), Snooze(s), Quit(q)");
                option = Console.ReadLine().ToLower();
                
                //List out all the alarm in the text file.
                //Ask user what they want to do with the alarm.
                //Options are Add, Edit, Stop, and Snooze.
                //If (add)
                //If (edit)
                if(option == "a")
                {
                    c.AddAlarmConsole();
                    Console.WriteLine("Add");
                }
                if(option == "e")
                {
                    c.EditAlarmConsole();
                    Console.WriteLine("Edit");
                }
                if (option == "s")
                {
                    Console.WriteLine("Snooze");
                }
                if(option == "q")
                {
                    Console.WriteLine("Quit");
                    setting = false;
                }
            }
        }

        public static void AlarmSoundOff(Sound sound)
        {
            Console.WriteLine("Alarm is going off: " + sound);
        }
    }
}
