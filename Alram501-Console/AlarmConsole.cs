using System;
using Alarm501;
using Alram501_Console;



namespace Alram501_Console
{
    public class AlarmConsole
    {


       
        public static void Main(string[] args)
        {
            Controller c = new Controller(AlarmSoundOff, GetSnoozeTime);
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
                Console.WriteLine("Add (a), Edit(e), Snooze(z), Stop(s),z Quit(q)");
                option = Console.ReadLine().ToLower();
                
                
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
                if(option == "z")
                {
                    c.SnoozeButtonClickLogic();
                }
                if(option == "s")
                { 
                    c.StopButtonClickLogic(); 
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
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Alarm is going off: " + sound);
            Console.WriteLine("-------------------------------");
        }

        public static int GetSnoozeTime()
        {
            int snooze = 0;
            Console.WriteLine("How long do you wanna snooze for?");
            snooze = Convert.ToInt32(Console.ReadLine());
            return snooze;
        }
    }
}
